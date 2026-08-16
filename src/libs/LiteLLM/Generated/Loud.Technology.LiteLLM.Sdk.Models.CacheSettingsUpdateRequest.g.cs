
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CacheSettingsUpdateRequest
    {
        /// <summary>
        /// Cache settings to save
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CacheSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheSettingsUpdateRequest" /> class.
        /// </summary>
        /// <param name="cacheSettings">
        /// Cache settings to save
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CacheSettingsUpdateRequest(
            object cacheSettings)
        {
            this.CacheSettings = cacheSettings ?? throw new global::System.ArgumentNullException(nameof(cacheSettings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CacheSettingsUpdateRequest" /> class.
        /// </summary>
        public CacheSettingsUpdateRequest()
        {
        }

    }
}