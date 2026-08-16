# Getting started

This guide installs the LiteLLM .NET SDK, connects it to a gateway, and sends a first provider-independent chat completion.

## 1. Prepare a LiteLLM gateway

You need a running [LiteLLM AI Gateway](https://docs.litellm.ai/docs/simple_proxy) and a virtual key or master key. A local gateway normally listens on:

```text
http://localhost:4000
```

Your gateway configuration determines which model names and aliases the application may use. The SDK does not store provider credentials; those remain behind LiteLLM.

## 2. Install from GitHub Packages

The SDK is distributed as a NuGet package through the loud-technology GitHub Packages registry. GitHub requires authentication to download NuGet packages.

Create a [personal access token (classic)](https://github.com/settings/tokens) with the `read:packages` scope, then register the source once on your development machine:

=== "macOS and Linux"

    ```bash
    export GITHUB_PACKAGES_USER="your-github-username"
    export GITHUB_PACKAGES_TOKEN="ghp_your-read-packages-token"

    dotnet nuget add source \
      --username "$GITHUB_PACKAGES_USER" \
      --password "$GITHUB_PACKAGES_TOKEN" \
      --store-password-in-clear-text \
      --name loud-technology \
      "https://nuget.pkg.github.com/loud-technology/index.json"
    ```

=== "PowerShell"

    ```powershell
    $env:GITHUB_PACKAGES_USER = "your-github-username"
    $env:GITHUB_PACKAGES_TOKEN = "ghp_your-read-packages-token"

    dotnet nuget add source `
      --username $env:GITHUB_PACKAGES_USER `
      --password $env:GITHUB_PACKAGES_TOKEN `
      --store-password-in-clear-text `
      --name loud-technology `
      "https://nuget.pkg.github.com/loud-technology/index.json"
    ```

Install the package after registering the source:

```bash
dotnet add package LiteLLM --source "https://nuget.pkg.github.com/loud-technology/index.json"
```

Use a token limited to `read:packages`, never commit it, and authorize it for the organization if loud-technology enforces SAML SSO. The current SDK targets .NET 10.

## 3. Configure credentials

Set the gateway key and URL outside source control:

=== "macOS and Linux"

    ```bash
    export LITELLM_API_KEY="sk-your-litellm-key"
    export LITELLM_BASE_URL="http://localhost:4000"
    ```

=== "PowerShell"

    ```powershell
    $env:LITELLM_API_KEY = "sk-your-litellm-key"
    $env:LITELLM_BASE_URL = "http://localhost:4000"
    ```

`LITELLM_API_KEY` is sent as an `Authorization: Bearer` credential. Never commit real keys or production gateway URLs.

## 4. Send a chat completion

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
                Content = "Explain the value of an AI gateway in one sentence.",
            },
        ],
    });

Console.WriteLine(responseJson);
```

The model can be a provider model, a LiteLLM alias, or a load-balanced deployment group. Your gateway owns that mapping, so switching providers does not require changing the client setup.

## 5. Handle cancellation and HTTP metadata

Every generated async operation accepts a `CancellationToken`. Use methods ending in `AsResponseAsync` when you also need the HTTP status and headers:

```csharp
using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));

try
{
    var response = await client.Health.HealthLivelinessHealthLivenessGetAsResponseAsync(
        cancellationToken: timeout.Token);

    Console.WriteLine($"Gateway status: {(int)response.StatusCode}");
}
catch (ApiException exception)
{
    Console.Error.WriteLine($"LiteLLM request failed: {exception.Message}");
}
```

Non-success responses throw `ApiException`. Keep logs sanitized: response details may contain model input, output, or gateway metadata.

## Next steps

- Configure custom URLs and application-managed HTTP transport in [Client configuration](guides/configuration.md).
- Use `client.ChatCompletions`, `client.Responses`, `client.Embeddings`, and other endpoint groups to explore the API.
- Consult the [official LiteLLM documentation](https://docs.litellm.ai/) for gateway deployment, routing, providers, and policies.
