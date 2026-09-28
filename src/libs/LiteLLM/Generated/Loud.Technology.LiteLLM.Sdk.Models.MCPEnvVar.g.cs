
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One environment variable for an MCP server.<br/>
    /// Variables can be interpolated into ``static_headers`` using ``${NAME}``<br/>
    /// syntax. ``scope=global`` values are stored on the server. ``scope=user``<br/>
    /// values are stored per-user in ``LiteLLM_MCPUserEnvVars`` and supplied by<br/>
    /// each user.
    /// </summary>
    public sealed partial class MCPEnvVar
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Scope for an MCP server environment variable.<br/>
        /// - ``global``: value is provided by the admin and used for all users.<br/>
        /// - ``user``: each user must provide their own value via the per-user<br/>
        ///   env-var endpoint. The admin-supplied ``value`` is treated as a<br/>
        ///   placeholder/hint and is not used at request time.<br/>
        /// Default Value: global
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.MCPEnvVarScopeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.MCPEnvVarScope? Scope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPEnvVar" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="scope">
        /// Scope for an MCP server environment variable.<br/>
        /// - ``global``: value is provided by the admin and used for all users.<br/>
        /// - ``user``: each user must provide their own value via the per-user<br/>
        ///   env-var endpoint. The admin-supplied ``value`` is treated as a<br/>
        ///   placeholder/hint and is not used at request time.<br/>
        /// Default Value: global
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPEnvVar(
            string name,
            string? description,
            global::Loud.Technology.LiteLLM.Sdk.MCPEnvVarScope? scope,
            string? value)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Scope = scope;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPEnvVar" /> class.
        /// </summary>
        public MCPEnvVar()
        {
        }

    }
}