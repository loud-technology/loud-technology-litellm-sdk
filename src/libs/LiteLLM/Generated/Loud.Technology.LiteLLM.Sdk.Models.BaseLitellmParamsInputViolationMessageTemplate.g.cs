
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Custom message when a guardrail blocks an action. Supports placeholders like {tool_name}, {rule_id}, and {default_message}.
    /// </summary>
    public sealed partial class BaseLitellmParamsInputViolationMessageTemplate
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}