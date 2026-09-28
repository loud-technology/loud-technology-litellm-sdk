
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Behaviour when the Cisco AI Defense API is unavailable: 'allow' proceeds without scanning (high availability), 'block' rejects the request (maximum security).<br/>
    /// Default Value: block
    /// </summary>
    public sealed partial class CiscoAIDefenseGuardrailConfigModelOptionalParamsFallbackOnError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}