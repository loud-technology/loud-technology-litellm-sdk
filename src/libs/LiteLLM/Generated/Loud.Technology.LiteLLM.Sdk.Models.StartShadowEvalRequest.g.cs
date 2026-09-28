
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Start duplicating one or more targets' traffic for blind comparison against an auto-router.<br/>
    /// A target is a virtual key, a team, or a user; each becomes its own leg with its own<br/>
    /// budget and stop state. Team and user targets match on the identity every request<br/>
    /// carries after auth (user_api_key_team_id / user_api_key_user_id), so they cover<br/>
    /// JWT-authenticated traffic, which presents no virtual key at all.
    /// </summary>
    public sealed partial class StartShadowEvalRequest
    {
        /// <summary>
        /// Hashed virtual keys whose traffic will be shadowed. Combined with team_ids and user_ids the job needs at least one target and at most 100, which also bounds every read the job's endpoints make. Each target carries its own max_budget spend budget, so one exhausting its budget leaves the others sampling.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_ids")]
        public global::System.Collections.Generic.IList<string>? ApiKeyIds { get; set; }

        /// <summary>
        /// Teams whose traffic will be shadowed, matched on the team every authenticated request resolves to, so a team's JWT-auth and virtual-key traffic are both sampled<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<string>? TeamIds { get; set; }

        /// <summary>
        /// Users whose traffic will be shadowed, matched on the user every authenticated request resolves to across all their teams: JWT requests carrying their subject claim and virtual keys they own<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Model groups to narrow the sampled traffic to, matched on the group the caller requested and resolved through model_group_alias, so an alias and its target are one name. Empty samples every model the targets use. This ANDs with the targets: a job over a user and one model samples that user's requests on that model across every key they own, and none of their other traffic. Forward jobs only: a reverse job samples exactly the traffic its own router served, which no other model group can name<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// The auto-router under evaluation, in either direction: the single-router spelling of router_names. Provide exactly one of the two fields
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_name")]
        public string? RouterName { get; set; }

        /// <summary>
        /// The auto-routers under evaluation, at most 4. Every sampled request runs through every router listed and each arm is judged independently against the same real response, so routers compare head-to-head on identical traffic. More than one router requires direction 'forward'. After validation this field always carries the full deduplicated set, whichever spelling the caller used<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_names")]
        public global::System.Collections.Generic.IList<string>? RouterNames { get; set; }

        /// <summary>
        /// forward answers 'should this key adopt router_name': it samples the requests the key did NOT route through the router and duplicates them through it. reverse answers 'is the router still worth it for a key already on it': it samples the requests the router did serve and duplicates them against baseline_model. The response the caller received is always the real arm<br/>
        /// Default Value: forward
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.StartShadowEvalRequestDirectionJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequestDirection? Direction { get; set; }

        /// <summary>
        /// Required when direction is reverse and rejected otherwise: the fixed model the router's own responses are judged against. Must be a plain model rather than another auto-router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_model")]
        public string? BaselineModel { get; set; }

        /// <summary>
        /// Percentage of each target's requests to duplicate through the router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ShadowPercentage { get; set; }

        /// <summary>
        /// Model used to blindly judge real vs. shadow responses. The judge only compares two answers, so a mid-tier model (Claude Sonnet or GPT-4o class) is the sweet spot: small/nano-class models produce unreliable or malformed verdicts, while frontier reasoning models add cost without changing outcomes.<br/>
        /// Default Value: anthropic/claude-sonnet-5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_model")]
        public string? JudgeModel { get; set; }

        /// <summary>
        /// How many days the job samples traffic before completing on its own<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_days")]
        public int? DurationDays { get; set; }

        /// <summary>
        /// Per-target USD budget for the eval's own overhead, the shadow-arm and judge calls, priced with the same figures the spend pipeline bills. EACH scoped target samples until its recorded eval spend reaches this, so a job over N targets spends at most about N times max_budget; in-flight samples can overshoot the cap by one sampling cache window. Every router arm draws from the same per-target budget, so a multi-router job reaches it proportionally sooner<br/>
        /// Default Value: 10F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartShadowEvalRequest" /> class.
        /// </summary>
        /// <param name="shadowPercentage">
        /// Percentage of each target's requests to duplicate through the router
        /// </param>
        /// <param name="apiKeyIds">
        /// Hashed virtual keys whose traffic will be shadowed. Combined with team_ids and user_ids the job needs at least one target and at most 100, which also bounds every read the job's endpoints make. Each target carries its own max_budget spend budget, so one exhausting its budget leaves the others sampling.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="teamIds">
        /// Teams whose traffic will be shadowed, matched on the team every authenticated request resolves to, so a team's JWT-auth and virtual-key traffic are both sampled<br/>
        /// Default Value: []
        /// </param>
        /// <param name="userIds">
        /// Users whose traffic will be shadowed, matched on the user every authenticated request resolves to across all their teams: JWT requests carrying their subject claim and virtual keys they own<br/>
        /// Default Value: []
        /// </param>
        /// <param name="models">
        /// Model groups to narrow the sampled traffic to, matched on the group the caller requested and resolved through model_group_alias, so an alias and its target are one name. Empty samples every model the targets use. This ANDs with the targets: a job over a user and one model samples that user's requests on that model across every key they own, and none of their other traffic. Forward jobs only: a reverse job samples exactly the traffic its own router served, which no other model group can name<br/>
        /// Default Value: []
        /// </param>
        /// <param name="routerName">
        /// The auto-router under evaluation, in either direction: the single-router spelling of router_names. Provide exactly one of the two fields
        /// </param>
        /// <param name="routerNames">
        /// The auto-routers under evaluation, at most 4. Every sampled request runs through every router listed and each arm is judged independently against the same real response, so routers compare head-to-head on identical traffic. More than one router requires direction 'forward'. After validation this field always carries the full deduplicated set, whichever spelling the caller used<br/>
        /// Default Value: []
        /// </param>
        /// <param name="direction">
        /// forward answers 'should this key adopt router_name': it samples the requests the key did NOT route through the router and duplicates them through it. reverse answers 'is the router still worth it for a key already on it': it samples the requests the router did serve and duplicates them against baseline_model. The response the caller received is always the real arm<br/>
        /// Default Value: forward
        /// </param>
        /// <param name="baselineModel">
        /// Required when direction is reverse and rejected otherwise: the fixed model the router's own responses are judged against. Must be a plain model rather than another auto-router
        /// </param>
        /// <param name="judgeModel">
        /// Model used to blindly judge real vs. shadow responses. The judge only compares two answers, so a mid-tier model (Claude Sonnet or GPT-4o class) is the sweet spot: small/nano-class models produce unreliable or malformed verdicts, while frontier reasoning models add cost without changing outcomes.<br/>
        /// Default Value: anthropic/claude-sonnet-5
        /// </param>
        /// <param name="durationDays">
        /// How many days the job samples traffic before completing on its own<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="maxBudget">
        /// Per-target USD budget for the eval's own overhead, the shadow-arm and judge calls, priced with the same figures the spend pipeline bills. EACH scoped target samples until its recorded eval spend reaches this, so a job over N targets spends at most about N times max_budget; in-flight samples can overshoot the cap by one sampling cache window. Every router arm draws from the same per-target budget, so a multi-router job reaches it proportionally sooner<br/>
        /// Default Value: 10F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StartShadowEvalRequest(
            double shadowPercentage,
            global::System.Collections.Generic.IList<string>? apiKeyIds,
            global::System.Collections.Generic.IList<string>? teamIds,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? models,
            string? routerName,
            global::System.Collections.Generic.IList<string>? routerNames,
            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequestDirection? direction,
            string? baselineModel,
            string? judgeModel,
            int? durationDays,
            double? maxBudget)
        {
            this.ApiKeyIds = apiKeyIds;
            this.TeamIds = teamIds;
            this.UserIds = userIds;
            this.Models = models;
            this.RouterName = routerName;
            this.RouterNames = routerNames;
            this.Direction = direction;
            this.BaselineModel = baselineModel;
            this.ShadowPercentage = shadowPercentage;
            this.JudgeModel = judgeModel;
            this.DurationDays = durationDays;
            this.MaxBudget = maxBudget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartShadowEvalRequest" /> class.
        /// </summary>
        public StartShadowEvalRequest()
        {
        }

    }
}