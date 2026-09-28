#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IWorkflowManagementClient
    {
        /// <summary>
        /// List Workflow Runs<br/>
        /// List workflow runs. Filter by workflow_type and/or status.<br/>
        /// Non-admin callers only see runs created by their own API key.
        /// </summary>
        /// <param name="workflowType"></param>
        /// <param name="status"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListWorkflowRunsV1WorkflowsRunsGetAsync(
            string? workflowType = default,
            string? status = default,
            int? limit = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Workflow Runs<br/>
        /// List workflow runs. Filter by workflow_type and/or status.<br/>
        /// Non-admin callers only see runs created by their own API key.
        /// </summary>
        /// <param name="workflowType"></param>
        /// <param name="status"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ListWorkflowRunsV1WorkflowsRunsGetAsResponseAsync(
            string? workflowType = default,
            string? status = default,
            int? limit = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}