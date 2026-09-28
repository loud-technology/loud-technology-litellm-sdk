
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// For /v1/realtime sessions: 'warn' speaks the violation message and continues; 'end_session' speaks the message and closes the connection. For guardrail='mcp_security': 'block' rejects the request; 'alert' only logs a warning.
    /// </summary>
    public sealed partial class BaseLitellmParamsOnViolation
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}