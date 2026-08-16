
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// JSONPath expressions for input field targeting (pre_call). Examples: 'query', 'documents[*].text', 'messages[*].content'. If not specified, guardrail runs on entire request payload.
    /// </summary>
    public sealed partial class PassThroughGuardrailSettingsRequestFields
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}