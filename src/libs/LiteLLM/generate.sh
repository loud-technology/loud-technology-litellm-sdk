#!/usr/bin/env bash
set -euo pipefail

readonly AUTOSDK_VERSION="0.34.6"
readonly OPENAPI_URL="https://litellm-api.up.railway.app/openapi.json"
readonly DEFAULT_BASE_URL="http://localhost:4000"

installed_version="$(autosdk --version 2>/dev/null || true)"

if [[ "${installed_version%%+*}" != "${AUTOSDK_VERSION}" ]]; then
  dotnet tool update --global autosdk.cli --version "${AUTOSDK_VERSION}" --allow-downgrade
fi

python3 apply-openapi-overrides.py openapi.yaml

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
