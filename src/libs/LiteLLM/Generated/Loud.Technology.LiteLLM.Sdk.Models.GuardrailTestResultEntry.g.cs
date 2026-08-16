
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailTestResultEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutputText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailTestResultEntry" /> class.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="details"></param>
        /// <param name="guardrailName"></param>
        /// <param name="outputText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailTestResultEntry(
            string action,
            string details,
            string guardrailName,
            string outputText)
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.GuardrailName = guardrailName ?? throw new global::System.ArgumentNullException(nameof(guardrailName));
            this.OutputText = outputText ?? throw new global::System.ArgumentNullException(nameof(outputText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailTestResultEntry" /> class.
        /// </summary>
        public GuardrailTestResultEntry()
        {
        }

    }
}