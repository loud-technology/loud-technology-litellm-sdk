#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Get Policy Attachment<br/>
        /// Get a policy attachment by ID.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/attachments/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```
        /// </summary>
        /// <param name="attachmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponse> GetPolicyAttachmentPoliciesAttachmentsAttachmentIdGetAsync(
            string attachmentId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Policy Attachment<br/>
        /// Get a policy attachment by ID.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/attachments/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```
        /// </summary>
        /// <param name="attachmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponse>> GetPolicyAttachmentPoliciesAttachmentsAttachmentIdGetAsResponseAsync(
            string attachmentId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}