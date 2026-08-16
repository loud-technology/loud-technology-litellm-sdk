
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NewMCPServerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_keys")]
        public bool? AllowAllKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_status")]
        public string? ApprovalStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        public global::System.Collections.Generic.IList<string>? Args { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestAuthType2? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_url")]
        public string? AuthorizationUrl { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_on_public_internet")]
        public bool? AvailableOnPublicInternet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_api_key_help_url")]
        public string? ByokApiKeyHelpUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_description")]
        public global::System.Collections.Generic.IList<string>? ByokDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Loud.Technology.LiteLLM.Sdk.MCPCredentials? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env")]
        public global::System.Collections.Generic.Dictionary<string, string>? Env { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_headers")]
        public global::System.Collections.Generic.IList<string>? ExtraHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_access_groups")]
        public global::System.Collections.Generic.IList<string>? McpAccessGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_info")]
        public object? McpInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2_flow")]
        public global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestOauth2Flow2? Oauth2Flow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration_url")]
        public string? RegistrationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_id")]
        public string? ServerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        public string? ServerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec_path")]
        public string? SpecPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? StaticHeaders { get; set; }

        /// <summary>
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        public global::System.DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_by")]
        public string? SubmittedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_url")]
        public string? TokenUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name_to_description")]
        public global::System.Collections.Generic.Dictionary<string, string>? ToolNameToDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name_to_display_name")]
        public global::System.Collections.Generic.Dictionary<string, string>? ToolNameToDisplayName { get; set; }

        /// <summary>
        /// Default Value: sse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.NewMCPServerRequestTransportJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestTransport? Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewMCPServerRequest" /> class.
        /// </summary>
        /// <param name="alias"></param>
        /// <param name="allowAllKeys">
        /// Default Value: false
        /// </param>
        /// <param name="allowedTools"></param>
        /// <param name="approvalStatus">
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </param>
        /// <param name="args"></param>
        /// <param name="authType"></param>
        /// <param name="authorizationUrl"></param>
        /// <param name="availableOnPublicInternet">
        /// Default Value: true
        /// </param>
        /// <param name="byokApiKeyHelpUrl"></param>
        /// <param name="byokDescription"></param>
        /// <param name="command"></param>
        /// <param name="credentials"></param>
        /// <param name="description"></param>
        /// <param name="env"></param>
        /// <param name="extraHeaders"></param>
        /// <param name="instructions"></param>
        /// <param name="isByok">
        /// Default Value: false
        /// </param>
        /// <param name="mcpAccessGroups"></param>
        /// <param name="mcpInfo"></param>
        /// <param name="oauth2Flow"></param>
        /// <param name="registrationUrl"></param>
        /// <param name="serverId"></param>
        /// <param name="serverName"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="specPath"></param>
        /// <param name="staticHeaders"></param>
        /// <param name="submittedAt">
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </param>
        /// <param name="submittedBy">
        /// Server-managed: set by the endpoint; caller values are overridden.
        /// </param>
        /// <param name="tokenUrl"></param>
        /// <param name="toolNameToDescription"></param>
        /// <param name="toolNameToDisplayName"></param>
        /// <param name="transport">
        /// Default Value: sse
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewMCPServerRequest(
            string? alias,
            bool? allowAllKeys,
            global::System.Collections.Generic.IList<string>? allowedTools,
            string? approvalStatus,
            global::System.Collections.Generic.IList<string>? args,
            global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestAuthType2? authType,
            string? authorizationUrl,
            bool? availableOnPublicInternet,
            string? byokApiKeyHelpUrl,
            global::System.Collections.Generic.IList<string>? byokDescription,
            string? command,
            global::Loud.Technology.LiteLLM.Sdk.MCPCredentials? credentials,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.IList<string>? extraHeaders,
            string? instructions,
            bool? isByok,
            global::System.Collections.Generic.IList<string>? mcpAccessGroups,
            object? mcpInfo,
            global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestOauth2Flow2? oauth2Flow,
            string? registrationUrl,
            string? serverId,
            string? serverName,
            string? sourceUrl,
            string? specPath,
            global::System.Collections.Generic.Dictionary<string, string>? staticHeaders,
            global::System.DateTime? submittedAt,
            string? submittedBy,
            string? tokenUrl,
            global::System.Collections.Generic.Dictionary<string, string>? toolNameToDescription,
            global::System.Collections.Generic.Dictionary<string, string>? toolNameToDisplayName,
            global::Loud.Technology.LiteLLM.Sdk.NewMCPServerRequestTransport? transport,
            string? url)
        {
            this.Alias = alias;
            this.AllowAllKeys = allowAllKeys;
            this.AllowedTools = allowedTools;
            this.ApprovalStatus = approvalStatus;
            this.Args = args;
            this.AuthType = authType;
            this.AuthorizationUrl = authorizationUrl;
            this.AvailableOnPublicInternet = availableOnPublicInternet;
            this.ByokApiKeyHelpUrl = byokApiKeyHelpUrl;
            this.ByokDescription = byokDescription;
            this.Command = command;
            this.Credentials = credentials;
            this.Description = description;
            this.Env = env;
            this.ExtraHeaders = extraHeaders;
            this.Instructions = instructions;
            this.IsByok = isByok;
            this.McpAccessGroups = mcpAccessGroups;
            this.McpInfo = mcpInfo;
            this.Oauth2Flow = oauth2Flow;
            this.RegistrationUrl = registrationUrl;
            this.ServerId = serverId;
            this.ServerName = serverName;
            this.SourceUrl = sourceUrl;
            this.SpecPath = specPath;
            this.StaticHeaders = staticHeaders;
            this.SubmittedAt = submittedAt;
            this.SubmittedBy = submittedBy;
            this.TokenUrl = tokenUrl;
            this.ToolNameToDescription = toolNameToDescription;
            this.ToolNameToDisplayName = toolNameToDisplayName;
            this.Transport = transport;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewMCPServerRequest" /> class.
        /// </summary>
        public NewMCPServerRequest()
        {
        }

    }
}