
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestPolicyTemplateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OverallAction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GuardrailTestResultEntry> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPolicyTemplateResponse" /> class.
        /// </summary>
        /// <param name="overallAction"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestPolicyTemplateResponse(
            string overallAction,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GuardrailTestResultEntry> results)
        {
            this.OverallAction = overallAction ?? throw new global::System.ArgumentNullException(nameof(overallAction));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPolicyTemplateResponse" /> class.
        /// </summary>
        public TestPolicyTemplateResponse()
        {
        }

    }
}