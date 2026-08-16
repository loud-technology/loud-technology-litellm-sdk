
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageOverviewRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgLatency")]
        public double? AvgLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgScore")]
        public double? AvgScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FailRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestsEvaluated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestsEvaluated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Trend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOverviewRow" /> class.
        /// </summary>
        /// <param name="failRate"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="requestsEvaluated"></param>
        /// <param name="status"></param>
        /// <param name="trend"></param>
        /// <param name="type"></param>
        /// <param name="avgLatency"></param>
        /// <param name="avgScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageOverviewRow(
            double failRate,
            string id,
            string name,
            string provider,
            int requestsEvaluated,
            string status,
            string trend,
            string type,
            double? avgLatency,
            double? avgScore)
        {
            this.AvgLatency = avgLatency;
            this.AvgScore = avgScore;
            this.FailRate = failRate;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.RequestsEvaluated = requestsEvaluated;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Trend = trend ?? throw new global::System.ArgumentNullException(nameof(trend));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageOverviewRow" /> class.
        /// </summary>
        public UsageOverviewRow()
        {
        }

    }
}