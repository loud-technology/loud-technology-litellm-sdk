
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Update a Customer, use this to update customer budgets etc
    /// </summary>
    public sealed partial class UpdateCustomerRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_model_region")]
        public global::Loud.Technology.LiteLLM.Sdk.UpdateCustomerRequestAllowedModelRegion2? AllowedModelRegion { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="alias"></param>
        /// <param name="blocked">
        /// Default Value: false
        /// </param>
        /// <param name="maxBudget"></param>
        /// <param name="budgetId"></param>
        /// <param name="allowedModelRegion"></param>
        /// <param name="defaultModel"></param>
        /// <param name="objectPermission"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomerRequest(
            string userId,
            string? alias,
            bool? blocked,
            double? maxBudget,
            string? budgetId,
            global::Loud.Technology.LiteLLM.Sdk.UpdateCustomerRequestAllowedModelRegion2? allowedModelRegion,
            string? defaultModel,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Alias = alias;
            this.Blocked = blocked;
            this.MaxBudget = maxBudget;
            this.BudgetId = budgetId;
            this.AllowedModelRegion = allowedModelRegion;
            this.DefaultModel = defaultModel;
            this.ObjectPermission = objectPermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomerRequest" /> class.
        /// </summary>
        public UpdateCustomerRequest()
        {
        }

    }
}