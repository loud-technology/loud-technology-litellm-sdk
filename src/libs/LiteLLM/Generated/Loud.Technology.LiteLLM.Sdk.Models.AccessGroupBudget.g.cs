
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessGroupBudget
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BudgetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_budget")]
        public double? SoftBudget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_reset_at")]
        public global::System.DateTime? BudgetResetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupBudget" /> class.
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetResetAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessGroupBudget(
            string budgetId,
            double? maxBudget,
            double? softBudget,
            string? budgetDuration,
            global::System.DateTime? budgetResetAt)
        {
            this.BudgetId = budgetId ?? throw new global::System.ArgumentNullException(nameof(budgetId));
            this.MaxBudget = maxBudget;
            this.SoftBudget = softBudget;
            this.BudgetDuration = budgetDuration;
            this.BudgetResetAt = budgetResetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupBudget" /> class.
        /// </summary>
        public AccessGroupBudget()
        {
        }

    }
}