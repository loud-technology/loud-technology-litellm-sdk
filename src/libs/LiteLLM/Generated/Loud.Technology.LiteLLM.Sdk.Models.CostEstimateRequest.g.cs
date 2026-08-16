
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for /cost/estimate endpoint.
    /// </summary>
    public sealed partial class CostEstimateRequest
    {
        /// <summary>
        /// Model name (from /model_group/info)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Expected input tokens per request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Expected output tokens per request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Number of requests per day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_requests_per_day")]
        public int? NumRequestsPerDay { get; set; }

        /// <summary>
        /// Number of requests per month
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_requests_per_month")]
        public int? NumRequestsPerMonth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostEstimateRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Model name (from /model_group/info)
        /// </param>
        /// <param name="inputTokens">
        /// Expected input tokens per request
        /// </param>
        /// <param name="outputTokens">
        /// Expected output tokens per request
        /// </param>
        /// <param name="numRequestsPerDay">
        /// Number of requests per day
        /// </param>
        /// <param name="numRequestsPerMonth">
        /// Number of requests per month
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostEstimateRequest(
            string model,
            int inputTokens,
            int outputTokens,
            int? numRequestsPerDay,
            int? numRequestsPerMonth)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.NumRequestsPerDay = numRequestsPerDay;
            this.NumRequestsPerMonth = numRequestsPerMonth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostEstimateRequest" /> class.
        /// </summary>
        public CostEstimateRequest()
        {
        }

    }
}