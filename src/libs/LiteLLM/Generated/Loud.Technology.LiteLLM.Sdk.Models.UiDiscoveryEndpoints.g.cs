
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UiDiscoveryEndpoints
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_root_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerRootPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_base_url")]
        public string? ProxyBaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_redirect_to_sso")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoRedirectToSso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("admin_ui_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AdminUiDisabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_configured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SsoConfigured { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide_default_credentials_hint")]
        public bool? HideDefaultCredentialsHint { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_control_plane")]
        public bool? IsControlPlane { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workers")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.WorkerRegistryEntry>? Workers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UiDiscoveryEndpoints" /> class.
        /// </summary>
        /// <param name="serverRootPath"></param>
        /// <param name="autoRedirectToSso"></param>
        /// <param name="adminUiDisabled"></param>
        /// <param name="ssoConfigured"></param>
        /// <param name="proxyBaseUrl"></param>
        /// <param name="hideDefaultCredentialsHint">
        /// Default Value: false
        /// </param>
        /// <param name="isControlPlane">
        /// Default Value: false
        /// </param>
        /// <param name="workers">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UiDiscoveryEndpoints(
            string serverRootPath,
            bool autoRedirectToSso,
            bool adminUiDisabled,
            bool ssoConfigured,
            string? proxyBaseUrl,
            bool? hideDefaultCredentialsHint,
            bool? isControlPlane,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.WorkerRegistryEntry>? workers)
        {
            this.ServerRootPath = serverRootPath ?? throw new global::System.ArgumentNullException(nameof(serverRootPath));
            this.ProxyBaseUrl = proxyBaseUrl;
            this.AutoRedirectToSso = autoRedirectToSso;
            this.AdminUiDisabled = adminUiDisabled;
            this.SsoConfigured = ssoConfigured;
            this.HideDefaultCredentialsHint = hideDefaultCredentialsHint;
            this.IsControlPlane = isControlPlane;
            this.Workers = workers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UiDiscoveryEndpoints" /> class.
        /// </summary>
        public UiDiscoveryEndpoints()
        {
        }

    }
}