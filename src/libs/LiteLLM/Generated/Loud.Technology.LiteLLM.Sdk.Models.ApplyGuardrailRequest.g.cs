
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApplyGuardrailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PiiEntityType>? Entities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailName { get; set; }

        /// <summary>
        /// Default Value: request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public string? InputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="ApplyGuardrailRequest" /> class.
        /// </summary>
        /// <param name="guardrailName"></param>
        /// <param name="text"></param>
        /// <param name="entities"></param>
        /// <param name="inputType">
        /// Default Value: request
        /// </param>
        /// <param name="language"></param>
        /// <param name="messages"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyGuardrailRequest(
            string guardrailName,
            string text,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PiiEntityType>? entities,
            string? inputType,
            string? language,
            global::System.Collections.Generic.IList<object>? messages,
            object? metadata)
        {
            this.Entities = entities;
            this.GuardrailName = guardrailName ?? throw new global::System.ArgumentNullException(nameof(guardrailName));
            this.InputType = inputType;
            this.Language = language;
            this.Messages = messages;
            this.Metadata = metadata;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyGuardrailRequest" /> class.
        /// </summary>
        public ApplyGuardrailRequest()
        {
        }

    }
}