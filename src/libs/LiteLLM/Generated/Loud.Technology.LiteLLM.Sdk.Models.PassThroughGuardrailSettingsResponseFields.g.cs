
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// JSONPath expressions for output field targeting (post_call). Examples: 'results[*].text', 'output'. If not specified, guardrail runs on entire response payload.
    /// </summary>
    public sealed partial class PassThroughGuardrailSettingsResponseFields
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}