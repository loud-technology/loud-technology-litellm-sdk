
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for the /policy/validate endpoint.
    /// </summary>
    public sealed partial class PolicyValidateRequest
    {
        /// <summary>
        /// Policy configuration to validate. Map of policy names to policy definitions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Policies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyValidateRequest" /> class.
        /// </summary>
        /// <param name="policies">
        /// Policy configuration to validate. Map of policy names to policy definitions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyValidateRequest(
            object policies)
        {
            this.Policies = policies ?? throw new global::System.ArgumentNullException(nameof(policies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyValidateRequest" /> class.
        /// </summary>
        public PolicyValidateRequest()
        {
        }

    }
}