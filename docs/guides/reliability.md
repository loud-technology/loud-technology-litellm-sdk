---
title: Reliability and responses
description: Handle cancellation, API failures, HTTP metadata, and HttpClient ownership in the LiteLLM .NET SDK.
---

# Reliability and responses

Production calls need bounded execution, observable failures, and deliberate HTTP lifetimes. The generated SDK exposes those controls without requiring custom request plumbing.

## Bound every request

Every async operation accepts a `CancellationToken`. Link request cancellation to an explicit timeout appropriate for the model and workload.

```csharp
using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));

var response = await client.Health
    .HealthLivelinessHealthLivenessGetAsResponseAsync(
        cancellationToken: timeout.Token);
```

Cancellation can represent a caller disconnect, application shutdown, or deadline. Treat those cases separately from gateway errors in application telemetry.

## Handle API failures

Non-success HTTP responses throw `ApiException`. Catch it at the boundary where your application can add operation context, sanitize details, and choose a retry or fallback policy.

```csharp
try
{
    var result = await client.ChatCompletions
        .ChatCompletionV1ChatCompletionsPostAsync(
            request,
            cancellationToken: cancellationToken);
}
catch (ApiException exception)
{
    logger.LogError(
        exception,
        "LiteLLM chat request failed for model {Model}",
        request.Model);

    throw;
}
```

!!! warning "Keep logs safe"
    Gateway error bodies can include prompts, model output, provider metadata, or internal routing details. Do not log raw responses by default.

## Inspect status and headers

Use methods ending in `AsResponseAsync` when status codes or response headers affect application behavior.

```csharp
var response = await client.Health
    .HealthLivelinessHealthLivenessGetAsResponseAsync(
        cancellationToken: cancellationToken);

Console.WriteLine((int)response.StatusCode);
```

Use the body-first method when your application only needs the generated result. This keeps ordinary call sites concise.

## Reuse HttpClient

Application-managed `HttpClient` instances are useful for dependency injection, telemetry handlers, proxy configuration, and centralized timeouts.

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

Set `disposeHttpClient: false` when the application or dependency-injection container owns the transport lifetime.

## Retry deliberately

Before retrying, classify the failure:

- Retry transient transport failures and gateway responses only when the operation is safe to repeat.
- Respect provider or gateway rate-limit headers when they are available.
- Add jitter and a strict attempt limit to avoid synchronized retries.
- Do not retry invalid credentials, invalid request models, or deterministic policy rejections.
- Keep the end-to-end deadline bounded across all attempts.

Retry policy belongs to the calling application because acceptable latency and duplication risk vary by operation.
