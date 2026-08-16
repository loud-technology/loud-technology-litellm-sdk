
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Action to take when content is flagged: 'block' (raise exception) or 'monitor' (log only)<br/>
    /// Default Value: monitor
    /// </summary>
    public sealed partial class LitellmParamsOnFlaggedAction
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}