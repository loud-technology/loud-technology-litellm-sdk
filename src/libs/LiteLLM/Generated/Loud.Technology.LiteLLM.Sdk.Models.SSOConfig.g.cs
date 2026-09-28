
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for SSO environment variables and settings
    /// </summary>
    public sealed partial class SSOConfig
    {
        /// <summary>
        /// Google OAuth Client ID for SSO authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_client_id")]
        public string? GoogleClientId { get; set; }

        /// <summary>
        /// Google OAuth Client Secret for SSO authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_client_secret")]
        public string? GoogleClientSecret { get; set; }

        /// <summary>
        /// Microsoft OAuth Client ID for SSO authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft_client_id")]
        public string? MicrosoftClientId { get; set; }

        /// <summary>
        /// Microsoft OAuth Client Secret for SSO authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft_client_secret")]
        public string? MicrosoftClientSecret { get; set; }

        /// <summary>
        /// Microsoft Azure Tenant ID for SSO authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("microsoft_tenant")]
        public string? MicrosoftTenant { get; set; }

        /// <summary>
        /// Generic OAuth Client ID for SSO authentication (used for Okta and other providers)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_client_id")]
        public string? GenericClientId { get; set; }

        /// <summary>
        /// Generic OAuth Client Secret for SSO authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_client_secret")]
        public string? GenericClientSecret { get; set; }

        /// <summary>
        /// Authorization endpoint URL for generic OAuth provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_authorization_endpoint")]
        public string? GenericAuthorizationEndpoint { get; set; }

        /// <summary>
        /// Token endpoint URL for generic OAuth provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_token_endpoint")]
        public string? GenericTokenEndpoint { get; set; }

        /// <summary>
        /// User info endpoint URL for generic OAuth provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_userinfo_endpoint")]
        public string? GenericUserinfoEndpoint { get; set; }

        /// <summary>
        /// Space-separated OAuth scopes requested from the generic provider, e.g. 'openid email profile'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_scope")]
        public string? GenericScope { get; set; }

        /// <summary>
        /// URL of the SAML IdP metadata to fetch and parse for SSO authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_idp_metadata_url")]
        public string? SamlIdpMetadataUrl { get; set; }

        /// <summary>
        /// Inline SAML IdP metadata XML, used when a metadata URL is not available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_idp_metadata_xml")]
        public string? SamlIdpMetadataXml { get; set; }

        /// <summary>
        /// SAML Service Provider entityID; defaults to the proxy's /sso/saml/metadata URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_sp_entity_id")]
        public string? SamlSpEntityId { get; set; }

        /// <summary>
        /// 'true' to accept IdP-initiated (unsolicited) SAML responses, which cannot be browser-bound against login CSRF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saml_allow_unsolicited")]
        public string? SamlAllowUnsolicited { get; set; }

        /// <summary>
        /// Base URL of the proxy server for SSO redirects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_base_url")]
        public string? ProxyBaseUrl { get; set; }

        /// <summary>
        /// Email of the proxy admin user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Access mode for the UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_access_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::Loud.Technology.LiteLLM.Sdk.AccessControlUiAccessMode, string, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.AccessControlUiAccessMode, string, object>? UiAccessMode { get; set; }

        /// <summary>
        /// Configuration for mapping SSO groups to LiteLLM roles based on group claims in the SSO token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_mappings")]
        public global::Loud.Technology.LiteLLM.Sdk.RoleMappings? RoleMappings { get; set; }

        /// <summary>
        /// Configuration for mapping SSO JWT fields to team IDs. Takes precedence over config file settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_mappings")]
        public global::Loud.Technology.LiteLLM.Sdk.TeamMappings? TeamMappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOConfig" /> class.
        /// </summary>
        /// <param name="googleClientId">
        /// Google OAuth Client ID for SSO authentication
        /// </param>
        /// <param name="googleClientSecret">
        /// Google OAuth Client Secret for SSO authentication
        /// </param>
        /// <param name="microsoftClientId">
        /// Microsoft OAuth Client ID for SSO authentication
        /// </param>
        /// <param name="microsoftClientSecret">
        /// Microsoft OAuth Client Secret for SSO authentication
        /// </param>
        /// <param name="microsoftTenant">
        /// Microsoft Azure Tenant ID for SSO authentication
        /// </param>
        /// <param name="genericClientId">
        /// Generic OAuth Client ID for SSO authentication (used for Okta and other providers)
        /// </param>
        /// <param name="genericClientSecret">
        /// Generic OAuth Client Secret for SSO authentication
        /// </param>
        /// <param name="genericAuthorizationEndpoint">
        /// Authorization endpoint URL for generic OAuth provider
        /// </param>
        /// <param name="genericTokenEndpoint">
        /// Token endpoint URL for generic OAuth provider
        /// </param>
        /// <param name="genericUserinfoEndpoint">
        /// User info endpoint URL for generic OAuth provider
        /// </param>
        /// <param name="genericScope">
        /// Space-separated OAuth scopes requested from the generic provider, e.g. 'openid email profile'
        /// </param>
        /// <param name="samlIdpMetadataUrl">
        /// URL of the SAML IdP metadata to fetch and parse for SSO authentication
        /// </param>
        /// <param name="samlIdpMetadataXml">
        /// Inline SAML IdP metadata XML, used when a metadata URL is not available
        /// </param>
        /// <param name="samlSpEntityId">
        /// SAML Service Provider entityID; defaults to the proxy's /sso/saml/metadata URL
        /// </param>
        /// <param name="samlAllowUnsolicited">
        /// 'true' to accept IdP-initiated (unsolicited) SAML responses, which cannot be browser-bound against login CSRF
        /// </param>
        /// <param name="proxyBaseUrl">
        /// Base URL of the proxy server for SSO redirects
        /// </param>
        /// <param name="userEmail">
        /// Email of the proxy admin user
        /// </param>
        /// <param name="uiAccessMode">
        /// Access mode for the UI
        /// </param>
        /// <param name="roleMappings">
        /// Configuration for mapping SSO groups to LiteLLM roles based on group claims in the SSO token
        /// </param>
        /// <param name="teamMappings">
        /// Configuration for mapping SSO JWT fields to team IDs. Takes precedence over config file settings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSOConfig(
            string? googleClientId,
            string? googleClientSecret,
            string? microsoftClientId,
            string? microsoftClientSecret,
            string? microsoftTenant,
            string? genericClientId,
            string? genericClientSecret,
            string? genericAuthorizationEndpoint,
            string? genericTokenEndpoint,
            string? genericUserinfoEndpoint,
            string? genericScope,
            string? samlIdpMetadataUrl,
            string? samlIdpMetadataXml,
            string? samlSpEntityId,
            string? samlAllowUnsolicited,
            string? proxyBaseUrl,
            string? userEmail,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.AccessControlUiAccessMode, string, object>? uiAccessMode,
            global::Loud.Technology.LiteLLM.Sdk.RoleMappings? roleMappings,
            global::Loud.Technology.LiteLLM.Sdk.TeamMappings? teamMappings)
        {
            this.GoogleClientId = googleClientId;
            this.GoogleClientSecret = googleClientSecret;
            this.MicrosoftClientId = microsoftClientId;
            this.MicrosoftClientSecret = microsoftClientSecret;
            this.MicrosoftTenant = microsoftTenant;
            this.GenericClientId = genericClientId;
            this.GenericClientSecret = genericClientSecret;
            this.GenericAuthorizationEndpoint = genericAuthorizationEndpoint;
            this.GenericTokenEndpoint = genericTokenEndpoint;
            this.GenericUserinfoEndpoint = genericUserinfoEndpoint;
            this.GenericScope = genericScope;
            this.SamlIdpMetadataUrl = samlIdpMetadataUrl;
            this.SamlIdpMetadataXml = samlIdpMetadataXml;
            this.SamlSpEntityId = samlSpEntityId;
            this.SamlAllowUnsolicited = samlAllowUnsolicited;
            this.ProxyBaseUrl = proxyBaseUrl;
            this.UserEmail = userEmail;
            this.UiAccessMode = uiAccessMode;
            this.RoleMappings = roleMappings;
            this.TeamMappings = teamMappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOConfig" /> class.
        /// </summary>
        public SSOConfig()
        {
        }

    }
}