
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// If True, replaces sensitive content with anonymized version when only PII/PCI/secrets are detected. Only applies in blocking mode. Defaults to False if not provided
    /// </summary>
    public sealed partial class LitellmParamsAnonymizeInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}