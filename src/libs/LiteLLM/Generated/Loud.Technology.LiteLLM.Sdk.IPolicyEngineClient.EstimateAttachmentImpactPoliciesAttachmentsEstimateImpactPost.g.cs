#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPolicyEngineClient
    {
        /// <summary>
        /// Estimate Attachment Impact<br/>
        /// Estimate how many keys and teams would be affected by a policy attachment.<br/>
        /// Use this before creating an attachment to preview the blast radius.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments/estimate-impact" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "hipaa-compliance",<br/>
        ///         "tags": ["healthcare", "health-*"]<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AttachmentImpactResponse> EstimateAttachmentImpactPoliciesAttachmentsEstimateImpactPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Attachment Impact<br/>
        /// Estimate how many keys and teams would be affected by a policy attachment.<br/>
        /// Use this before creating an attachment to preview the blast radius.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments/estimate-impact" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "hipaa-compliance",<br/>
        ///         "tags": ["healthcare", "health-*"]<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AttachmentImpactResponse>> EstimateAttachmentImpactPoliciesAttachmentsEstimateImpactPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Attachment Impact<br/>
        /// Estimate how many keys and teams would be affected by a policy attachment.<br/>
        /// Use this before creating an attachment to preview the blast radius.<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/policies/attachments/estimate-impact" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "policy_name": "hipaa-compliance",<br/>
        ///         "tags": ["healthcare", "health-*"]<br/>
        ///     }'<br/>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AttachmentImpactResponse> EstimateAttachmentImpactPoliciesAttachmentsEstimateImpactPostAsync(
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