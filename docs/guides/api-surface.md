---
title: API surface
description: Navigate the generated LiteLLM endpoint groups, request models, and response helpers.
---

# API surface

The SDK maps LiteLLM's OpenAPI document into a root `LiteLLMClient`, domain clients, request and response models, enums, and unions. Start from the root client and use IDE completion to discover the exact surface in your installed package version.

## Root client map

<div class="api-group-grid" markdown>

<section markdown>

### Inference

```csharp
client.ChatCompletions;
client.Responses;
client.Embeddings;
client.Images;
client.Audio;
```

Use these clients for OpenAI-compatible inference operations, multimodal requests, and provider-independent model calls.

</section>

<section markdown>

### Model operations

```csharp
client.ModelManagement;
client.Health;
client.Files;
client.Batch;
client.VectorStores;
```

Use these groups to inspect models, check gateway health, manage files, submit batches, and work with vector stores.

</section>

<section markdown>

### Access and governance

```csharp
client.KeyManagement;
client.TeamManagement;
client.BudgetManagement;
client.Guardrails;
```

Use these groups for virtual keys, team access, spend controls, and gateway policy enforcement.

</section>

</div>

## Method naming

Generated method names preserve enough operation metadata to remain unique as the upstream specification changes. A typical call has two variants:

```csharp
var body = await client.Health
    .HealthLivelinessHealthLivenessGetAsync();

var response = await client.Health
    .HealthLivelinessHealthLivenessGetAsResponseAsync();
```

The first variant returns the deserialized body. The `AsResponseAsync` variant returns an `AutoSDKHttpResponse<T>` with the body, HTTP status, and headers.

## Request models

Operations with request bodies accept generated model types. Object initializers and collection expressions keep those calls readable:

```csharp
var request = new ChatCompletionV1ChatCompletionsPostRequest
{
    Model = "gpt-4o-mini",
    Messages =
    [
        new ChatCompletionUserMessage
        {
            Content = "Summarize the incident report.",
        },
    ],
};

var result = await client.ChatCompletions
    .ChatCompletionV1ChatCompletionsPostAsync(request);
```

## Working with a changing specification

LiteLLM's gateway surface evolves quickly. The generated code committed to this repository is the source of truth for each package build.

1. Pin the package version used by your application.
2. Use IntelliSense and generated XML documentation for exact signatures.
3. Review package updates before adopting new generated models or operations.
4. Regenerate only through the repository script when contributing upstream changes.

See [Regenerate the SDK](regeneration.md) for the deterministic update workflow.
