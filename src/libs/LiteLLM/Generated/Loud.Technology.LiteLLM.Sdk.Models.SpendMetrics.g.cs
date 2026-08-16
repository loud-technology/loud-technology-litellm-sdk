
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SpendMetrics
    {
        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression_saved_tokens")]
        public int? CompressionSavedTokens { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression_savings_spend")]
        public double? CompressionSavingsSpend { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_caching_savings_spend")]
        public double? PromptCachingSavingsSpend { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_requests")]
        public int? SuccessfulRequests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_requests")]
        public int? FailedRequests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_requests")]
        public int? ApiRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendMetrics" /> class.
        /// </summary>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
        /// <param name="promptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="completionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="compressionSavedTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="compressionSavingsSpend">
        /// Default Value: 0F
        /// </param>
        /// <param name="promptCachingSavingsSpend">
        /// Default Value: 0F
        /// </param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="successfulRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="failedRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="apiRequests">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendMetrics(
            double? spend,
            int? promptTokens,
            int? completionTokens,
            int? cacheReadInputTokens,
            int? cacheCreationInputTokens,
            int? compressionSavedTokens,
            double? compressionSavingsSpend,
            double? promptCachingSavingsSpend,
            int? totalTokens,
            int? successfulRequests,
            int? failedRequests,
            int? apiRequests)
        {
            this.Spend = spend;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CompressionSavedTokens = compressionSavedTokens;
            this.CompressionSavingsSpend = compressionSavingsSpend;
            this.PromptCachingSavingsSpend = promptCachingSavingsSpend;
            this.TotalTokens = totalTokens;
            this.SuccessfulRequests = successfulRequests;
            this.FailedRequests = failedRequests;
            this.ApiRequests = apiRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendMetrics" /> class.
        /// </summary>
        public SpendMetrics()
        {
        }

    }
}