
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Successfully updated key with its updated information
    /// </summary>
    public sealed partial class SuccessfulKeyUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object KeyInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessfulKeyUpdate" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="keyInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SuccessfulKeyUpdate(
            string key,
            object keyInfo)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.KeyInfo = keyInfo ?? throw new global::System.ArgumentNullException(nameof(keyInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessfulKeyUpdate" /> class.
        /// </summary>
        public SuccessfulKeyUpdate()
        {
        }

    }
}