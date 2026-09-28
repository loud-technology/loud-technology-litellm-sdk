
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserBanner
    {
        /// <summary>
        /// If true, the banner is shown to all authenticated dashboard users.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Banner text shown to dashboard users. Markdown is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Visual style of the banner.<br/>
        /// Default Value: info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.UserBannerSeverityJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.UserBannerSeverity? Severity { get; set; }

        /// <summary>
        /// Server-stamped opaque publish identity; a fresh value is generated on every update so clients re-surface dismissed banners on republish.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public string? Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBanner" /> class.
        /// </summary>
        /// <param name="enabled">
        /// If true, the banner is shown to all authenticated dashboard users.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="message">
        /// Banner text shown to dashboard users. Markdown is supported.
        /// </param>
        /// <param name="severity">
        /// Visual style of the banner.<br/>
        /// Default Value: info
        /// </param>
        /// <param name="revision">
        /// Server-stamped opaque publish identity; a fresh value is generated on every update so clients re-surface dismissed banners on republish.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserBanner(
            bool? enabled,
            string? message,
            global::Loud.Technology.LiteLLM.Sdk.UserBannerSeverity? severity,
            string? revision)
        {
            this.Enabled = enabled;
            this.Message = message;
            this.Severity = severity;
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBanner" /> class.
        /// </summary>
        public UserBanner()
        {
        }

    }
}