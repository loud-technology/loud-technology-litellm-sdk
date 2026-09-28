
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Strictness level for XecGuard context-grounding validation. 'BALANCED' (default) treats INCOMPLETE answers as SAFE; 'STRICT' flags them as UNSAFE. Grounding only runs in post_call when `metadata.xecguard_grounding_documents` is provided.
    /// </summary>
    public sealed partial class LitellmParamsGroundingStrictness
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}