
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One target a job shadows (a key, team, or user), with its own budget and stop state.
    /// </summary>
    public sealed partial class ShadowEvalJobTargetResponse
    {
        /// <summary>
        /// What kind of entity this entry scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ShadowEvalJobTargetResponseTargetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobTargetResponseTargetType TargetType { get; set; }

        /// <summary>
        /// The hashed virtual key, team id, or user id whose traffic this entry scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetId { get; set; }

        /// <summary>
        /// This target's sample-count ceiling: the whole budget for jobs created before max_budget existed, and the error-loop safety valve otherwise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTurns { get; set; }

        /// <summary>
        /// This target's own USD budget for the eval's shadow and judge spend, independent of its siblings'; None on jobs created before spend budgets existed, which max_turns alone bounds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// When this target's slot was stamped free, whether its own budget ran out, the window closed, or an operator stopped the job; status is derived, so a spent budget reads completed even while this is still unset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopped_at")]
        public global::System.DateTime? StoppedAt { get; set; }

        /// <summary>
        /// This target's sampled attempts so far, judged and errored alike, the same count the sampler budgets against max_turns; populated on list and detail responses. Frozen at stopped_at once the target is stamped, so in-flight attempts landing after a stop never reclassify it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempt_count")]
        public int? AttemptCount { get; set; }

        /// <summary>
        /// This target's recorded shadow plus judge spend in USD, the same figure the sampler budgets against max_budget; populated on list and detail responses and frozen at stopped_at exactly like attempt_count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// This target's own judged-verdict slice; detail endpoint only, None until a turn is judged
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdicts")]
        public global::Loud.Technology.LiteLLM.Sdk.ShadowEvalSlice? Verdicts { get; set; }

        /// <summary>
        /// Display label resolved from the target's own row at read time: the key's alias, the team's alias, or the user's email; None when unset or deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_alias")]
        public string? TargetAlias { get; set; }

        /// <summary>
        /// Masked display name (sk-...) for key targets, resolved at read time; None for teams and users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_name")]
        public string? KeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowEvalJobTargetResponse" /> class.
        /// </summary>
        /// <param name="targetType">
        /// What kind of entity this entry scopes
        /// </param>
        /// <param name="targetId">
        /// The hashed virtual key, team id, or user id whose traffic this entry scopes
        /// </param>
        /// <param name="maxTurns">
        /// This target's sample-count ceiling: the whole budget for jobs created before max_budget existed, and the error-loop safety valve otherwise
        /// </param>
        /// <param name="maxBudget">
        /// This target's own USD budget for the eval's shadow and judge spend, independent of its siblings'; None on jobs created before spend budgets existed, which max_turns alone bounds
        /// </param>
        /// <param name="stoppedAt">
        /// When this target's slot was stamped free, whether its own budget ran out, the window closed, or an operator stopped the job; status is derived, so a spent budget reads completed even while this is still unset
        /// </param>
        /// <param name="attemptCount">
        /// This target's sampled attempts so far, judged and errored alike, the same count the sampler budgets against max_turns; populated on list and detail responses. Frozen at stopped_at once the target is stamped, so in-flight attempts landing after a stop never reclassify it
        /// </param>
        /// <param name="spend">
        /// This target's recorded shadow plus judge spend in USD, the same figure the sampler budgets against max_budget; populated on list and detail responses and frozen at stopped_at exactly like attempt_count
        /// </param>
        /// <param name="verdicts">
        /// This target's own judged-verdict slice; detail endpoint only, None until a turn is judged
        /// </param>
        /// <param name="targetAlias">
        /// Display label resolved from the target's own row at read time: the key's alias, the team's alias, or the user's email; None when unset or deleted
        /// </param>
        /// <param name="keyName">
        /// Masked display name (sk-...) for key targets, resolved at read time; None for teams and users
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShadowEvalJobTargetResponse(
            global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobTargetResponseTargetType targetType,
            string targetId,
            int maxTurns,
            double? maxBudget,
            global::System.DateTime? stoppedAt,
            int? attemptCount,
            double? spend,
            global::Loud.Technology.LiteLLM.Sdk.ShadowEvalSlice? verdicts,
            string? targetAlias,
            string? keyName)
        {
            this.TargetType = targetType;
            this.TargetId = targetId ?? throw new global::System.ArgumentNullException(nameof(targetId));
            this.MaxTurns = maxTurns;
            this.MaxBudget = maxBudget;
            this.StoppedAt = stoppedAt;
            this.AttemptCount = attemptCount;
            this.Spend = spend;
            this.Verdicts = verdicts;
            this.TargetAlias = targetAlias;
            this.KeyName = keyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowEvalJobTargetResponse" /> class.
        /// </summary>
        public ShadowEvalJobTargetResponse()
        {
        }

    }
}