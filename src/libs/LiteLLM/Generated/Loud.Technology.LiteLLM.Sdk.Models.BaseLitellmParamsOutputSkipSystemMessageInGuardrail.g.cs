
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// When True, unified guardrails skip system-role messages when building evaluation inputs (texts and structured_messages). When False, system messages are included even if litellm_settings sets a global skip. When None, use the global litellm.skip_system_message_in_guardrail setting.
    /// </summary>
    public sealed partial class BaseLitellmParamsOutputSkipSystemMessageInGuardrail
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}