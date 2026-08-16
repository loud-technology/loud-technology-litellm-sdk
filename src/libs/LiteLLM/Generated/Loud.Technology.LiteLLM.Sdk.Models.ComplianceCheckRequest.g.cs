
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request payload for compliance check endpoints.<br/>
    /// Mirrors the spend log fields needed for compliance evaluation.
    /// </summary>
    public sealed partial class ComplianceCheckRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_information")]
        public global::System.Collections.Generic.IList<object>? GuardrailInformation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceCheckRequest" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="guardrailInformation"></param>
        /// <param name="model"></param>
        /// <param name="timestamp"></param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComplianceCheckRequest(
            string requestId,
            global::System.Collections.Generic.IList<object>? guardrailInformation,
            string? model,
            string? timestamp,
            string? userId)
        {
            this.GuardrailInformation = guardrailInformation;
            this.Model = model;
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Timestamp = timestamp;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceCheckRequest" /> class.
        /// </summary>
        public ComplianceCheckRequest()
        {
        }

    }
}