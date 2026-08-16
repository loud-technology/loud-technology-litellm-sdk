
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Allowlist of bulk-broadcastable fields for /team/key/bulk_update; `extra="forbid"` blocks RBAC/ownership/scope mutations even by team admins.
    /// </summary>
    public sealed partial class KeyUpdateFields
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_limits")]
        public global::System.Collections.Generic.IList<object>? BudgetLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_max_budget")]
        public object? ModelMaxBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit")]
        public int? TpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit")]
        public int? RpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_tpm_limit")]
        public object? ModelTpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_rpm_limit")]
        public object? ModelRpmLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_requests")]
        public int? MaxParallelRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit_type")]
        public global::Loud.Technology.LiteLLM.Sdk.KeyUpdateFieldsRpmLimitType2? RpmLimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit_type")]
        public global::Loud.Technology.LiteLLM.Sdk.KeyUpdateFieldsTpmLimitType2? TpmLimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temp_budget_increase")]
        public double? TempBudgetIncrease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temp_budget_expiry")]
        public global::System.DateTime? TempBudgetExpiry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyUpdateFields" /> class.
        /// </summary>
        /// <param name="maxBudget"></param>
        /// <param name="budgetId"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetLimits"></param>
        /// <param name="modelMaxBudget"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="rpmLimitType"></param>
        /// <param name="tpmLimitType"></param>
        /// <param name="tempBudgetIncrease"></param>
        /// <param name="tempBudgetExpiry"></param>
        /// <param name="duration"></param>
        /// <param name="tags"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyUpdateFields(
            double? maxBudget,
            string? budgetId,
            string? budgetDuration,
            global::System.Collections.Generic.IList<object>? budgetLimits,
            object? modelMaxBudget,
            int? tpmLimit,
            int? rpmLimit,
            object? modelTpmLimit,
            object? modelRpmLimit,
            int? maxParallelRequests,
            global::Loud.Technology.LiteLLM.Sdk.KeyUpdateFieldsRpmLimitType2? rpmLimitType,
            global::Loud.Technology.LiteLLM.Sdk.KeyUpdateFieldsTpmLimitType2? tpmLimitType,
            double? tempBudgetIncrease,
            global::System.DateTime? tempBudgetExpiry,
            string? duration,
            global::System.Collections.Generic.IList<string>? tags,
            object? metadata)
        {
            this.MaxBudget = maxBudget;
            this.BudgetId = budgetId;
            this.BudgetDuration = budgetDuration;
            this.BudgetLimits = budgetLimits;
            this.ModelMaxBudget = modelMaxBudget;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.ModelTpmLimit = modelTpmLimit;
            this.ModelRpmLimit = modelRpmLimit;
            this.MaxParallelRequests = maxParallelRequests;
            this.RpmLimitType = rpmLimitType;
            this.TpmLimitType = tpmLimitType;
            this.TempBudgetIncrease = tempBudgetIncrease;
            this.TempBudgetExpiry = tempBudgetExpiry;
            this.Duration = duration;
            this.Tags = tags;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyUpdateFields" /> class.
        /// </summary>
        public KeyUpdateFields()
        {
        }

    }
}