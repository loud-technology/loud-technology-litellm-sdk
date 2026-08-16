
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A declaration of a protocol extension supported by an Agent.
    /// </summary>
    public sealed partial class AgentExtension
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentExtension" /> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="description"></param>
        /// <param name="required"></param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentExtension(
            string? uri,
            string? description,
            bool? required,
            object? @params)
        {
            this.Uri = uri;
            this.Description = description;
            this.Required = required;
            this.Params = @params;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentExtension" /> class.
        /// </summary>
        public AgentExtension()
        {
        }

    }
}