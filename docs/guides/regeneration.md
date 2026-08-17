---
title: Regenerate the SDK
description: Update the generated LiteLLM .NET client from the upstream OpenAPI specification and validate the result.
---

# Regenerate the SDK

The repository follows AutoSDK's First SDK layout. `src/libs/LiteLLM/generate.sh` is the single source of truth for generated client updates.

## Prerequisites

- .NET 10 SDK or later
- AutoSDK CLI version `0.30.2-dev.152`
- Network access to retrieve LiteLLM's published Swagger document

Install the pinned generator version:

```bash
dotnet tool install --global autosdk.cli --version 0.30.2-dev.152
```

## Run generation

```bash
cd src/libs/LiteLLM
./generate.sh
```

The script downloads the Swagger document linked by LiteLLM's official All Endpoints documentation, replaces `Generated/`, and creates a .NET 10 client with Bearer authentication and the local proxy base URL.

!!! danger "Do not hand-edit generated files"
    Changes under `Generated/` are replaced during the next run. Update `generate.sh`, the OpenAPI override script, or the source specification instead.

## Inspect the change

Generated changes can be large. Review them by behavior rather than file count:

1. Check added and removed root client groups.
2. Review changed request requirements and response unions.
3. Inspect authentication and base URL changes.
4. Confirm generated serialization contexts include new models.
5. Verify that no credentials or environment-specific URLs entered the output.

## Build and test

Run the same Release sequence used by CI:

```bash
dotnet restore Loud.Technology.LiteLLM.Sdk.slnx
dotnet build Loud.Technology.LiteLLM.Sdk.slnx \
  --configuration Release \
  --no-restore
dotnet test Loud.Technology.LiteLLM.Sdk.slnx \
  --configuration Release \
  --no-build
```

Network-free contract tests verify the base URL, Bearer header, chat route, and serialized request body. The live integration example runs only when `LITELLM_API_KEY` is available.

## Repository layout

```text
Loud.Technology.LiteLLM.Sdk.slnx
├── src/
│   ├── libs/LiteLLM/
│   │   ├── Loud.Technology.LiteLLM.Sdk.csproj
│   │   ├── openapi.yaml
│   │   ├── generate.sh
│   │   └── Generated/
│   └── tests/IntegrationTests/
├── docs/
└── .github/workflows/
```

Commit generated files with the script or override changes that produced them. This keeps package builds deterministic and makes the exact API surface reviewable.
