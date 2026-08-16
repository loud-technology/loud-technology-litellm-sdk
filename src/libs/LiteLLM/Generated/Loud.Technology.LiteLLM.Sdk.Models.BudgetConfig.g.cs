
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BudgetConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetConfig" /> class.
        /// </summary>
        /// <param name="maxBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BudgetConfig(
            double? maxBudget,
            string? budgetDuration,
            int? tpmLimit,
            int? rpmLimit)
        {
            this.MaxBudget = maxBudget;
            this.BudgetDuration = budgetDuration;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetConfig" /> class.
        /// </summary>
        public BudgetConfig()
        {
        }

    }
}