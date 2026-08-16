
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Settings for a specific guardrail on a passthrough endpoint.<br/>
    /// Allows field-level targeting for guardrail execution.
    /// </summary>
    public sealed partial class PassThroughGuardrailSettings
    {
        /// <summary>
        /// JSONPath expressions for input field targeting (pre_call). Examples: 'query', 'documents[*].text', 'messages[*].content'. If not specified, guardrail runs on entire request payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_fields")]
        public global::System.Collections.Generic.IList<string>? RequestFields { get; set; }

        /// <summary>
        /// JSONPath expressions for output field targeting (post_call). Examples: 'results[*].text', 'output'. If not specified, guardrail runs on entire response payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_fields")]
        public global::System.Collections.Generic.IList<string>? ResponseFields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassThroughGuardrailSettings" /> class.
        /// </summary>
        /// <param name="requestFields">
        /// JSONPath expressions for input field targeting (pre_call). Examples: 'query', 'documents[*].text', 'messages[*].content'. If not specified, guardrail runs on entire request payload.
        /// </param>
        /// <param name="responseFields">
        /// JSONPath expressions for output field targeting (post_call). Examples: 'results[*].text', 'output'. If not specified, guardrail runs on entire response payload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PassThroughGuardrailSettings(
            global::System.Collections.Generic.IList<string>? requestFields,
            global::System.Collections.Generic.IList<string>? responseFields)
        {
            this.RequestFields = requestFields;
            this.ResponseFields = responseFields;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassThroughGuardrailSettings" /> class.
        /// </summary>
        public PassThroughGuardrailSettings()
        {
        }

    }
}