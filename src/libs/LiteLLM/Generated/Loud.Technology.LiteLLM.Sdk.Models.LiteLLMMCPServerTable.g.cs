
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Represents a LiteLLM_MCPServerTable record
    /// </summary>
    public sealed partial class LiteLLMMCPServerTable
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
        /// Approval status: 'pending_review', 'active', 'rejected'<br/>
        /// Default Value: active
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
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTableAuthType2? AuthType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_app_reachable")]
        public bool? ConnectedAppReachable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Loud.Technology.LiteLLM.Sdk.MCPCredentials? Credentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dcr_bridge")]
        public bool? DcrBridge { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegate_auth_to_upstream")]
        public bool? DelegateAuthToUpstream { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("env_vars")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPEnvVar>? EnvVars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_headers")]
        public global::System.Collections.Generic.IList<string>? ExtraHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_user_credential")]
        public bool? HasUserCredential { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_check_error")]
        public string? HealthCheckError { get; set; }

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
        /// Whether this server is defined in config and is read-only.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_config")]
        public bool? IsConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_health_check")]
        public global::System.DateTime? LastHealthCheck { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_requests")]
        public int? MaxConcurrentRequests { get; set; }

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
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTableOauth2Flow2? Oauth2Flow { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_passthrough")]
        public bool? OauthPassthrough { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_server_oauth_discovery")]
        public bool? PerServerOauthDiscovery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration_url")]
        public string? RegistrationUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_notes")]
        public string? ReviewNotes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed_at")]
        public global::System.DateTime? ReviewedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerId { get; set; }

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
        /// Health status: 'healthy', 'unhealthy', 'unknown'<br/>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTableStatus2? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_token_type")]
        public string? SubjectTokenType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        public global::System.DateTime? SubmittedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_by")]
        public string? SubmittedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<object>? Teams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_exchange_endpoint")]
        public string? TokenExchangeEndpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_exchange_profile")]
        public string? TokenExchangeProfile { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LiteLLMMCPServerTableTransportJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTableTransport Transport { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

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
        /// Initializes a new instance of the <see cref="LiteLLMMCPServerTable" /> class.
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="transport"></param>
        /// <param name="alias"></param>
        /// <param name="allowAllKeys">
        /// Default Value: false
        /// </param>
        /// <param name="allowedTools"></param>
        /// <param name="approvalStatus">
        /// Approval status: 'pending_review', 'active', 'rejected'<br/>
        /// Default Value: active
        /// </param>
        /// <param name="args"></param>
        /// <param name="audience"></param>
        /// <param name="authType"></param>
        /// <param name="authorizationUrl"></param>
        /// <param name="availableOnPublicInternet">
        /// Default Value: true
        /// </param>
        /// <param name="byokApiKeyHelpUrl"></param>
        /// <param name="byokDescription"></param>
        /// <param name="command"></param>
        /// <param name="connectedAppReachable"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="credentials"></param>
        /// <param name="dcrBridge"></param>
        /// <param name="delegateAuthToUpstream">
        /// Default Value: false
        /// </param>
        /// <param name="description"></param>
        /// <param name="env"></param>
        /// <param name="envVars"></param>
        /// <param name="extraHeaders"></param>
        /// <param name="hasUserCredential"></param>
        /// <param name="healthCheckError"></param>
        /// <param name="instructions"></param>
        /// <param name="isByok">
        /// Default Value: false
        /// </param>
        /// <param name="isConfig">
        /// Whether this server is defined in config and is read-only.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="issuer"></param>
        /// <param name="lastHealthCheck"></param>
        /// <param name="maxConcurrentRequests"></param>
        /// <param name="mcpAccessGroups"></param>
        /// <param name="mcpInfo"></param>
        /// <param name="oauth2Flow"></param>
        /// <param name="oauthPassthrough">
        /// Default Value: false
        /// </param>
        /// <param name="perServerOauthDiscovery">
        /// Default Value: false
        /// </param>
        /// <param name="registrationUrl"></param>
        /// <param name="reviewNotes"></param>
        /// <param name="reviewedAt"></param>
        /// <param name="serverName"></param>
        /// <param name="sourceUrl"></param>
        /// <param name="specPath"></param>
        /// <param name="staticHeaders"></param>
        /// <param name="status">
        /// Health status: 'healthy', 'unhealthy', 'unknown'<br/>
        /// Default Value: unknown
        /// </param>
        /// <param name="subjectTokenType"></param>
        /// <param name="submittedAt"></param>
        /// <param name="submittedBy"></param>
        /// <param name="teams"></param>
        /// <param name="timeout"></param>
        /// <param name="tokenExchangeEndpoint"></param>
        /// <param name="tokenExchangeProfile"></param>
        /// <param name="tokenUrl"></param>
        /// <param name="toolNameToDescription"></param>
        /// <param name="toolNameToDisplayName"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMMCPServerTable(
            string serverId,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTableTransport transport,
            string? alias,
            bool? allowAllKeys,
            global::System.Collections.Generic.IList<string>? allowedTools,
            string? approvalStatus,
            global::System.Collections.Generic.IList<string>? args,
            string? audience,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTableAuthType2? authType,
            string? authorizationUrl,
            bool? availableOnPublicInternet,
            string? byokApiKeyHelpUrl,
            global::System.Collections.Generic.IList<string>? byokDescription,
            string? command,
            bool? connectedAppReachable,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::Loud.Technology.LiteLLM.Sdk.MCPCredentials? credentials,
            bool? dcrBridge,
            bool? delegateAuthToUpstream,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? env,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPEnvVar>? envVars,
            global::System.Collections.Generic.IList<string>? extraHeaders,
            bool? hasUserCredential,
            string? healthCheckError,
            string? instructions,
            bool? isByok,
            bool? isConfig,
            string? issuer,
            global::System.DateTime? lastHealthCheck,
            int? maxConcurrentRequests,
            global::System.Collections.Generic.IList<string>? mcpAccessGroups,
            object? mcpInfo,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTableOauth2Flow2? oauth2Flow,
            bool? oauthPassthrough,
            bool? perServerOauthDiscovery,
            string? registrationUrl,
            string? reviewNotes,
            global::System.DateTime? reviewedAt,
            string? serverName,
            string? sourceUrl,
            string? specPath,
            global::System.Collections.Generic.Dictionary<string, string>? staticHeaders,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTableStatus2? status,
            string? subjectTokenType,
            global::System.DateTime? submittedAt,
            string? submittedBy,
            global::System.Collections.Generic.IList<object>? teams,
            double? timeout,
            string? tokenExchangeEndpoint,
            string? tokenExchangeProfile,
            string? tokenUrl,
            global::System.Collections.Generic.Dictionary<string, string>? toolNameToDescription,
            global::System.Collections.Generic.Dictionary<string, string>? toolNameToDisplayName,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            string? url)
        {
            this.Alias = alias;
            this.AllowAllKeys = allowAllKeys;
            this.AllowedTools = allowedTools;
            this.ApprovalStatus = approvalStatus;
            this.Args = args;
            this.Audience = audience;
            this.AuthType = authType;
            this.AuthorizationUrl = authorizationUrl;
            this.AvailableOnPublicInternet = availableOnPublicInternet;
            this.ByokApiKeyHelpUrl = byokApiKeyHelpUrl;
            this.ByokDescription = byokDescription;
            this.Command = command;
            this.ConnectedAppReachable = connectedAppReachable;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Credentials = credentials;
            this.DcrBridge = dcrBridge;
            this.DelegateAuthToUpstream = delegateAuthToUpstream;
            this.Description = description;
            this.Env = env;
            this.EnvVars = envVars;
            this.ExtraHeaders = extraHeaders;
            this.HasUserCredential = hasUserCredential;
            this.HealthCheckError = healthCheckError;
            this.Instructions = instructions;
            this.IsByok = isByok;
            this.IsConfig = isConfig;
            this.Issuer = issuer;
            this.LastHealthCheck = lastHealthCheck;
            this.MaxConcurrentRequests = maxConcurrentRequests;
            this.McpAccessGroups = mcpAccessGroups;
            this.McpInfo = mcpInfo;
            this.Oauth2Flow = oauth2Flow;
            this.OauthPassthrough = oauthPassthrough;
            this.PerServerOauthDiscovery = perServerOauthDiscovery;
            this.RegistrationUrl = registrationUrl;
            this.ReviewNotes = reviewNotes;
            this.ReviewedAt = reviewedAt;
            this.ServerId = serverId ?? throw new global::System.ArgumentNullException(nameof(serverId));
            this.ServerName = serverName;
            this.SourceUrl = sourceUrl;
            this.SpecPath = specPath;
            this.StaticHeaders = staticHeaders;
            this.Status = status;
            this.SubjectTokenType = subjectTokenType;
            this.SubmittedAt = submittedAt;
            this.SubmittedBy = submittedBy;
            this.Teams = teams;
            this.Timeout = timeout;
            this.TokenExchangeEndpoint = tokenExchangeEndpoint;
            this.TokenExchangeProfile = tokenExchangeProfile;
            this.TokenUrl = tokenUrl;
            this.ToolNameToDescription = toolNameToDescription;
            this.ToolNameToDisplayName = toolNameToDisplayName;
            this.Transport = transport;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMMCPServerTable" /> class.
        /// </summary>
        public LiteLLMMCPServerTable()
        {
        }

    }
}