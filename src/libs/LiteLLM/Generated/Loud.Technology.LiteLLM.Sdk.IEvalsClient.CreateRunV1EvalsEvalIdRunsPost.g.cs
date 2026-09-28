#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Create Run<br/>
        /// Create a new run for an evaluation.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// - Pass model via body: `{"model": "gpt-4-account-1"}`<br/>
        /// - Pass model via completion.model: `{"completion": {"model": "gpt-4-account-1"}}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/evals/eval_123/runs"       -H "Authorization: Bearer your-key"       -H "Content-Type: application/json"       -d '{<br/>
        ///     "data_source": {"type": "dataset", "dataset_id": "dataset_123"},<br/>
        ///     "completion": {"model": "gpt-4", "temperature": 0.7}<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Returns: Run object with id, status, timestamps, etc.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.Run> CreateRunV1EvalsEvalIdRunsPostAsync(
            string evalId,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Run<br/>
        /// Create a new run for an evaluation.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// - Pass model via body: `{"model": "gpt-4-account-1"}`<br/>
        /// - Pass model via completion.model: `{"completion": {"model": "gpt-4-account-1"}}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/evals/eval_123/runs"       -H "Authorization: Bearer your-key"       -H "Content-Type: application/json"       -d '{<br/>
        ///     "data_source": {"type": "dataset", "dataset_id": "dataset_123"},<br/>
        ///     "completion": {"model": "gpt-4", "temperature": 0.7}<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Returns: Run object with id, status, timestamps, etc.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.Run>> CreateRunV1EvalsEvalIdRunsPostAsResponseAsync(
            string evalId,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}