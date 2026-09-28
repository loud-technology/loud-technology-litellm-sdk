#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// List Runs<br/>
        /// List all runs for an evaluation with pagination.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl "http://localhost:4000/v1/evals/eval_123/runs?limit=10"       -H "Authorization: Bearer your-key"<br/>
        /// ```<br/>
        /// Returns: ListRunsResponse with list of runs
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="order"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListRunsResponse> ListRunsV1EvalsEvalIdRunsGetAsync(
            string evalId,
            int? limit = default,
            string? after = default,
            string? before = default,
            string? order = default,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Runs<br/>
        /// List all runs for an evaluation with pagination.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl "http://localhost:4000/v1/evals/eval_123/runs?limit=10"       -H "Authorization: Bearer your-key"<br/>
        /// ```<br/>
        /// Returns: ListRunsResponse with list of runs
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="order"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListRunsResponse>> ListRunsV1EvalsEvalIdRunsGetAsResponseAsync(
            string evalId,
            int? limit = default,
            string? after = default,
            string? before = default,
            string? order = default,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}