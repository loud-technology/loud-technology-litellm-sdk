#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAuditLoggingClient
    {
        /// <summary>
        /// Get Audit Log By Id<br/>
        /// Get detailed information about a specific audit log entry by its ID.<br/>
        /// Args:<br/>
        ///     id (str): The unique identifier of the audit log entry<br/>
        /// Returns:<br/>
        ///     AuditLogResponse: Detailed information about the audit log entry<br/>
        /// Raises:<br/>
        ///     HTTPException: If the audit log is not found or if there's a database connection error
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AuditLogResponse> GetAuditLogByIdAuditIdGetAsync(
            string id,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Audit Log By Id<br/>
        /// Get detailed information about a specific audit log entry by its ID.<br/>
        /// Args:<br/>
        ///     id (str): The unique identifier of the audit log entry<br/>
        /// Returns:<br/>
        ///     AuditLogResponse: Detailed information about the audit log entry<br/>
        /// Raises:<br/>
        ///     HTTPException: If the audit log is not found or if there's a database connection error
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AuditLogResponse>> GetAuditLogByIdAuditIdGetAsResponseAsync(
            string id,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}