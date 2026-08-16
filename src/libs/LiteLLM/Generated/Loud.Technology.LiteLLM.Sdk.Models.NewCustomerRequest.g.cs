
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Create a new customer, allocate a budget to them
    /// </summary>
    public sealed partial class NewCustomerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        /// Requests will fail if this budget (in USD) is exceeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// Requests will NOT fail if this is exceeded. Will fire alerting though.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_budget")]
        public double? SoftBudget { get; set; }

        /// <summary>
        /// Max concurrent requests allowed for this budget id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_parallel_requests")]
        public int? MaxParallelRequests { get; set; }

        /// <summary>
        /// Max tokens per minute, allowed for this budget id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit")]
        public int? TpmLimit { get; set; }

        /// <summary>
        /// Max requests per minute, allowed for this budget id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit")]
        public int? RpmLimit { get; set; }

        /// <summary>
        /// Max duration budget should be set for (e.g. '1hr', '1d', '28d')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// Max budget for each model (e.g. {'gpt-4o': {'max_budget': '0.0000001', 'budget_duration': '1d', 'tpm_limit': 1000, 'rpm_limit': 1000}})
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_max_budget")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.BudgetConfig>? ModelMaxBudget { get; set; }

        /// <summary>
        /// Datetime when the budget is reset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_reset_at")]
        public global::System.DateTime? BudgetResetAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_model_region")]
        public global::Loud.Technology.LiteLLM.Sdk.NewCustomerRequestAllowedModelRegion2? AllowedModelRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model")]
        public string? DefaultModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? ObjectPermission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomerRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="budgetId"></param>
        /// <param name="maxBudget">
        /// Requests will fail if this budget (in USD) is exceeded.
        /// </param>
        /// <param name="softBudget">
        /// Requests will NOT fail if this is exceeded. Will fire alerting though.
        /// </param>
        /// <param name="maxParallelRequests">
        /// Max concurrent requests allowed for this budget id.
        /// </param>
        /// <param name="tpmLimit">
        /// Max tokens per minute, allowed for this budget id.
        /// </param>
        /// <param name="rpmLimit">
        /// Max requests per minute, allowed for this budget id.
        /// </param>
        /// <param name="budgetDuration">
        /// Max duration budget should be set for (e.g. '1hr', '1d', '28d')
        /// </param>
        /// <param name="modelMaxBudget">
        /// Max budget for each model (e.g. {'gpt-4o': {'max_budget': '0.0000001', 'budget_duration': '1d', 'tpm_limit': 1000, 'rpm_limit': 1000}})
        /// </param>
        /// <param name="budgetResetAt">
        /// Datetime when the budget is reset
        /// </param>
        /// <param name="alias"></param>
        /// <param name="blocked">
        /// Default Value: false
        /// </param>
        /// <param name="spend"></param>
        /// <param name="allowedModelRegion"></param>
        /// <param name="defaultModel"></param>
        /// <param name="objectPermission"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NewCustomerRequest(
            string userId,
            string? budgetId,
            double? maxBudget,
            double? softBudget,
            int? maxParallelRequests,
            int? tpmLimit,
            int? rpmLimit,
            string? budgetDuration,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.BudgetConfig>? modelMaxBudget,
            global::System.DateTime? budgetResetAt,
            string? alias,
            bool? blocked,
            double? spend,
            global::Loud.Technology.LiteLLM.Sdk.NewCustomerRequestAllowedModelRegion2? allowedModelRegion,
            string? defaultModel,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission)
        {
            this.BudgetId = budgetId;
            this.MaxBudget = maxBudget;
            this.SoftBudget = softBudget;
            this.MaxParallelRequests = maxParallelRequests;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.BudgetDuration = budgetDuration;
            this.ModelMaxBudget = modelMaxBudget;
            this.BudgetResetAt = budgetResetAt;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Alias = alias;
            this.Blocked = blocked;
            this.Spend = spend;
            this.AllowedModelRegion = allowedModelRegion;
            this.DefaultModel = defaultModel;
            this.ObjectPermission = objectPermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewCustomerRequest" /> class.
        /// </summary>
        public NewCustomerRequest()
        {
        }

    }
}