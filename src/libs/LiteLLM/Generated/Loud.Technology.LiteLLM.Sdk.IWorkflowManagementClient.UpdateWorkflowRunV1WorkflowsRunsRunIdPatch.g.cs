#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IWorkflowManagementClient
    {
        /// <summary>
        /// Update Workflow Run<br/>
        /// Update status, metadata, or output on a workflow run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateWorkflowRunV1WorkflowsRunsRunIdPatchAsync(
            string runId,

            global::Loud.Technology.LiteLLM.Sdk.WorkflowRunUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workflow Run<br/>
        /// Update status, metadata, or output on a workflow run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateWorkflowRunV1WorkflowsRunsRunIdPatchAsResponseAsync(
            string runId,

            global::Loud.Technology.LiteLLM.Sdk.WorkflowRunUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Workflow Run<br/>
        /// Update status, metadata, or output on a workflow run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="status"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateWorkflowRunV1WorkflowsRunsRunIdPatchAsync(
            string runId,
            global::Loud.Technology.LiteLLM.Sdk.WorkflowRunUpdateRequestStatus2? status = default,
            object? output = default,
            object? metadata = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}