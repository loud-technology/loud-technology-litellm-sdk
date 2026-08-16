
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransformRequestBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.CallTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.CallTypes CallType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object RequestBody { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformRequestBody" /> class.
        /// </summary>
        /// <param name="callType"></param>
        /// <param name="requestBody"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransformRequestBody(
            global::Loud.Technology.LiteLLM.Sdk.CallTypes callType,
            object requestBody)
        {
            this.CallType = callType;
            this.RequestBody = requestBody ?? throw new global::System.ArgumentNullException(nameof(requestBody));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransformRequestBody" /> class.
        /// </summary>
        public TransformRequestBody()
        {
        }

    }
}