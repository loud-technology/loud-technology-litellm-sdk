
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LiteLLMEndUserTable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Blocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_model_region")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMEndUserTableAllowedModelRegion2? AllowedModelRegion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model")]
        public string? DefaultModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_id")]
        public string? BudgetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_budget_table")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTable? LitellmBudgetTable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission_id")]
        public string? ObjectPermissionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_permission")]
        public global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? ObjectPermission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMEndUserTable" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="blocked"></param>
        /// <param name="alias"></param>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
        /// <param name="allowedModelRegion"></param>
        /// <param name="defaultModel"></param>
        /// <param name="budgetId"></param>
        /// <param name="litellmBudgetTable"></param>
        /// <param name="objectPermissionId"></param>
        /// <param name="objectPermission"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMEndUserTable(
            string userId,
            bool blocked,
            string? alias,
            double? spend,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMEndUserTableAllowedModelRegion2? allowedModelRegion,
            string? defaultModel,
            string? budgetId,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMBudgetTable? litellmBudgetTable,
            string? objectPermissionId,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionTable? objectPermission)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Blocked = blocked;
            this.Alias = alias;
            this.Spend = spend;
            this.AllowedModelRegion = allowedModelRegion;
            this.DefaultModel = defaultModel;
            this.BudgetId = budgetId;
            this.LitellmBudgetTable = litellmBudgetTable;
            this.ObjectPermissionId = objectPermissionId;
            this.ObjectPermission = objectPermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMEndUserTable" /> class.
        /// </summary>
        public LiteLLMEndUserTable()
        {
        }

    }
}