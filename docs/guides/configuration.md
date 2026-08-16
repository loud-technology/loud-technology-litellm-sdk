# Client configuration

## Environment-based setup

The recommended setup keeps credentials outside source control:

```bash
export LITELLM_API_KEY="sk-your-litellm-key"
export LITELLM_BASE_URL="https://ai-gateway.example.com"
```

```csharp
using LiteLLM;

using var client = LiteLLMClient.CreateFromEnvironment();
```

`CreateFromEnvironment()` throws `InvalidOperationException` when `LITELLM_API_KEY` is missing or empty. The generated default gateway URL is `http://localhost:4000`.

## Explicit setup

```csharp
using var client = new LiteLLMClient(
    apiKey: "sk-your-litellm-key",
    baseUri: new Uri("https://ai-gateway.example.com"));
```

The SDK sends the key as an `Authorization: Bearer` header. Never embed production credentials in source code.

## Application-managed HTTP transport

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

Set `disposeHttpClient: false` when the `HttpClient` lifetime is owned by your application or dependency-injection container.
