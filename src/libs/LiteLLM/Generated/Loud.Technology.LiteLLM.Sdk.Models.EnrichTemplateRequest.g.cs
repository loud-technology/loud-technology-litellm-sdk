
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnrichTemplateRequest
    {
        /// <summary>
        /// Optional list of competitor names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("competitors")]
        public global::System.Collections.Generic.IList<string>? Competitors { get; set; }

        /// <summary>
        /// Refinement instruction for modifying the competitor list (e.g. 'add 10 more from Asia')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public string? Instruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichTemplateRequest" /> class.
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="templateId"></param>
        /// <param name="competitors">
        /// Optional list of competitor names
        /// </param>
        /// <param name="instruction">
        /// Refinement instruction for modifying the competitor list (e.g. 'add 10 more from Asia')
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnrichTemplateRequest(
            object parameters,
            string templateId,
            global::System.Collections.Generic.IList<string>? competitors,
            string? instruction,
            string? model)
        {
            this.Competitors = competitors;
            this.Instruction = instruction;
            this.Model = model;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichTemplateRequest" /> class.
        /// </summary>
        public EnrichTemplateRequest()
        {
        }

    }
}