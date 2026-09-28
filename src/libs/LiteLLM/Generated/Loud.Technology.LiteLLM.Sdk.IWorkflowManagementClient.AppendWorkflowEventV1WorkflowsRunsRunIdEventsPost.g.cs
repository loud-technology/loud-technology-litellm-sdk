#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IWorkflowManagementClient
    {
        /// <summary>
        /// Append Workflow Event<br/>
        /// Append an event to the run's event log. Also updates run.status if event_type maps to a status.<br/>
        /// Sequence numbers use optimistic concurrency: on a unique-constraint collision<br/>
        /// (concurrent append), retries up to _MAX_SEQUENCE_RETRIES times with a fresh MAX+1.<br/>
        /// The event+status update is atomic in a single DB transaction.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AppendWorkflowEventV1WorkflowsRunsRunIdEventsPostAsync(
            string runId,

            global::Loud.Technology.LiteLLM.Sdk.WorkflowEventCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Append Workflow Event<br/>
        /// Append an event to the run's event log. Also updates run.status if event_type maps to a status.<br/>
        /// Sequence numbers use optimistic concurrency: on a unique-constraint collision<br/>
        /// (concurrent append), retries up to _MAX_SEQUENCE_RETRIES times with a fresh MAX+1.<br/>
        /// The event+status update is atomic in a single DB transaction.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AppendWorkflowEventV1WorkflowsRunsRunIdEventsPostAsResponseAsync(
            string runId,

            global::Loud.Technology.LiteLLM.Sdk.WorkflowEventCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Append Workflow Event<br/>
        /// Append an event to the run's event log. Also updates run.status if event_type maps to a status.<br/>
        /// Sequence numbers use optimistic concurrency: on a unique-constraint collision<br/>
        /// (concurrent append), retries up to _MAX_SEQUENCE_RETRIES times with a fresh MAX+1.<br/>
        /// The event+status update is atomic in a single DB transaction.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="eventType"></param>
        /// <param name="stepName"></param>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AppendWorkflowEventV1WorkflowsRunsRunIdEventsPostAsync(
            string runId,
            string eventType,
            string stepName,
            object? data = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}