#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Test Pipeline<br/>
        /// Test a guardrail pipeline with sample messages.<br/>
        /// Executes the pipeline steps against the provided test messages and returns<br/>
        /// step-by-step results showing which guardrails passed/failed, actions taken,<br/>
        /// and timing information.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/test-pipeline" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "pipeline": {<br/>
        ///             "mode": "pre_call",<br/>
        ///             "steps": [<br/>
        ///                 {"guardrail": "pii-guard", "on_pass": "next", "on_fail": "block"}<br/>
        ///             ]<br/>
        ///         },<br/>
        ///         "test_messages": [{"role": "user", "content": "My SSN is 123-45-6789"}]<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestPipelinePoliciesTestPipelinePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.PipelineTestRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Pipeline<br/>
        /// Test a guardrail pipeline with sample messages.<br/>
        /// Executes the pipeline steps against the provided test messages and returns<br/>
        /// step-by-step results showing which guardrails passed/failed, actions taken,<br/>
        /// and timing information.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/test-pipeline" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "pipeline": {<br/>
        ///             "mode": "pre_call",<br/>
        ///             "steps": [<br/>
        ///                 {"guardrail": "pii-guard", "on_pass": "next", "on_fail": "block"}<br/>
        ///             ]<br/>
        ///         },<br/>
        ///         "test_messages": [{"role": "user", "content": "My SSN is 123-45-6789"}]<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestPipelinePoliciesTestPipelinePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.PipelineTestRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Pipeline<br/>
        /// Test a guardrail pipeline with sample messages.<br/>
        /// Executes the pipeline steps against the provided test messages and returns<br/>
        /// step-by-step results showing which guardrails passed/failed, actions taken,<br/>
        /// and timing information.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/test-pipeline" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "pipeline": {<br/>
        ///             "mode": "pre_call",<br/>
        ///             "steps": [<br/>
        ///                 {"guardrail": "pii-guard", "on_pass": "next", "on_fail": "block"}<br/>
        ///             ]<br/>
        ///         },<br/>
        ///         "test_messages": [{"role": "user", "content": "My SSN is 123-45-6789"}]<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="pipeline">
        /// Pipeline definition with 'mode' and 'steps'.
        /// </param>
        /// <param name="testMessages">
        /// Test messages to run through the pipeline, e.g. [{'role': 'user', 'content': '...'}].
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TestPipelinePoliciesTestPipelinePostAsync(
            object pipeline,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> testMessages,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}