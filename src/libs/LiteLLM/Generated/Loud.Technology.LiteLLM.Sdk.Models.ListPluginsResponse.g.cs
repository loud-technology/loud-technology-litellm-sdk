
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response from listing plugins.
    /// </summary>
    public sealed partial class ListPluginsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PluginListItem> Plugins { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPluginsResponse" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="plugins"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPluginsResponse(
            int count,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PluginListItem> plugins)
        {
            this.Count = count;
            this.Plugins = plugins ?? throw new global::System.ArgumentNullException(nameof(plugins));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPluginsResponse" /> class.
        /// </summary>
        public ListPluginsResponse()
        {
        }

    }
}