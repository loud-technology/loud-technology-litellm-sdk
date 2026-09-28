#!/usr/bin/env bash
set -Eeuo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
RUNTIME_DIR="${TMPDIR:-/tmp}/litellm-docs-preview-${UID:-user}"
VENV_DIR="$RUNTIME_DIR/venv"
PID_FILE="$RUNTIME_DIR/server.pid"
LOG_FILE="$RUNTIME_DIR/server.log"
REQUIREMENTS_HASH_FILE="$RUNTIME_DIR/requirements.sha256"
SITE_DIR="$ROOT_DIR/site"
RENDER_DIR="$ROOT_DIR/artifacts/docs-preview"
HOST="${DOCS_HOST:-127.0.0.1}"
PORT="${DOCS_PORT:-8123}"
BASE_URL="http://${HOST}:${PORT}"

mkdir -p "$RUNTIME_DIR"

print_usage() {
  cat <<'EOF'
Usage: ./scripts/docs-preview.sh COMMAND [PAGE]

Commands:
  open, abrir [PAGE]       Build, start the server, and open the docs browser.
  render, renderizar [PAGE] Build and create desktop + compact PNG renders.
  build                    Build the MkDocs site with strict warnings.
  status                   Show local preview server status.
  stop, parar              Stop the background preview server.
  clean                    Stop the server and remove cached preview files.

Examples:
  ./scripts/docs-preview.sh open
  ./scripts/docs-preview.sh abrir guides/api-surface/
  ./scripts/docs-preview.sh render

Environment:
  DOCS_HOST       Server host. Default: 127.0.0.1
  DOCS_PORT       Server port. Default: 8123
  DOCS_NO_OPEN=1  Do not launch the browser or rendered PNG files.
EOF
}

requirements_hash() {
  python3 - "$ROOT_DIR/docs/requirements.txt" <<'PY'
from hashlib import sha256
from pathlib import Path
import sys
print(sha256(Path(sys.argv[1]).read_bytes()).hexdigest())
PY
}

ensure_environment() {
  local expected_hash current_hash=""
  expected_hash="$(requirements_hash)"

  if [[ -f "$REQUIREMENTS_HASH_FILE" ]]; then
    current_hash="$(cat "$REQUIREMENTS_HASH_FILE")"
  fi

  if [[ ! -x "$VENV_DIR/bin/mkdocs" || "$current_hash" != "$expected_hash" ]]; then
    printf 'Preparing documentation tools...\n'
    rm -rf "$VENV_DIR"
    python3 -m venv "$VENV_DIR"
    PIP_DEFAULT_TIMEOUT=15 "$VENV_DIR/bin/python" -m pip install \
      --quiet \
      --disable-pip-version-check \
      --retries 2 \
      --requirement "$ROOT_DIR/docs/requirements.txt"
    printf '%s\n' "$expected_hash" > "$REQUIREMENTS_HASH_FILE"
  fi
}

build_site() {
  ensure_environment
  printf 'Building documentation...\n'
  (
    cd "$ROOT_DIR"
    "$VENV_DIR/bin/mkdocs" build --strict --clean
  )
  printf 'Build ready: %s\n' "$SITE_DIR"
}

server_pid() {
  if [[ -f "$PID_FILE" ]]; then
    cat "$PID_FILE"
  fi
}

server_is_running() {
  local pid
  pid="$(server_pid)"
  [[ -n "$pid" ]] && kill -0 "$pid" 2>/dev/null
}

wait_for_server() {
  local attempt
  for attempt in {1..40}; do
    if curl --fail --silent --show-error --max-time 1 "$BASE_URL/" >/dev/null 2>&1; then
      return 0
    fi
    sleep 0.1
  done

  printf 'Preview server did not become ready. Log: %s\n' "$LOG_FILE" >&2
  if [[ -f "$LOG_FILE" ]]; then
    tail -n 20 "$LOG_FILE" >&2
  fi
  return 1
}

start_server() {
  ensure_environment

  if server_is_running; then
    return 0
  fi

  rm -f "$PID_FILE"
  printf 'Starting preview server at %s...\n' "$BASE_URL"
  nohup "$VENV_DIR/bin/python" -m http.server "$PORT" \
    --bind "$HOST" \
    --directory "$SITE_DIR" \
    >"$LOG_FILE" 2>&1 </dev/null &
  printf '%s\n' "$!" > "$PID_FILE"

  if ! wait_for_server; then
    stop_server >/dev/null 2>&1 || true
    return 1
  fi
}

stop_server() {
  local pid
  pid="$(server_pid)"

  if [[ -n "$pid" ]] && kill -0 "$pid" 2>/dev/null; then
    kill "$pid"
    for _ in {1..20}; do
      if ! kill -0 "$pid" 2>/dev/null; then
        break
      fi
      sleep 0.1
    done
    if kill -0 "$pid" 2>/dev/null; then
      kill -9 "$pid"
    fi
    printf 'Preview server stopped.\n'
  else
    printf 'Preview server is not running.\n'
  fi

  rm -f "$PID_FILE"
}

normalize_page() {
  local page="${1:-}"
  page="${page#/}"
  if [[ -n "$page" && "$page" != */ && "$page" != *.html ]]; then
    page="${page}/"
  fi
  printf '%s' "$page"
}

open_target() {
  local target="$1"

  if [[ "${DOCS_NO_OPEN:-0}" == "1" ]]; then
    printf 'Open manually: %s\n' "$target"
    return 0
  fi

  case "$(uname -s)" in
    Darwin) open "$target" ;;
    Linux)
      if command -v xdg-open >/dev/null 2>&1; then
        xdg-open "$target" >/dev/null 2>&1
      else
        printf 'Open manually: %s\n' "$target"
      fi
      ;;
    *) printf 'Open manually: %s\n' "$target" ;;
  esac
}

find_chrome() {
  local candidates=(
    "/Applications/Google Chrome.app/Contents/MacOS/Google Chrome"
    "/Applications/Chromium.app/Contents/MacOS/Chromium"
  )
  local candidate

  for candidate in "${candidates[@]}"; do
    if [[ -x "$candidate" ]]; then
      printf '%s' "$candidate"
      return 0
    fi
  done

  for candidate in google-chrome chromium chromium-browser; do
    if command -v "$candidate" >/dev/null 2>&1; then
      command -v "$candidate"
      return 0
    fi
  done

  return 1
}

render_page() {
  local page="$1" chrome desktop compact profile
  chrome="$(find_chrome)" || {
    printf 'Chrome or Chromium is required for PNG rendering.\n' >&2
    return 1
  }

  mkdir -p "$RENDER_DIR"
  desktop="$RENDER_DIR/docs-desktop.png"
  compact="$RENDER_DIR/docs-compact.png"
  profile="$(mktemp -d "${TMPDIR:-/tmp}/litellm-docs-chrome.XXXXXX")"

  if ! DOCS_RENDER_CHROME="$chrome" \
    DOCS_RENDER_PROFILE="$profile" \
    DOCS_RENDER_URL="${BASE_URL}/${page}" \
    DOCS_RENDER_DESKTOP="$desktop" \
    DOCS_RENDER_COMPACT="$compact" \
    python3 <<'PY'
import os
import subprocess

chrome = os.environ["DOCS_RENDER_CHROME"]
profile = os.environ["DOCS_RENDER_PROFILE"]
url = os.environ["DOCS_RENDER_URL"]
common = [
    chrome,
    "--headless",
    "--disable-gpu",
    "--disable-dev-shm-usage",
    "--hide-scrollbars",
    "--no-default-browser-check",
    "--no-first-run",
    f"--user-data-dir={profile}",
    "--run-all-compositor-stages-before-draw",
    "--virtual-time-budget=2500",
]

renders = [
    ("1440,1000", os.environ["DOCS_RENDER_DESKTOP"]),
    ("700,1000", os.environ["DOCS_RENDER_COMPACT"]),
]

for size, output in renders:
    subprocess.run(
        [*common, f"--window-size={size}", f"--screenshot={output}", url],
        check=True,
        timeout=30,
        stdout=subprocess.DEVNULL,
        stderr=subprocess.DEVNULL,
    )
PY

  [[ -s "$desktop" && -s "$compact" ]] || {
    printf 'Render files were not created.\n' >&2
    return 1
  }

  printf 'Desktop render: %s\n' "$desktop"
  printf 'Compact render: %s\n' "$compact"
  open_target "$desktop"
  open_target "$compact"
}

command="${1:-open}"
page="$(normalize_page "${2:-}")"

case "$command" in
  open|abrir)
    build_site
    start_server
    target="${BASE_URL}/${page}"
    printf 'Documentation ready: %s\n' "$target"
    printf 'Server PID: %s | Log: %s\n' "$(server_pid)" "$LOG_FILE"
    open_target "$target"
    ;;
  render|renderizar)
    build_site
    start_server
    render_page "$page"
    ;;
  build)
    build_site
    ;;
  status)
    if server_is_running; then
      printf 'Preview server is running at %s (PID %s).\n' "$BASE_URL" "$(server_pid)"
    else
      printf 'Preview server is stopped.\n'
    fi
    ;;
  stop|parar)
    stop_server
    ;;
  clean)
    stop_server
    rm -rf "$RUNTIME_DIR" "$RENDER_DIR"
    printf 'Preview cache and renders removed.\n'
    ;;
  help|-h|--help)
    print_usage
    ;;
  *)
    printf 'Unknown command: %s\n\n' "$command" >&2
    print_usage >&2
    exit 2
    ;;
esac
