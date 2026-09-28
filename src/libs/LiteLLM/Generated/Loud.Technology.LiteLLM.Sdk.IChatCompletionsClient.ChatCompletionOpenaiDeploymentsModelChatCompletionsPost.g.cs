#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IChatCompletionsClient
    {
        /// <summary>
        /// Chat Completion<br/>
        /// Follows the exact same API spec as `OpenAI's Chat API https://platform.openai.com/docs/api-reference/chat`<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/chat/completions <br/>
        /// -H "Content-Type: application/json" <br/>
        /// -H "Authorization: Bearer sk-1234" <br/>
        /// -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "messages": [<br/>
        ///         {<br/>
        ///             "role": "user",<br/>
        ///             "content": "Hello!"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ChatCompletionOpenaiDeploymentsModelChatCompletionsPostAsync(
            string? model,

            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionOpenaiDeploymentsModelChatCompletionsPostRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completion<br/>
        /// Follows the exact same API spec as `OpenAI's Chat API https://platform.openai.com/docs/api-reference/chat`<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/chat/completions <br/>
        /// -H "Content-Type: application/json" <br/>
        /// -H "Authorization: Bearer sk-1234" <br/>
        /// -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "messages": [<br/>
        ///         {<br/>
        ///             "role": "user",<br/>
        ///             "content": "Hello!"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ChatCompletionOpenaiDeploymentsModelChatCompletionsPostAsResponseAsync(
            string? model,

            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionOpenaiDeploymentsModelChatCompletionsPostRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chat Completion<br/>
        /// Follows the exact same API spec as `OpenAI's Chat API https://platform.openai.com/docs/api-reference/chat`<br/>
        /// ```bash<br/>
        /// curl -X POST http://localhost:4000/v1/chat/completions <br/>
        /// -H "Content-Type: application/json" <br/>
        /// -H "Authorization: Bearer sk-1234" <br/>
        /// -d '{<br/>
        ///     "model": "gpt-4o",<br/>
        ///     "messages": [<br/>
        ///         {<br/>
        ///             "role": "user",<br/>
        ///             "content": "Hello!"<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="requestModel"></param>
        /// <param name="messages">
        /// Example: [{"role":"user","content":"Hello, how are you?"}]
        /// </param>
        /// <param name="frequencyPenalty">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="logitBias">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="logprobs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="topLogprobs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="n">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="presencePenalty">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="responseFormat">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="seed">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceTier">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="stop">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="streamOptions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="temperature">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="topP">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tools">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="toolChoice">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="parallelToolCalls">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="functionCall">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="functions">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="user">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="stream">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="guardrails">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="caching">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="numRetries">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="contextWindowFallbackDict">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fallbacks">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ChatCompletionOpenaiDeploymentsModelChatCompletionsPostAsync(
            string? model,
            string requestModel,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.ChatCompletionUserMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionAssistantMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionToolMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionSystemMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFunctionMessage, global::Loud.Technology.LiteLLM.Sdk.ChatCompletionDeveloperMessage>> messages,
            double? frequencyPenalty = default,
            global::System.Collections.Generic.Dictionary<string, double>? logitBias = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            int? maxTokens = default,
            int? n = default,
            double? presencePenalty = default,
            object? responseFormat = default,
            int? seed = default,
            string? serviceTier = default,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<string>, object>? stop = default,
            object? streamOptions = default,
            double? temperature = default,
            double? topP = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, object>? toolChoice = default,
            bool? parallelToolCalls = default,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, object>? functionCall = default,
            global::System.Collections.Generic.IList<object>? functions = default,
            string? user = default,
            bool? stream = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? guardrails = default,
            bool? caching = default,
            int? numRetries = default,
            global::System.Collections.Generic.Dictionary<string, string>? contextWindowFallbackDict = default,
            global::System.Collections.Generic.IList<string>? fallbacks = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}