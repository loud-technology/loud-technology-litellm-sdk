
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Header names to forward from the client request to the guardrail (e.g. x-request-id). Only these headers' values are sent; others may be omitted or sent as [present]. Used by generic_guardrail_api (similar to MCP extra_headers).
    /// </summary>
    public sealed partial class BaseLitellmParamsInputExtraHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}