
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserBannerUpdate
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.UserBannerUpdateSeverityJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.UserBannerUpdateSeverity? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBannerUpdate" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserBannerUpdate(
            bool? enabled,
            string? message,
            global::Loud.Technology.LiteLLM.Sdk.UserBannerUpdateSeverity? severity)
        {
            this.Enabled = enabled;
            this.Message = message;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBannerUpdate" /> class.
        /// </summary>
        public UserBannerUpdate()
        {
        }

    }
}