
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for listing all versions of a policy.
    /// </summary>
    public sealed partial class PolicyVersionListResponse
    {
        /// <summary>
        /// Name of the policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PolicyName { get; set; }

        /// <summary>
        /// Total number of versions.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// All versions ordered by version_number desc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse>? Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyVersionListResponse" /> class.
        /// </summary>
        /// <param name="policyName">
        /// Name of the policy.
        /// </param>
        /// <param name="totalCount">
        /// Total number of versions.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="versions">
        /// All versions ordered by version_number desc.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyVersionListResponse(
            string policyName,
            int? totalCount,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse>? versions)
        {
            this.PolicyName = policyName ?? throw new global::System.ArgumentNullException(nameof(policyName));
            this.TotalCount = totalCount;
            this.Versions = versions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyVersionListResponse" /> class.
        /// </summary>
        public PolicyVersionListResponse()
        {
        }

    }
}