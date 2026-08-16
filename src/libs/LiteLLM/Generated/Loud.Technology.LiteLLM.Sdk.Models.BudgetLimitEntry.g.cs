
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A single budget window with its own limit and independent reset schedule.
    /// </summary>
    public sealed partial class BudgetLimitEntry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BudgetDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MaxBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_at")]
        public global::System.DateTime? ResetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLimitEntry" /> class.
        /// </summary>
        /// <param name="budgetDuration"></param>
        /// <param name="maxBudget"></param>
        /// <param name="resetAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BudgetLimitEntry(
            string budgetDuration,
            double maxBudget,
            global::System.DateTime? resetAt)
        {
            this.BudgetDuration = budgetDuration ?? throw new global::System.ArgumentNullException(nameof(budgetDuration));
            this.MaxBudget = maxBudget;
            this.ResetAt = resetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLimitEntry" /> class.
        /// </summary>
        public BudgetLimitEntry()
        {
        }

    }
}