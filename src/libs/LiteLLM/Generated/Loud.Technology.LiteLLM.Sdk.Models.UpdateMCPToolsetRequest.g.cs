
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateMCPToolsetRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPToolsetTool>? Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolsetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolset_name")]
        public string? ToolsetName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMCPToolsetRequest" /> class.
        /// </summary>
        /// <param name="toolsetId"></param>
        /// <param name="description"></param>
        /// <param name="tools"></param>
        /// <param name="toolsetName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMCPToolsetRequest(
            string toolsetId,
            string? description,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPToolsetTool>? tools,
            string? toolsetName)
        {
            this.Description = description;
            this.Tools = tools;
            this.ToolsetId = toolsetId ?? throw new global::System.ArgumentNullException(nameof(toolsetId));
            this.ToolsetName = toolsetName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMCPToolsetRequest" /> class.
        /// </summary>
        public UpdateMCPToolsetRequest()
        {
        }

    }
}