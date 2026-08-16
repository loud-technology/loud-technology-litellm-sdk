
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for a single provider's budget settings
    /// </summary>
    public sealed partial class ProviderBudgetResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_limit")]
        public double? BudgetLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_period")]
        public string? TimePeriod { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_reset_at")]
        public string? BudgetResetAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderBudgetResponseObject" /> class.
        /// </summary>
        /// <param name="budgetLimit"></param>
        /// <param name="timePeriod"></param>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
        /// <param name="budgetResetAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderBudgetResponseObject(
            double? budgetLimit,
            string? timePeriod,
            double? spend,
            string? budgetResetAt)
        {
            this.BudgetLimit = budgetLimit;
            this.TimePeriod = timePeriod;
            this.Spend = spend;
            this.BudgetResetAt = budgetResetAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderBudgetResponseObject" /> class.
        /// </summary>
        public ProviderBudgetResponseObject()
        {
        }

    }
}