
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for UI theme customization
    /// </summary>
    public sealed partial class UIThemeConfig
    {
        /// <summary>
        /// URL or path to custom logo image. Can be a local file path or HTTP/HTTPS URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// URL to custom favicon image. Must be an HTTP/HTTPS URL to a .ico, .png, or .svg file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon_url")]
        public string? FaviconUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UIThemeConfig" /> class.
        /// </summary>
        /// <param name="logoUrl">
        /// URL or path to custom logo image. Can be a local file path or HTTP/HTTPS URL
        /// </param>
        /// <param name="faviconUrl">
        /// URL to custom favicon image. Must be an HTTP/HTTPS URL to a .ico, .png, or .svg file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UIThemeConfig(
            string? logoUrl,
            string? faviconUrl)
        {
            this.LogoUrl = logoUrl;
            this.FaviconUrl = faviconUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UIThemeConfig" /> class.
        /// </summary>
        public UIThemeConfig()
        {
        }

    }
}