#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISsoSettingsClient
    {
        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO configuration by saving to the dedicated SSO table.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateSsoSettingsUpdateSsoSettingsPatchAsync(

            global::Loud.Technology.LiteLLM.Sdk.SSOConfig request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO configuration by saving to the dedicated SSO table.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateSsoSettingsUpdateSsoSettingsPatchAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.SSOConfig request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO configuration by saving to the dedicated SSO table.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateSsoSettingsUpdateSsoSettingsPatchAsync(
            string? googleClientId = default,
            string? googleClientSecret = default,
            string? microsoftClientId = default,
            string? microsoftClientSecret = default,
            string? microsoftTenant = default,
            string? genericClientId = default,
            string? genericClientSecret = default,
            string? genericAuthorizationEndpoint = default,
            string? genericTokenEndpoint = default,
            string? genericUserinfoEndpoint = default,
            string? genericScope = default,
            string? samlIdpMetadataUrl = default,
            string? samlIdpMetadataXml = default,
            string? samlSpEntityId = default,
            string? samlAllowUnsolicited = default,
            string? proxyBaseUrl = default,
            string? userEmail = default,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.AccessControlUiAccessMode, string, object>? uiAccessMode = default,
            global::Loud.Technology.LiteLLM.Sdk.RoleMappings? roleMappings = default,
            global::Loud.Technology.LiteLLM.Sdk.TeamMappings? teamMappings = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}