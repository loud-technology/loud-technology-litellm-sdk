
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SuggestTemplatesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attack_examples")]
        public global::System.Collections.Generic.IList<string>? AttackExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestTemplatesRequest" /> class.
        /// </summary>
        /// <param name="attackExamples"></param>
        /// <param name="description"></param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuggestTemplatesRequest(
            global::System.Collections.Generic.IList<string>? attackExamples,
            string? description,
            string? model)
        {
            this.AttackExamples = attackExamples;
            this.Description = description;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuggestTemplatesRequest" /> class.
        /// </summary>
        public SuggestTemplatesRequest()
        {
        }

    }
}