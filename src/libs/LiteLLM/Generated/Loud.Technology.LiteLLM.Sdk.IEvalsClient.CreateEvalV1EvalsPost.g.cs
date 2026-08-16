#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Create Eval<br/>
        /// Create a new evaluation.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// - Pass model via body: `{"model": "gpt-4-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/evals"       -H "Authorization: Bearer your-key"       -H "Content-Type: application/json"       -d '{<br/>
        ///     "name": "Test Eval",<br/>
        ///     "data_source_config": {"type": "file", "file_id": "file-abc123"},<br/>
        ///     "testing_criteria": {"graders": [{"type": "llm_as_judge"}]}<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Returns: Eval object with id, status, timestamps, etc.
        /// </summary>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.Eval> CreateEvalV1EvalsPostAsync(
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Eval<br/>
        /// Create a new evaluation.<br/>
        /// Model-based routing (for multi-account support):<br/>
        /// - Pass model via header: `x-litellm-model: gpt-4-account-1`<br/>
        /// - Pass model via query: `?model=gpt-4-account-1`<br/>
        /// - Pass model via body: `{"model": "gpt-4-account-1"}`<br/>
        /// Example usage:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/evals"       -H "Authorization: Bearer your-key"       -H "Content-Type: application/json"       -d '{<br/>
        ///     "name": "Test Eval",<br/>
        ///     "data_source_config": {"type": "file", "file_id": "file-abc123"},<br/>
        ///     "testing_criteria": {"graders": [{"type": "llm_as_judge"}]}<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Returns: Eval object with id, status, timestamps, etc.
        /// </summary>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.Eval>> CreateEvalV1EvalsPostAsResponseAsync(
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}