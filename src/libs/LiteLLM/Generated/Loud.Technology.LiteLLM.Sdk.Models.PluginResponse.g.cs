
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Plugin information in API responses.
    /// </summary>
    public sealed partial class PluginResponse
    {
        /// <summary>
        /// Plugin description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether plugin is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Plugin unique ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Plugin name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Plugin source reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Source { get; set; }

        /// <summary>
        /// Plugin version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginResponse" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether plugin is enabled
        /// </param>
        /// <param name="id">
        /// Plugin unique ID
        /// </param>
        /// <param name="name">
        /// Plugin name
        /// </param>
        /// <param name="source">
        /// Plugin source reference
        /// </param>
        /// <param name="description">
        /// Plugin description
        /// </param>
        /// <param name="version">
        /// Plugin version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PluginResponse(
            bool enabled,
            string id,
            string name,
            global::System.Collections.Generic.Dictionary<string, string> source,
            string? description,
            string? version)
        {
            this.Description = description;
            this.Enabled = enabled;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginResponse" /> class.
        /// </summary>
        public PluginResponse()
        {
        }

    }
}