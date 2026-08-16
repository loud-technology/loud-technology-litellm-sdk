
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Summary metrics for a tag
    /// </summary>
    public sealed partial class TagSummaryMetrics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unique_users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UniqueUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SuccessfulRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalSpend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagSummaryMetrics" /> class.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="uniqueUsers"></param>
        /// <param name="totalRequests"></param>
        /// <param name="successfulRequests"></param>
        /// <param name="failedRequests"></param>
        /// <param name="totalTokens"></param>
        /// <param name="totalSpend"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagSummaryMetrics(
            string tag,
            int uniqueUsers,
            int totalRequests,
            int successfulRequests,
            int failedRequests,
            int totalTokens,
            double totalSpend)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.UniqueUsers = uniqueUsers;
            this.TotalRequests = totalRequests;
            this.SuccessfulRequests = successfulRequests;
            this.FailedRequests = failedRequests;
            this.TotalTokens = totalTokens;
            this.TotalSpend = totalSpend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagSummaryMetrics" /> class.
        /// </summary>
        public TagSummaryMetrics()
        {
        }

    }
}