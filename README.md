<div align="center">
  <img src="assets/nuget-icon.png" alt="LiteLLM .NET SDK" width="112" />
  <h1>LiteLLM .NET SDK</h1>
  <p><strong>One gateway. 100+ AI providers. A native, strongly typed .NET experience.</strong></p>
  <p>Build provider-independent AI products on LiteLLM with generated C# models, async APIs, source-generated JSON serialization, and an SDK that tracks the upstream OpenAPI surface.</p>

  [![NuGet](https://img.shields.io/nuget/vpre/LiteLLM?logo=nuget&label=NuGet)](https://www.nuget.org/packages/LiteLLM/)
  [![CI](https://github.com/loud-technology/loud-technology-litellm-sdk/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/loud-technology/loud-technology-litellm-sdk/actions/workflows/dotnet.yml)
  [![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
  [![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
</div>

---

## Why LiteLLM for .NET?

LiteLLM turns OpenAI, Anthropic, Azure OpenAI, Amazon Bedrock, Google Gemini, Vertex AI, Cohere, and many more providers into one OpenAI-compatible AI Gateway. This SDK brings that gateway to .NET without hand-written HTTP plumbing.

- **Broad API coverage** — chat, responses, embeddings, images, audio, batches, files, assistants, reranking, guardrails, budgets, keys, teams, models, health, and gateway administration.
- **Strongly typed by default** — generated request models, response models, enums, unions, endpoint clients, and cancellation support.
- **Built for modern .NET** — nullable reference types, analyzers, source-generated `System.Text.Json`, trimming analysis, NativeAOT awareness, assembly signing, and reproducible builds.
- **Provider freedom** — change the model or routing policy at the gateway while keeping application code stable.
- **Spec-driven updates** — regenerate from LiteLLM's published Swagger definition with one script; scheduled automation detects upstream API changes.
- **Release-ready packages** — MinVer derives package versions from Git tags, Source Link connects packages to source, and symbol packages improve debugging.

> [!NOTE]
> This community SDK is maintained by loud-technology and generated from the LiteLLM OpenAPI specification. It is not an official BerriAI/LiteLLM SDK.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later to build
- A running [LiteLLM AI Gateway](https://docs.litellm.ai/docs/simple_proxy)
- A LiteLLM virtual key or master key

LiteLLM listens on `http://localhost:4000` by default.

## Install

```bash
dotnet add package LiteLLM
```

Or with the NuGet Package Manager:

```powershell
Install-Package LiteLLM
```

## Quick start

Configure the gateway once:

```bash
export LITELLM_API_KEY="sk-your-litellm-key"
export LITELLM_BASE_URL="http://localhost:4000"
```

Then send a provider-independent chat completion:

```csharp
using LiteLLM;

using var client = LiteLLMClient.CreateFromEnvironment();

var responseJson = await client.ChatCompletions.ChatCompletionV1ChatCompletionsPostAsync(
    new ChatCompletionV1ChatCompletionsPostRequest
    {
        Model = "gpt-4o-mini",
        Messages =
        [
            new ChatCompletionUserMessage
            {
                Content = "Explain why a unified AI gateway matters in one sentence.",
            },
        ],
    });

Console.WriteLine(responseJson);
```

The model name is resolved by your LiteLLM configuration, so it may represent a concrete provider model, an alias, or a load-balanced deployment group.

## Configure the client

### Explicit credentials and gateway URL

```csharp
using var client = new LiteLLMClient(
    apiKey: "sk-your-litellm-key",
    baseUri: new Uri("https://ai-gateway.example.com"));
```

### Reuse `HttpClient`

Use an application-managed `HttpClient` for custom handlers, proxies, telemetry, or dependency-injection lifetimes:

```csharp
using var httpClient = new HttpClient
{
    Timeout = TimeSpan.FromSeconds(90),
};

using var client = new LiteLLMClient(
    apiKey: Environment.GetEnvironmentVariable("LITELLM_API_KEY")!,
    httpClient: httpClient,
    baseUri: new Uri("https://ai-gateway.example.com"),
    disposeHttpClient: false);
```

### Environment variables

| Variable | Purpose | Default |
|---|---|---|
| `LITELLM_API_KEY` | Bearer credential used by `CreateFromEnvironment()` | Required by the factory |
| `LITELLM_BASE_URL` | Base URL of your LiteLLM proxy | `http://localhost:4000` |
| `LITELLM_MODEL` | Model used by the optional live integration test | `gpt-4o-mini` |

Never commit keys. Use environment variables, .NET user secrets, or your cloud secret manager.

## API surface

The root client groups operations by domain, making the full LiteLLM gateway discoverable from IntelliSense:

```csharp
client.ChatCompletions; // OpenAI-compatible chat completions
client.Responses;       // Responses API
client.Embeddings;      // Vector embeddings
client.Images;          // Image generation and editing
client.Audio;           // Speech and transcription
client.ModelManagement;// Available models and model metadata
client.Health;          // Gateway health and readiness
client.Guardrails;      // Guardrail configuration and usage
client.KeyManagement;   // Virtual keys and access control
client.TeamManagement;  // Teams, members, and permissions
client.BudgetManagement;// Budgets and spend controls
```

Because LiteLLM's Swagger surface evolves quickly, rely on IDE completion and the generated XML documentation for the exact methods and models in your installed package version.

## Errors, cancellation, and raw responses

Every async operation accepts a `CancellationToken`. Non-success HTTP responses throw `ApiException`, exposing the status and response details generated by AutoSDK. Methods ending in `AsResponseAsync` return an `AutoSDKHttpResponse<T>` when your application needs status codes and headers in addition to the body.

```csharp
using var cancellation = new CancellationTokenSource(TimeSpan.FromSeconds(30));

try
{
    var response = await client.Health.HealthLivelinessHealthLivenessGetAsResponseAsync(
        cancellationToken: cancellation.Token);

    Console.WriteLine($"LiteLLM health status: {(int)response.StatusCode}");
}
catch (ApiException exception)
{
    Console.Error.WriteLine($"LiteLLM request failed: {exception.Message}");
}
```

## Regenerate the SDK

The project follows AutoSDK's [First SDK](https://autosdk.net/docs/getting-started/first-sdk) layout. `generate.sh` is the single source of truth for generation.

```bash
dotnet tool install --global autosdk.cli --version 0.30.2-dev.152
cd src/libs/LiteLLM
./generate.sh
```

The script downloads the Swagger document linked by LiteLLM's official **All Endpoints (Swagger)** documentation, replaces `Generated/`, and creates a .NET 10 client with Bearer authentication and a local proxy base URL.

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

## Build and test

```bash
dotnet restore Loud.Technology.LiteLLM.Sdk.slnx
dotnet build Loud.Technology.LiteLLM.Sdk.slnx --configuration Release --no-restore
dotnet test Loud.Technology.LiteLLM.Sdk.slnx --configuration Release --no-build
```

Network-free contract tests verify the base URL, Bearer header, chat route, and serialized request body. The live example runs only when `LITELLM_API_KEY` is available; otherwise MSTest marks it inconclusive.

## Versioning and releases

Packages use [MinVer](https://github.com/adamralph/minver). A stable version comes directly from a semantic Git tag:

```bash
git tag v1.0.0
git push origin v1.0.0
```

The CI workflow restores, builds, tests, and packs in `Release`. Version tags publish the `.nupkg` and `.snupkg` to NuGet.org using the `NUGET_API_KEY` repository secret. Untagged builds receive a development version and are retained as workflow artifacts, not published.

## Contributing

1. Fork the repository and create a focused branch.
2. If the API changed, edit `generate.sh` rather than generated C# files.
3. Regenerate, then run the Release build and test commands above.
4. Open a pull request describing the upstream spec change and behavior impact.

Generated files are intentionally committed so package builds are deterministic and consumers can inspect the exact API surface.

## Security and support

- Report SDK bugs through [GitHub Issues](https://github.com/loud-technology/loud-technology-litellm-sdk/issues).
- Ask design and usage questions in [GitHub Discussions](https://github.com/loud-technology/loud-technology-litellm-sdk/discussions).
- For LiteLLM gateway behavior, providers, deployment, or configuration, use the [official LiteLLM documentation](https://docs.litellm.ai/).
- Do not disclose credentials or production gateway URLs in public issues.

## License

Licensed under the [MIT License](LICENSE). LiteLLM is a separate project and is subject to its own licensing and trademarks.

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).