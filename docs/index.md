# LiteLLM .NET SDK

**A strongly typed .NET client for the LiteLLM AI Gateway, maintained by [loud-technology](https://github.com/loud-technology).**

The LiteLLM .NET SDK lets applications call the broad LiteLLM gateway API without maintaining custom HTTP request code. It is generated from LiteLLM's published OpenAPI specification with AutoSDK, then built, tested, packaged, and documented as a native .NET library.

<div class="grid cards" markdown>

-   :material-connection:{ .lg .middle } **One gateway, many providers**

    ---

    Keep application code stable while LiteLLM routes requests to OpenAI, Anthropic, Gemini, Bedrock, Azure OpenAI, Vertex AI, and many other providers.

-   :material-code-braces:{ .lg .middle } **Strongly typed API**

    ---

    Discover endpoint groups, request models, unions, enums, cancellation tokens, and response helpers directly through IntelliSense.

-   :material-update:{ .lg .middle } **Generated from the source**

    ---

    The committed client is reproducibly regenerated from LiteLLM's Swagger definition, reducing drift as the gateway evolves.

-   :material-package-variant:{ .lg .middle } **Published to two registries**

    ---

    One release artifact is delivered to NuGet.org with Trusted Publishing and to GitHub Packages with the workflow token.

</div>

## Start here

1. Follow [Getting started](getting-started.md) to install the package and send your first chat completion.
2. Read [Client configuration](guides/configuration.md) for environment variables, explicit credentials, and `HttpClient` ownership.
3. Explore the generated endpoint groups with IDE completion for the exact API available in your package version.

## What the SDK covers

The generated client exposes LiteLLM's OpenAI-compatible inference APIs and its gateway-management surface, including:

- chat completions, responses, embeddings, images, audio, reranking, and batches;
- models, files, assistants, vector stores, and provider pass-through routes;
- virtual keys, users, teams, organizations, budgets, and spend tracking;
- guardrails, health checks, caching, routing, and gateway settings.

!!! note "Community SDK"
    This project is maintained by loud-technology and generated from the LiteLLM OpenAPI specification. It is not an official BerriAI/LiteLLM SDK.

## Requirements

- .NET 10 or later
- A reachable LiteLLM AI Gateway
- A LiteLLM virtual key or master key

The default gateway URL is `http://localhost:4000`.

## Project links

- [Source repository](https://github.com/loud-technology/loud-technology-litellm-sdk)
- [NuGet.org package](https://www.nuget.org/packages/LiteLLM/)
- [GitHub Packages](https://github.com/orgs/loud-technology/packages?repo_name=loud-technology-litellm-sdk)
- [Issue tracker](https://github.com/loud-technology/loud-technology-litellm-sdk/issues)
- [Official LiteLLM documentation](https://docs.litellm.ai/)
