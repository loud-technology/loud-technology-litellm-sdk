
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response from policy validation.<br/>
    /// - `valid`: True if no blocking errors were found<br/>
    /// - `errors`: List of blocking errors (prevent policy from being applied)<br/>
    /// - `warnings`: List of non-blocking warnings (policy can still be applied)
    /// </summary>
    public sealed partial class PolicyValidationResponse
    {
        /// <summary>
        /// List of blocking validation errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyValidationError>? Errors { get; set; }

        /// <summary>
        /// True if the policy configuration is valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// List of non-blocking validation warnings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyValidationError>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyValidationResponse" /> class.
        /// </summary>
        /// <param name="valid">
        /// True if the policy configuration is valid.
        /// </param>
        /// <param name="errors">
        /// List of blocking validation errors.
        /// </param>
        /// <param name="warnings">
        /// List of non-blocking validation warnings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyValidationResponse(
            bool valid,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyValidationError>? errors,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyValidationError>? warnings)
        {
            this.Errors = errors;
            this.Valid = valid;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyValidationResponse" /> class.
        /// </summary>
        public PolicyValidationResponse()
        {
        }

    }
}