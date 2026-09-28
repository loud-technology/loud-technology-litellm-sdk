
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class NewMCPToolsetRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPToolsetTool>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolset_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolsetName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewMCPToolsetRequest" /> class.
        /// </summary>
        /// <param name="toolsetName"></param>
        /// <param name="description"></param>
        /// <param name="tools">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewMCPToolsetRequest(
            string toolsetName,
            string? description,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPToolsetTool>? tools)
        {
            this.Description = description;
            this.Tools = tools;
            this.ToolsetName = toolsetName ?? throw new global::System.ArgumentNullException(nameof(toolsetName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewMCPToolsetRequest" /> class.
        /// </summary>
        public NewMCPToolsetRequest()
        {
        }

    }
}