#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Create Policy Attachment<br/>
        /// Create a new policy attachment.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "global-baseline",<br/>
        ///         "scope": "*"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example with team-specific attachment:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "healthcare-compliance",<br/>
        ///         "teams": ["healthcare-team", "medical-research"]<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "attachment_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "policy_name": "global-baseline",<br/>
        ///     "scope": "*",<br/>
        ///     "teams": [],<br/>
        ///     "keys": [],<br/>
        ///     "models": [],<br/>
        ///     "created_at": "2024-01-01T00:00:00Z",<br/>
        ///     "updated_at": "2024-01-01T00:00:00Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponse> CreatePolicyAttachmentPoliciesAttachmentsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Policy Attachment<br/>
        /// Create a new policy attachment.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "global-baseline",<br/>
        ///         "scope": "*"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example with team-specific attachment:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "healthcare-compliance",<br/>
        ///         "teams": ["healthcare-team", "medical-research"]<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "attachment_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "policy_name": "global-baseline",<br/>
        ///     "scope": "*",<br/>
        ///     "teams": [],<br/>
        ///     "keys": [],<br/>
        ///     "models": [],<br/>
        ///     "created_at": "2024-01-01T00:00:00Z",<br/>
        ///     "updated_at": "2024-01-01T00:00:00Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponse>> CreatePolicyAttachmentPoliciesAttachmentsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Policy Attachment<br/>
        /// Create a new policy attachment.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "global-baseline",<br/>
        ///         "scope": "*"<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example with team-specific attachment:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "healthcare-compliance",<br/>
        ///         "teams": ["healthcare-team", "medical-research"]<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "attachment_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "policy_name": "global-baseline",<br/>
        ///     "scope": "*",<br/>
        ///     "teams": [],<br/>
        ///     "keys": [],<br/>
        ///     "models": [],<br/>
        ///     "created_at": "2024-01-01T00:00:00Z",<br/>
        ///     "updated_at": "2024-01-01T00:00:00Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="keys">
        /// Key aliases or patterns this attachment applies to.
        /// </param>
        /// <param name="models">
        /// Model names or patterns this attachment applies to.
        /// </param>
        /// <param name="policyName">
        /// Name of the policy to attach.
        /// </param>
        /// <param name="scope">
        /// Use '*' for global scope (applies to all requests).
        /// </param>
        /// <param name="tags">
        /// Tag patterns this attachment applies to. Supports wildcards (e.g., health-*).
        /// </param>
        /// <param name="teams">
        /// Team aliases or patterns this attachment applies to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponse> CreatePolicyAttachmentPoliciesAttachmentsPostAsync(
            string policyName,
            global::System.Collections.Generic.IList<string>? keys = default,
            global::System.Collections.Generic.IList<string>? models = default,
            string? scope = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? teams = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}