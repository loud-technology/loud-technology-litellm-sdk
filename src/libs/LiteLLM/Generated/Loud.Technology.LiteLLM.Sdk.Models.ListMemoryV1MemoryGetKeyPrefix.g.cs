
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Filter by key prefix (Redis-style namespace scan). Mutually exclusive with `key`; if both are provided, `key_prefix` wins.
    /// </summary>
    public sealed partial class ListMemoryV1MemoryGetKeyPrefix
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}