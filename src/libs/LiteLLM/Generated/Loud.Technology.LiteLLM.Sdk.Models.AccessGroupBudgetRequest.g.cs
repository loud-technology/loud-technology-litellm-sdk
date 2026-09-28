
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessGroupBudgetRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupBudgetRequest" /> class.
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="budgetDuration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessGroupBudgetRequest(
            string? budgetId,
            double? maxBudget,
            double? softBudget,
            string? budgetDuration)
        {
            this.BudgetId = budgetId;
            this.MaxBudget = maxBudget;
            this.SoftBudget = softBudget;
            this.BudgetDuration = budgetDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessGroupBudgetRequest" /> class.
        /// </summary>
        public AccessGroupBudgetRequest()
        {
        }

    }
}