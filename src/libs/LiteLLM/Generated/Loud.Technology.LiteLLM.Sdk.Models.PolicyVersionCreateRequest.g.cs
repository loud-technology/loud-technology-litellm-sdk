
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for creating a new policy version (draft).
    /// </summary>
    public sealed partial class PolicyVersionCreateRequest
    {
        /// <summary>
        /// Policy ID to clone from. If None, clone from current production version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_policy_id")]
        public string? SourcePolicyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyVersionCreateRequest" /> class.
        /// </summary>
        /// <param name="sourcePolicyId">
        /// Policy ID to clone from. If None, clone from current production version.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyVersionCreateRequest(
            string? sourcePolicyId)
        {
            this.SourcePolicyId = sourcePolicyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyVersionCreateRequest" /> class.
        /// </summary>
        public PolicyVersionCreateRequest()
        {
        }

    }
}