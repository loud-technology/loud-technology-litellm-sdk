
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailySpendMetadata
    {
        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend")]
        public double? TotalSpend { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_prompt_tokens")]
        public int? TotalPromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_completion_tokens")]
        public int? TotalCompletionTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_api_requests")]
        public int? TotalApiRequests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_successful_requests")]
        public int? TotalSuccessfulRequests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_failed_requests")]
        public int? TotalFailedRequests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cache_read_input_tokens")]
        public int? TotalCacheReadInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cache_creation_input_tokens")]
        public int? TotalCacheCreationInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_compression_saved_tokens")]
        public int? TotalCompressionSavedTokens { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_compression_savings_spend")]
        public double? TotalCompressionSavingsSpend { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_prompt_caching_savings_spend")]
        public double? TotalPromptCachingSavingsSpend { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_pages")]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailySpendMetadata" /> class.
        /// </summary>
        /// <param name="totalSpend">
        /// Default Value: 0F
        /// </param>
        /// <param name="totalPromptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCompletionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalApiRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="totalSuccessfulRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="totalFailedRequests">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCacheReadInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCacheCreationInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCompressionSavedTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalCompressionSavingsSpend">
        /// Default Value: 0F
        /// </param>
        /// <param name="totalPromptCachingSavingsSpend">
        /// Default Value: 0F
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="totalPages">
        /// Default Value: 1
        /// </param>
        /// <param name="hasMore">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailySpendMetadata(
            double? totalSpend,
            int? totalPromptTokens,
            int? totalCompletionTokens,
            int? totalTokens,
            int? totalApiRequests,
            int? totalSuccessfulRequests,
            int? totalFailedRequests,
            int? totalCacheReadInputTokens,
            int? totalCacheCreationInputTokens,
            int? totalCompressionSavedTokens,
            double? totalCompressionSavingsSpend,
            double? totalPromptCachingSavingsSpend,
            int? page,
            int? totalPages,
            bool? hasMore)
        {
            this.TotalSpend = totalSpend;
            this.TotalPromptTokens = totalPromptTokens;
            this.TotalCompletionTokens = totalCompletionTokens;
            this.TotalTokens = totalTokens;
            this.TotalApiRequests = totalApiRequests;
            this.TotalSuccessfulRequests = totalSuccessfulRequests;
            this.TotalFailedRequests = totalFailedRequests;
            this.TotalCacheReadInputTokens = totalCacheReadInputTokens;
            this.TotalCacheCreationInputTokens = totalCacheCreationInputTokens;
            this.TotalCompressionSavedTokens = totalCompressionSavedTokens;
            this.TotalCompressionSavingsSpend = totalCompressionSavingsSpend;
            this.TotalPromptCachingSavingsSpend = totalPromptCachingSavingsSpend;
            this.Page = page;
            this.TotalPages = totalPages;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailySpendMetadata" /> class.
        /// </summary>
        public DailySpendMetadata()
        {
        }

    }
}