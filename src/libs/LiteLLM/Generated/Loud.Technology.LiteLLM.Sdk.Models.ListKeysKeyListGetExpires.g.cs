
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Filter keys by expiration. 'expired' returns keys whose expires is in the past; 'active' returns keys that never expire or expire in the future. Omit to return keys regardless of expiration.
    /// </summary>
    public sealed partial class ListKeysKeyListGetExpires
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}