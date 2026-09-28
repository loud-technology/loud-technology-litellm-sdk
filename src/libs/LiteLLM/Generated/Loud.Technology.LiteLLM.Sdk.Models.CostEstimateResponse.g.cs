
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response body for /cost/estimate endpoint.
    /// </summary>
    public sealed partial class CostEstimateResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_requests_per_day")]
        public int? NumRequestsPerDay { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_requests_per_month")]
        public int? NumRequestsPerMonth { get; set; }

        /// <summary>
        /// Total cost per request (includes margin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CostPerRequest { get; set; }

        /// <summary>
        /// Input token cost per request (before margin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double InputCostPerRequest { get; set; }

        /// <summary>
        /// Output token cost per request (before margin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double OutputCostPerRequest { get; set; }

        /// <summary>
        /// Margin/fee added per request<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin_cost_per_request")]
        public double? MarginCostPerRequest { get; set; }

        /// <summary>
        /// Cache-read share of input_cost_per_request<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_cost_per_request")]
        public double? CacheReadCostPerRequest { get; set; }

        /// <summary>
        /// Cache-write share of input_cost_per_request<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_cost_per_request")]
        public double? CacheCreationCostPerRequest { get; set; }

        /// <summary>
        /// Reasoning share of output_cost_per_request<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_cost_per_request")]
        public double? ReasoningCostPerRequest { get; set; }

        /// <summary>
        /// Total daily cost (includes margin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_cost")]
        public double? DailyCost { get; set; }

        /// <summary>
        /// Daily input token cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_input_cost")]
        public double? DailyInputCost { get; set; }

        /// <summary>
        /// Daily output token cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_output_cost")]
        public double? DailyOutputCost { get; set; }

        /// <summary>
        /// Daily margin/fee
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_margin_cost")]
        public double? DailyMarginCost { get; set; }

        /// <summary>
        /// Cache-read share of daily_input_cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_cache_read_cost")]
        public double? DailyCacheReadCost { get; set; }

        /// <summary>
        /// Cache-write share of daily_input_cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_cache_creation_cost")]
        public double? DailyCacheCreationCost { get; set; }

        /// <summary>
        /// Reasoning share of daily_output_cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_reasoning_cost")]
        public double? DailyReasoningCost { get; set; }

        /// <summary>
        /// Total monthly cost (includes margin)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_cost")]
        public double? MonthlyCost { get; set; }

        /// <summary>
        /// Monthly input token cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_input_cost")]
        public double? MonthlyInputCost { get; set; }

        /// <summary>
        /// Monthly output token cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_output_cost")]
        public double? MonthlyOutputCost { get; set; }

        /// <summary>
        /// Monthly margin/fee
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_margin_cost")]
        public double? MonthlyMarginCost { get; set; }

        /// <summary>
        /// Cache-read share of monthly_input_cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_cache_read_cost")]
        public double? MonthlyCacheReadCost { get; set; }

        /// <summary>
        /// Cache-write share of monthly_input_cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_cache_creation_cost")]
        public double? MonthlyCacheCreationCost { get; set; }

        /// <summary>
        /// Reasoning share of monthly_output_cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_reasoning_cost")]
        public double? MonthlyReasoningCost { get; set; }

        /// <summary>
        /// Rate billed per input token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token")]
        public double? InputCostPerToken { get; set; }

        /// <summary>
        /// Rate billed per output token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token")]
        public double? OutputCostPerToken { get; set; }

        /// <summary>
        /// Rate billed per cache-read token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost")]
        public double? CacheReadInputTokenCost { get; set; }

        /// <summary>
        /// Rate billed per cache-write token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost")]
        public double? CacheCreationInputTokenCost { get; set; }

        /// <summary>
        /// Rate billed per reasoning token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_reasoning_token")]
        public double? OutputCostPerReasoningToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostEstimateResponse" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="costPerRequest">
        /// Total cost per request (includes margin)
        /// </param>
        /// <param name="inputCostPerRequest">
        /// Input token cost per request (before margin)
        /// </param>
        /// <param name="outputCostPerRequest">
        /// Output token cost per request (before margin)
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="reasoningTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="numRequestsPerDay"></param>
        /// <param name="numRequestsPerMonth"></param>
        /// <param name="marginCostPerRequest">
        /// Margin/fee added per request<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="cacheReadCostPerRequest">
        /// Cache-read share of input_cost_per_request<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="cacheCreationCostPerRequest">
        /// Cache-write share of input_cost_per_request<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="reasoningCostPerRequest">
        /// Reasoning share of output_cost_per_request<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="dailyCost">
        /// Total daily cost (includes margin)
        /// </param>
        /// <param name="dailyInputCost">
        /// Daily input token cost
        /// </param>
        /// <param name="dailyOutputCost">
        /// Daily output token cost
        /// </param>
        /// <param name="dailyMarginCost">
        /// Daily margin/fee
        /// </param>
        /// <param name="dailyCacheReadCost">
        /// Cache-read share of daily_input_cost
        /// </param>
        /// <param name="dailyCacheCreationCost">
        /// Cache-write share of daily_input_cost
        /// </param>
        /// <param name="dailyReasoningCost">
        /// Reasoning share of daily_output_cost
        /// </param>
        /// <param name="monthlyCost">
        /// Total monthly cost (includes margin)
        /// </param>
        /// <param name="monthlyInputCost">
        /// Monthly input token cost
        /// </param>
        /// <param name="monthlyOutputCost">
        /// Monthly output token cost
        /// </param>
        /// <param name="monthlyMarginCost">
        /// Monthly margin/fee
        /// </param>
        /// <param name="monthlyCacheReadCost">
        /// Cache-read share of monthly_input_cost
        /// </param>
        /// <param name="monthlyCacheCreationCost">
        /// Cache-write share of monthly_input_cost
        /// </param>
        /// <param name="monthlyReasoningCost">
        /// Reasoning share of monthly_output_cost
        /// </param>
        /// <param name="inputCostPerToken">
        /// Rate billed per input token
        /// </param>
        /// <param name="outputCostPerToken">
        /// Rate billed per output token
        /// </param>
        /// <param name="cacheReadInputTokenCost">
        /// Rate billed per cache-read token
        /// </param>
        /// <param name="cacheCreationInputTokenCost">
        /// Rate billed per cache-write token
        /// </param>
        /// <param name="outputCostPerReasoningToken">
        /// Rate billed per reasoning token
        /// </param>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostEstimateResponse(
            string model,
            int inputTokens,
            int outputTokens,
            double costPerRequest,
            double inputCostPerRequest,
            double outputCostPerRequest,
            int? cacheReadInputTokens,
            int? cacheCreationInputTokens,
            int? reasoningTokens,
            int? numRequestsPerDay,
            int? numRequestsPerMonth,
            double? marginCostPerRequest,
            double? cacheReadCostPerRequest,
            double? cacheCreationCostPerRequest,
            double? reasoningCostPerRequest,
            double? dailyCost,
            double? dailyInputCost,
            double? dailyOutputCost,
            double? dailyMarginCost,
            double? dailyCacheReadCost,
            double? dailyCacheCreationCost,
            double? dailyReasoningCost,
            double? monthlyCost,
            double? monthlyInputCost,
            double? monthlyOutputCost,
            double? monthlyMarginCost,
            double? monthlyCacheReadCost,
            double? monthlyCacheCreationCost,
            double? monthlyReasoningCost,
            double? inputCostPerToken,
            double? outputCostPerToken,
            double? cacheReadInputTokenCost,
            double? cacheCreationInputTokenCost,
            double? outputCostPerReasoningToken,
            string? provider)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.ReasoningTokens = reasoningTokens;
            this.NumRequestsPerDay = numRequestsPerDay;
            this.NumRequestsPerMonth = numRequestsPerMonth;
            this.CostPerRequest = costPerRequest;
            this.InputCostPerRequest = inputCostPerRequest;
            this.OutputCostPerRequest = outputCostPerRequest;
            this.MarginCostPerRequest = marginCostPerRequest;
            this.CacheReadCostPerRequest = cacheReadCostPerRequest;
            this.CacheCreationCostPerRequest = cacheCreationCostPerRequest;
            this.ReasoningCostPerRequest = reasoningCostPerRequest;
            this.DailyCost = dailyCost;
            this.DailyInputCost = dailyInputCost;
            this.DailyOutputCost = dailyOutputCost;
            this.DailyMarginCost = dailyMarginCost;
            this.DailyCacheReadCost = dailyCacheReadCost;
            this.DailyCacheCreationCost = dailyCacheCreationCost;
            this.DailyReasoningCost = dailyReasoningCost;
            this.MonthlyCost = monthlyCost;
            this.MonthlyInputCost = monthlyInputCost;
            this.MonthlyOutputCost = monthlyOutputCost;
            this.MonthlyMarginCost = monthlyMarginCost;
            this.MonthlyCacheReadCost = monthlyCacheReadCost;
            this.MonthlyCacheCreationCost = monthlyCacheCreationCost;
            this.MonthlyReasoningCost = monthlyReasoningCost;
            this.InputCostPerToken = inputCostPerToken;
            this.OutputCostPerToken = outputCostPerToken;
            this.CacheReadInputTokenCost = cacheReadInputTokenCost;
            this.CacheCreationInputTokenCost = cacheCreationInputTokenCost;
            this.OutputCostPerReasoningToken = outputCostPerReasoningToken;
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostEstimateResponse" /> class.
        /// </summary>
        public CostEstimateResponse()
        {
        }

    }
}