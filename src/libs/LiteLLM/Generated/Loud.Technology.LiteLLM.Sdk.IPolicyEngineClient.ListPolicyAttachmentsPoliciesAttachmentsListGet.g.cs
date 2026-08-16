#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// List Policy Attachments<br/>
        /// List all policy attachments from the database and config.yaml.<br/>
        /// Config-defined attachments are returned with definition_location "config" and a<br/>
        /// synthetic attachment_id ("config-&lt;index&gt;").<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/attachments/list" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "attachments": [<br/>
        ///         {<br/>
        ///             "attachment_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///             "policy_name": "global-baseline",<br/>
        ///             "scope": "*",<br/>
        ///             "teams": [],<br/>
        ///             "keys": [],<br/>
        ///             "models": [],<br/>
        ///             "created_at": "2024-01-01T00:00:00Z",<br/>
        ///             "updated_at": "2024-01-01T00:00:00Z"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "total_count": 1<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentListResponse> ListPolicyAttachmentsPoliciesAttachmentsListGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Policy Attachments<br/>
        /// List all policy attachments from the database and config.yaml.<br/>
        /// Config-defined attachments are returned with definition_location "config" and a<br/>
        /// synthetic attachment_id ("config-&lt;index&gt;").<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/policies/attachments/list" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "attachments": [<br/>
        ///         {<br/>
        ///             "attachment_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///             "policy_name": "global-baseline",<br/>
        ///             "scope": "*",<br/>
        ///             "teams": [],<br/>
        ///             "keys": [],<br/>
        ///             "models": [],<br/>
        ///             "created_at": "2024-01-01T00:00:00Z",<br/>
        ///             "updated_at": "2024-01-01T00:00:00Z"<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "total_count": 1<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentListResponse>> ListPolicyAttachmentsPoliciesAttachmentsListGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}