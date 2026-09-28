
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token")]
        public double? InputCostPerToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token")]
        public double? OutputCostPerToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_character")]
        public double? InputCostPerCharacter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_character")]
        public double? OutputCostPerCharacter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost")]
        public double? CacheReadInputTokenCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost")]
        public double? CacheCreationInputTokenCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiered_pricing")]
        public global::System.Collections.Generic.IList<object>? TieredPricing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_model")]
        public bool? DbModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public global::Loud.Technology.LiteLLM.Sdk.ModelInfoTier2? Tier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_public_model_name")]
        public string? TeamPublicModelName { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member_auto_router")]
        public bool? MemberAutoRouter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_windows")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ModelAccessWindow>? AccessWindows { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ptu_count")]
        public int? PtuCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_ptu_per_hour")]
        public double? CostPerPtuPerHour { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ptu_effective_from")]
        public global::System.DateTime? PtuEffectiveFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ptu_effective_to")]
        public global::System.DateTime? PtuEffectiveTo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_fail_open")]
        public bool? AllowFailOpen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_tag_filtering")]
        public bool? EnableTagFiltering { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_router_model")]
        public bool? InternalRouterModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="inputCostPerToken"></param>
        /// <param name="outputCostPerToken"></param>
        /// <param name="inputCostPerCharacter"></param>
        /// <param name="outputCostPerCharacter"></param>
        /// <param name="cacheReadInputTokenCost"></param>
        /// <param name="cacheCreationInputTokenCost"></param>
        /// <param name="tieredPricing"></param>
        /// <param name="id"></param>
        /// <param name="dbModel">
        /// Default Value: false
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="baseModel"></param>
        /// <param name="tier"></param>
        /// <param name="teamId"></param>
        /// <param name="teamPublicModelName"></param>
        /// <param name="memberAutoRouter">
        /// Default Value: false
        /// </param>
        /// <param name="blocked"></param>
        /// <param name="accessWindows"></param>
        /// <param name="ptuCount"></param>
        /// <param name="costPerPtuPerHour"></param>
        /// <param name="ptuEffectiveFrom"></param>
        /// <param name="ptuEffectiveTo"></param>
        /// <param name="allowFailOpen"></param>
        /// <param name="enableTagFiltering"></param>
        /// <param name="internalRouterModel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInfo(
            double? inputCostPerToken,
            double? outputCostPerToken,
            double? inputCostPerCharacter,
            double? outputCostPerCharacter,
            double? cacheReadInputTokenCost,
            double? cacheCreationInputTokenCost,
            global::System.Collections.Generic.IList<object>? tieredPricing,
            string? id,
            bool? dbModel,
            global::System.DateTime? updatedAt,
            string? updatedBy,
            global::System.DateTime? createdAt,
            string? createdBy,
            string? baseModel,
            global::Loud.Technology.LiteLLM.Sdk.ModelInfoTier2? tier,
            string? teamId,
            string? teamPublicModelName,
            bool? memberAutoRouter,
            bool? blocked,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ModelAccessWindow>? accessWindows,
            int? ptuCount,
            double? costPerPtuPerHour,
            global::System.DateTime? ptuEffectiveFrom,
            global::System.DateTime? ptuEffectiveTo,
            bool? allowFailOpen,
            bool? enableTagFiltering,
            bool? internalRouterModel)
        {
            this.InputCostPerToken = inputCostPerToken;
            this.OutputCostPerToken = outputCostPerToken;
            this.InputCostPerCharacter = inputCostPerCharacter;
            this.OutputCostPerCharacter = outputCostPerCharacter;
            this.CacheReadInputTokenCost = cacheReadInputTokenCost;
            this.CacheCreationInputTokenCost = cacheCreationInputTokenCost;
            this.TieredPricing = tieredPricing;
            this.Id = id;
            this.DbModel = dbModel;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.BaseModel = baseModel;
            this.Tier = tier;
            this.TeamId = teamId;
            this.TeamPublicModelName = teamPublicModelName;
            this.MemberAutoRouter = memberAutoRouter;
            this.Blocked = blocked;
            this.AccessWindows = accessWindows;
            this.PtuCount = ptuCount;
            this.CostPerPtuPerHour = costPerPtuPerHour;
            this.PtuEffectiveFrom = ptuEffectiveFrom;
            this.PtuEffectiveTo = ptuEffectiveTo;
            this.AllowFailOpen = allowFailOpen;
            this.EnableTagFiltering = enableTagFiltering;
            this.InternalRouterModel = internalRouterModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        public ModelInfo()
        {
        }

    }
}