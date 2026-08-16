
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Guardrails configuration for a policy.
    /// </summary>
    public sealed partial class PolicyGuardrailsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add")]
        public global::System.Collections.Generic.IList<string>? Add { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove")]
        public global::System.Collections.Generic.IList<string>? Remove { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyGuardrailsResponse" /> class.
        /// </summary>
        /// <param name="add"></param>
        /// <param name="remove"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyGuardrailsResponse(
            global::System.Collections.Generic.IList<string>? add,
            global::System.Collections.Generic.IList<string>? remove)
        {
            this.Add = add;
            this.Remove = remove;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyGuardrailsResponse" /> class.
        /// </summary>
        public PolicyGuardrailsResponse()
        {
        }

    }
}