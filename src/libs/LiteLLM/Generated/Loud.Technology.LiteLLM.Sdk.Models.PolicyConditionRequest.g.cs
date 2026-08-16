
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Condition for when a policy applies.
    /// </summary>
    public sealed partial class PolicyConditionRequest
    {
        /// <summary>
        /// Model name pattern (exact match or regex) for when policy applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyConditionRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model name pattern (exact match or regex) for when policy applies.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyConditionRequest(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyConditionRequest" /> class.
        /// </summary>
        public PolicyConditionRequest()
        {
        }

    }
}