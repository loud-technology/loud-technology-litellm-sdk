
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for testing custom code guardrails.
    /// </summary>
    public sealed partial class TestCustomCodeGuardrailRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomCode { get; set; }

        /// <summary>
        /// Default Value: request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public string? InputType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_data")]
        public object? RequestData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object TestInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCustomCodeGuardrailRequest" /> class.
        /// </summary>
        /// <param name="customCode"></param>
        /// <param name="testInput"></param>
        /// <param name="inputType">
        /// Default Value: request
        /// </param>
        /// <param name="requestData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestCustomCodeGuardrailRequest(
            string customCode,
            object testInput,
            string? inputType,
            object? requestData)
        {
            this.CustomCode = customCode ?? throw new global::System.ArgumentNullException(nameof(customCode));
            this.InputType = inputType;
            this.RequestData = requestData;
            this.TestInput = testInput ?? throw new global::System.ArgumentNullException(nameof(testInput));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestCustomCodeGuardrailRequest" /> class.
        /// </summary>
        public TestCustomCodeGuardrailRequest()
        {
        }

    }
}