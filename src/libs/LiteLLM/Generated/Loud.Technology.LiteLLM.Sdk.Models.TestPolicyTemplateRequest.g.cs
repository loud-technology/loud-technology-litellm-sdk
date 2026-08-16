
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestPolicyTemplateRequest
    {
        /// <summary>
        /// All guardrailDefinitions from the policy template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_definitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> GuardrailDefinitions { get; set; }

        /// <summary>
        /// Test input text to run guardrails against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPolicyTemplateRequest" /> class.
        /// </summary>
        /// <param name="guardrailDefinitions">
        /// All guardrailDefinitions from the policy template
        /// </param>
        /// <param name="text">
        /// Test input text to run guardrails against
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestPolicyTemplateRequest(
            global::System.Collections.Generic.IList<object> guardrailDefinitions,
            string text)
        {
            this.GuardrailDefinitions = guardrailDefinitions ?? throw new global::System.ArgumentNullException(nameof(guardrailDefinitions));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPolicyTemplateRequest" /> class.
        /// </summary>
        public TestPolicyTemplateRequest()
        {
        }

    }
}