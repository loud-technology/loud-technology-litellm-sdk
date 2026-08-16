
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenCountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenizerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_response")]
        public object? OriginalResponse { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCountResponse" /> class.
        /// </summary>
        /// <param name="totalTokens"></param>
        /// <param name="requestModel"></param>
        /// <param name="modelUsed"></param>
        /// <param name="tokenizerType"></param>
        /// <param name="originalResponse"></param>
        /// <param name="error">
        /// Default Value: false
        /// </param>
        /// <param name="errorMessage"></param>
        /// <param name="statusCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenCountResponse(
            int totalTokens,
            string requestModel,
            string modelUsed,
            string tokenizerType,
            object? originalResponse,
            bool? error,
            string? errorMessage,
            int? statusCode)
        {
            this.TotalTokens = totalTokens;
            this.RequestModel = requestModel ?? throw new global::System.ArgumentNullException(nameof(requestModel));
            this.ModelUsed = modelUsed ?? throw new global::System.ArgumentNullException(nameof(modelUsed));
            this.TokenizerType = tokenizerType ?? throw new global::System.ArgumentNullException(nameof(tokenizerType));
            this.OriginalResponse = originalResponse;
            this.Error = error;
            this.ErrorMessage = errorMessage;
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCountResponse" /> class.
        /// </summary>
        public TokenCountResponse()
        {
        }

    }
}