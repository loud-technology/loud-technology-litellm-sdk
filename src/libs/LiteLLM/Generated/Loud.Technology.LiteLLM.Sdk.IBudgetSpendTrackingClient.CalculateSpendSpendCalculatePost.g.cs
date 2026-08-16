#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Calculate Spend<br/>
        /// Accepts all the params of completion_cost.<br/>
        /// Calculate spend **before** making call:<br/>
        /// Note: If you see a spend of $0.0 you need to set custom_pricing for your model: https://docs.litellm.ai/docs/proxy/custom_pricing<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/spend/calculate'<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// --header 'Content-Type: application/json'<br/>
        /// --data '{<br/>
        ///     "model": "anthropic.claude-v2",<br/>
        ///     "messages": [{"role": "user", "content": "Hey, how'''s it going?"}]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Calculate spend **after** making call:<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/spend/calculate'<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// --header 'Content-Type: application/json'<br/>
        /// --data '{<br/>
        ///     "completion_response": {<br/>
        ///         "id": "chatcmpl-123",<br/>
        ///         "object": "chat.completion",<br/>
        ///         "created": 1677652288,<br/>
        ///         "model": "gpt-3.5-turbo-0125",<br/>
        ///         "system_fingerprint": "fp_44709d6fcb",<br/>
        ///         "choices": [{<br/>
        ///             "index": 0,<br/>
        ///             "message": {<br/>
        ///                 "role": "assistant",<br/>
        ///                 "content": "Hello there, how may I assist you today?"<br/>
        ///             },<br/>
        ///             "logprobs": null,<br/>
        ///             "finish_reason": "stop"<br/>
        ///         }]<br/>
        ///         "usage": {<br/>
        ///             "prompt_tokens": 9,<br/>
        ///             "completion_tokens": 12,<br/>
        ///             "total_tokens": 21<br/>
        ///         }<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CalculateSpendSpendCalculatePostResponse> CalculateSpendSpendCalculatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.SpendCalculateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calculate Spend<br/>
        /// Accepts all the params of completion_cost.<br/>
        /// Calculate spend **before** making call:<br/>
        /// Note: If you see a spend of $0.0 you need to set custom_pricing for your model: https://docs.litellm.ai/docs/proxy/custom_pricing<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/spend/calculate'<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// --header 'Content-Type: application/json'<br/>
        /// --data '{<br/>
        ///     "model": "anthropic.claude-v2",<br/>
        ///     "messages": [{"role": "user", "content": "Hey, how'''s it going?"}]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Calculate spend **after** making call:<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/spend/calculate'<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// --header 'Content-Type: application/json'<br/>
        /// --data '{<br/>
        ///     "completion_response": {<br/>
        ///         "id": "chatcmpl-123",<br/>
        ///         "object": "chat.completion",<br/>
        ///         "created": 1677652288,<br/>
        ///         "model": "gpt-3.5-turbo-0125",<br/>
        ///         "system_fingerprint": "fp_44709d6fcb",<br/>
        ///         "choices": [{<br/>
        ///             "index": 0,<br/>
        ///             "message": {<br/>
        ///                 "role": "assistant",<br/>
        ///                 "content": "Hello there, how may I assist you today?"<br/>
        ///             },<br/>
        ///             "logprobs": null,<br/>
        ///             "finish_reason": "stop"<br/>
        ///         }]<br/>
        ///         "usage": {<br/>
        ///             "prompt_tokens": 9,<br/>
        ///             "completion_tokens": 12,<br/>
        ///             "total_tokens": 21<br/>
        ///         }<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CalculateSpendSpendCalculatePostResponse>> CalculateSpendSpendCalculatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.SpendCalculateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Calculate Spend<br/>
        /// Accepts all the params of completion_cost.<br/>
        /// Calculate spend **before** making call:<br/>
        /// Note: If you see a spend of $0.0 you need to set custom_pricing for your model: https://docs.litellm.ai/docs/proxy/custom_pricing<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/spend/calculate'<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// --header 'Content-Type: application/json'<br/>
        /// --data '{<br/>
        ///     "model": "anthropic.claude-v2",<br/>
        ///     "messages": [{"role": "user", "content": "Hey, how'''s it going?"}]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Calculate spend **after** making call:<br/>
        /// ```<br/>
        /// curl --location 'http://localhost:4000/spend/calculate'<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// --header 'Content-Type: application/json'<br/>
        /// --data '{<br/>
        ///     "completion_response": {<br/>
        ///         "id": "chatcmpl-123",<br/>
        ///         "object": "chat.completion",<br/>
        ///         "created": 1677652288,<br/>
        ///         "model": "gpt-3.5-turbo-0125",<br/>
        ///         "system_fingerprint": "fp_44709d6fcb",<br/>
        ///         "choices": [{<br/>
        ///             "index": 0,<br/>
        ///             "message": {<br/>
        ///                 "role": "assistant",<br/>
        ///                 "content": "Hello there, how may I assist you today?"<br/>
        ///             },<br/>
        ///             "logprobs": null,<br/>
        ///             "finish_reason": "stop"<br/>
        ///         }]<br/>
        ///         "usage": {<br/>
        ///             "prompt_tokens": 9,<br/>
        ///             "completion_tokens": 12,<br/>
        ///             "total_tokens": 21<br/>
        ///         }<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="messages"></param>
        /// <param name="completionResponse"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CalculateSpendSpendCalculatePostResponse> CalculateSpendSpendCalculatePostAsync(
            string? model = default,
            global::System.Collections.Generic.IList<object>? messages = default,
            object? completionResponse = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}