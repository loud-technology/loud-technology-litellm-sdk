
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageDetailResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failRate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FailRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("time_series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> TimeSeries { get; set; }

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
        /// Initializes a new instance of the <see cref="UsageDetailResponse" /> class.
        /// </summary>
        /// <param name="failRate"></param>
        /// <param name="guardrailId"></param>
        /// <param name="guardrailName"></param>
        /// <param name="provider"></param>
        /// <param name="requestsEvaluated"></param>
        /// <param name="status"></param>
        /// <param name="timeSeries"></param>
        /// <param name="trend"></param>
        /// <param name="type"></param>
        /// <param name="avgLatency"></param>
        /// <param name="avgScore"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageDetailResponse(
            double failRate,
            string guardrailId,
            string guardrailName,
            string provider,
            int requestsEvaluated,
            string status,
            global::System.Collections.Generic.IList<object> timeSeries,
            string trend,
            string type,
            double? avgLatency,
            double? avgScore,
            string? description)
        {
            this.AvgLatency = avgLatency;
            this.AvgScore = avgScore;
            this.Description = description;
            this.FailRate = failRate;
            this.GuardrailId = guardrailId ?? throw new global::System.ArgumentNullException(nameof(guardrailId));
            this.GuardrailName = guardrailName ?? throw new global::System.ArgumentNullException(nameof(guardrailName));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.RequestsEvaluated = requestsEvaluated;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
            this.Trend = trend ?? throw new global::System.ArgumentNullException(nameof(trend));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageDetailResponse" /> class.
        /// </summary>
        public UsageDetailResponse()
        {
        }

    }
}