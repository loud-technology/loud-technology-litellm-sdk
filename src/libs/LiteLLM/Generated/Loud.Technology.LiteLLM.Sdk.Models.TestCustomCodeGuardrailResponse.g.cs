
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for testing custom code guardrails.
    /// </summary>
    public sealed partial class TestCustomCodeGuardrailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCustomCodeGuardrailResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="error"></param>
        /// <param name="errorType"></param>
        /// <param name="result"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCustomCodeGuardrailResponse(
            bool success,
            string? error,
            string? errorType,
            object? result)
        {
            this.Error = error;
            this.ErrorType = errorType;
            this.Result = result;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCustomCodeGuardrailResponse" /> class.
        /// </summary>
        public TestCustomCodeGuardrailResponse()
        {
        }

    }
}