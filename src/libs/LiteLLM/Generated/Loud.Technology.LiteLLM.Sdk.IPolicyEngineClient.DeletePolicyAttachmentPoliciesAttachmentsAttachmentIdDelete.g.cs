#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Delete Policy Attachment<br/>
        /// Delete a policy attachment.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/policies/attachments/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "message": "Attachment 123e4567-e89b-12d3-a456-426614174000 deleted successfully"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="attachmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePolicyAttachmentPoliciesAttachmentsAttachmentIdDeleteAsync(
            string attachmentId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Policy Attachment<br/>
        /// Delete a policy attachment.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X DELETE "http://localhost:4000/policies/attachments/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "message": "Attachment 123e4567-e89b-12d3-a456-426614174000 deleted successfully"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="attachmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeletePolicyAttachmentPoliciesAttachmentsAttachmentIdDeleteAsResponseAsync(
            string attachmentId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}