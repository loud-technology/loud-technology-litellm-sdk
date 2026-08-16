
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGuardrailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.Guardrail Guardrail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        /// <param name="guardrail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGuardrailRequest(
            global::Loud.Technology.LiteLLM.Sdk.Guardrail guardrail)
        {
            this.Guardrail = guardrail ?? throw new global::System.ArgumentNullException(nameof(guardrail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGuardrailRequest" /> class.
        /// </summary>
        public UpdateGuardrailRequest()
        {
        }

    }
}