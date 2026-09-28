
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Action to take when content is flagged: 'block' (raise exception), 'monitor' (log only), or 'inject_system_message' (append an advisory system message and let the LLM decide)<br/>
    /// Default Value: block
    /// </summary>
    public sealed partial class LitellmParamsOnFlagged
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}