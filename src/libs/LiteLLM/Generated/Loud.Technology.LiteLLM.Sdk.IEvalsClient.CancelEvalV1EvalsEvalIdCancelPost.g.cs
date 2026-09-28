#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Cancel Eval<br/>
        /// Cancel a running evaluation.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// - Pass model via body: `{"model": "gpt-4-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/evals/eval_123/cancel"       -H "Authorization: Bearer your-key"<br/>
        /// ```<br/>
        /// Returns: CancelEvalResponse with cancellation confirmation
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CancelEvalResponse> CancelEvalV1EvalsEvalIdCancelPostAsync(
            string evalId,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Eval<br/>
        /// Cancel a running evaluation.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// - Pass model via body: `{"model": "gpt-4-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/evals/eval_123/cancel"       -H "Authorization: Bearer your-key"<br/>
        /// ```<br/>
        /// Returns: CancelEvalResponse with cancellation confirmation
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CancelEvalResponse>> CancelEvalV1EvalsEvalIdCancelPostAsResponseAsync(
            string evalId,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}