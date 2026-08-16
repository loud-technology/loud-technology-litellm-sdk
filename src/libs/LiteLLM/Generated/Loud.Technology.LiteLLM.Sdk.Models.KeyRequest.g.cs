
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<string>? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_aliases")]
        public global::System.Collections.Generic.IList<string>? KeyAliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyRequest" /> class.
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="keyAliases"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyRequest(
            global::System.Collections.Generic.IList<string>? keys,
            global::System.Collections.Generic.IList<string>? keyAliases)
        {
            this.Keys = keys;
            this.KeyAliases = keyAliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyRequest" /> class.
        /// </summary>
        public KeyRequest()
        {
        }

    }
}