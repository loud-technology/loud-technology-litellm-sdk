
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Failed key update with reason
    /// </summary>
    public sealed partial class FailedKeyUpdate
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
        public object? KeyInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FailedReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedKeyUpdate" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="failedReason"></param>
        /// <param name="keyInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FailedKeyUpdate(
            string key,
            string failedReason,
            object? keyInfo)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.KeyInfo = keyInfo;
            this.FailedReason = failedReason ?? throw new global::System.ArgumentNullException(nameof(failedReason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailedKeyUpdate" /> class.
        /// </summary>
        public FailedKeyUpdate()
        {
        }

    }
}