#!/usr/bin/env bash
set -euo pipefail

readonly AUTOSDK_VERSION="0.30.2-dev.152"
readonly OPENAPI_URL="https://litellm-api.up.railway.app/openapi.json"
readonly DEFAULT_BASE_URL="http://localhost:4000"

if ! command -v autosdk >/dev/null 2>&1; then
  dotnet tool install --global autosdk.cli --version "${AUTOSDK_VERSION}"
fi

rm -rf Generated

autosdk generate openapi.yaml \
  --namespace Loud.Technology.LiteLLM.Sdk \
  --clientClassName LiteLLMClient \
  --targetFramework net10.0 \
  --output Generated \
  --base-url "${DEFAULT_BASE_URL}" \
  --base-url-env LITELLM_BASE_URL \
  --security-scheme Http:Header:Bearer \
  --api-key-env LITELLM_API_KEY \
  --exclude-deprecated-operations
