
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Action when a violation is detected: 'block' rejects the call (400 error), 'monitor' logs only, 'passthrough' replaces response content with violation message (200 status).<br/>
    /// Default Value: passthrough
    /// </summary>
    public sealed partial class GraySwanGuardrailConfigModelOptionalParamsOnFlaggedAction
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}