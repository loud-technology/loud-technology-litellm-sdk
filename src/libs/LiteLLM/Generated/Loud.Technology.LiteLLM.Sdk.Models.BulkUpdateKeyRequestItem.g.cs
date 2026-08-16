
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Individual key update request item
    /// </summary>
    public sealed partial class BulkUpdateKeyRequestItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateKeyRequestItem" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="budgetId"></param>
        /// <param name="maxBudget"></param>
        /// <param name="teamId"></param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateKeyRequestItem(
            string key,
            string? budgetId,
            double? maxBudget,
            string? teamId,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.BudgetId = budgetId;
            this.MaxBudget = maxBudget;
            this.TeamId = teamId;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateKeyRequestItem" /> class.
        /// </summary>
        public BulkUpdateKeyRequestItem()
        {
        }

    }
}