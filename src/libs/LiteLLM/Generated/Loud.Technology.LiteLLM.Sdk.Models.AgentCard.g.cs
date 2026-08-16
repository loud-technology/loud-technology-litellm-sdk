
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The AgentCard is a self-describing manifest for an agent.<br/>
    /// It provides essential metadata including the agent's identity, capabilities,<br/>
    /// skills, supported communication methods, and security requirements.
    /// </summary>
    public sealed partial class AgentCard
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolVersion")]
        public string? ProtocolVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Defines optional capabilities supported by an agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::Loud.Technology.LiteLLM.Sdk.AgentCapabilities? Capabilities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultInputModes")]
        public global::System.Collections.Generic.IList<string>? DefaultInputModes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultOutputModes")]
        public global::System.Collections.Generic.IList<string>? DefaultOutputModes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentSkill>? Skills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferredTransport")]
        public string? PreferredTransport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalInterfaces")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentInterface>? AdditionalInterfaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iconUrl")]
        public string? IconUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::Loud.Technology.LiteLLM.Sdk.AgentProvider? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentationUrl")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("securitySchemes")]
        public object? SecuritySchemes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("security")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? Security { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsAuthenticatedExtendedCard")]
        public bool? SupportsAuthenticatedExtendedCard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatures")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentCardSignature>? Signatures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCard" /> class.
        /// </summary>
        /// <param name="protocolVersion"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="url"></param>
        /// <param name="version"></param>
        /// <param name="capabilities">
        /// Defines optional capabilities supported by an agent.
        /// </param>
        /// <param name="defaultInputModes"></param>
        /// <param name="defaultOutputModes"></param>
        /// <param name="skills"></param>
        /// <param name="preferredTransport"></param>
        /// <param name="additionalInterfaces"></param>
        /// <param name="iconUrl"></param>
        /// <param name="provider"></param>
        /// <param name="documentationUrl"></param>
        /// <param name="securitySchemes"></param>
        /// <param name="security"></param>
        /// <param name="supportsAuthenticatedExtendedCard"></param>
        /// <param name="signatures"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCard(
            string? protocolVersion,
            string? name,
            string? description,
            string? url,
            string? version,
            global::Loud.Technology.LiteLLM.Sdk.AgentCapabilities? capabilities,
            global::System.Collections.Generic.IList<string>? defaultInputModes,
            global::System.Collections.Generic.IList<string>? defaultOutputModes,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentSkill>? skills,
            string? preferredTransport,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentInterface>? additionalInterfaces,
            string? iconUrl,
            global::Loud.Technology.LiteLLM.Sdk.AgentProvider? provider,
            string? documentationUrl,
            object? securitySchemes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>? security,
            bool? supportsAuthenticatedExtendedCard,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AgentCardSignature>? signatures)
        {
            this.ProtocolVersion = protocolVersion;
            this.Name = name;
            this.Description = description;
            this.Url = url;
            this.Version = version;
            this.Capabilities = capabilities;
            this.DefaultInputModes = defaultInputModes;
            this.DefaultOutputModes = defaultOutputModes;
            this.Skills = skills;
            this.PreferredTransport = preferredTransport;
            this.AdditionalInterfaces = additionalInterfaces;
            this.IconUrl = iconUrl;
            this.Provider = provider;
            this.DocumentationUrl = documentationUrl;
            this.SecuritySchemes = securitySchemes;
            this.Security = security;
            this.SupportsAuthenticatedExtendedCard = supportsAuthenticatedExtendedCard;
            this.Signatures = signatures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCard" /> class.
        /// </summary>
        public AgentCard()
        {
        }

    }
}