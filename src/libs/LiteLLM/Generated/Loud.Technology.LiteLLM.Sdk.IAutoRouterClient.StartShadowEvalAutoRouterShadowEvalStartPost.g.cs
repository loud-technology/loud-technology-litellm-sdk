#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAutoRouterClient
    {
        /// <summary>
        /// Start Shadow Eval<br/>
        /// Start a shadow eval: duplicate a sampled slice of one or more targets' live traffic<br/>
        /// against a second arm, judge the two responses blind, and stratify win rates by tier,<br/>
        /// by the model that served the real arm, and by target.<br/>
        /// A target is a virtual key, a team, or a user. Team and user targets match on the<br/>
        /// identity every request resolves to at auth time, so they cover JWT-authenticated<br/>
        /// traffic, which presents no virtual key; a user target samples that user's traffic<br/>
        /// across all their teams, whether it arrives on a JWT or a key they own. models narrows<br/>
        /// every target to requests for those model groups, so a user plus one model samples that<br/>
        /// user's traffic on that model across every key they own; it is forward-only, since a<br/>
        /// reverse job already samples exactly the traffic its own router served.<br/>
        /// A forward job answers whether the targets should adopt router_name: it samples the<br/>
        /// requests the router did not serve and duplicates them through it. A reverse job<br/>
        /// answers whether a target already on the router still gains from it: it samples the<br/>
        /// requests the router did serve and duplicates them against baseline_model. A target<br/>
        /// can hold one active job per direction, so both questions can run at once, and a<br/>
        /// request matching several jobs' targets (say its key and its team) is sampled by<br/>
        /// each, separately budgeted.<br/>
        /// Shadow responses are never served to users. Each target samples until its recorded<br/>
        /// eval spend, the shadow and judge calls' own cost, reaches max_budget dollars, the<br/>
        /// job's window ends, or the job is stopped, so one target running out of budget does<br/>
        /// not end sampling for the others; sampling changes propagate to pods within about 10<br/>
        /// seconds. Shadow and judge calls bill to the sampled request's own identity but are<br/>
        /// excluded from request counts and auto-router adoption metrics.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse> StartShadowEvalAutoRouterShadowEvalStartPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Shadow Eval<br/>
        /// Start a shadow eval: duplicate a sampled slice of one or more targets' live traffic<br/>
        /// against a second arm, judge the two responses blind, and stratify win rates by tier,<br/>
        /// by the model that served the real arm, and by target.<br/>
        /// A target is a virtual key, a team, or a user. Team and user targets match on the<br/>
        /// identity every request resolves to at auth time, so they cover JWT-authenticated<br/>
        /// traffic, which presents no virtual key; a user target samples that user's traffic<br/>
        /// across all their teams, whether it arrives on a JWT or a key they own. models narrows<br/>
        /// every target to requests for those model groups, so a user plus one model samples that<br/>
        /// user's traffic on that model across every key they own; it is forward-only, since a<br/>
        /// reverse job already samples exactly the traffic its own router served.<br/>
        /// A forward job answers whether the targets should adopt router_name: it samples the<br/>
        /// requests the router did not serve and duplicates them through it. A reverse job<br/>
        /// answers whether a target already on the router still gains from it: it samples the<br/>
        /// requests the router did serve and duplicates them against baseline_model. A target<br/>
        /// can hold one active job per direction, so both questions can run at once, and a<br/>
        /// request matching several jobs' targets (say its key and its team) is sampled by<br/>
        /// each, separately budgeted.<br/>
        /// Shadow responses are never served to users. Each target samples until its recorded<br/>
        /// eval spend, the shadow and judge calls' own cost, reaches max_budget dollars, the<br/>
        /// job's window ends, or the job is stopped, so one target running out of budget does<br/>
        /// not end sampling for the others; sampling changes propagate to pods within about 10<br/>
        /// seconds. Shadow and judge calls bill to the sampled request's own identity but are<br/>
        /// excluded from request counts and auto-router adoption metrics.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse>> StartShadowEvalAutoRouterShadowEvalStartPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start Shadow Eval<br/>
        /// Start a shadow eval: duplicate a sampled slice of one or more targets' live traffic<br/>
        /// against a second arm, judge the two responses blind, and stratify win rates by tier,<br/>
        /// by the model that served the real arm, and by target.<br/>
        /// A target is a virtual key, a team, or a user. Team and user targets match on the<br/>
        /// identity every request resolves to at auth time, so they cover JWT-authenticated<br/>
        /// traffic, which presents no virtual key; a user target samples that user's traffic<br/>
        /// across all their teams, whether it arrives on a JWT or a key they own. models narrows<br/>
        /// every target to requests for those model groups, so a user plus one model samples that<br/>
        /// user's traffic on that model across every key they own; it is forward-only, since a<br/>
        /// reverse job already samples exactly the traffic its own router served.<br/>
        /// A forward job answers whether the targets should adopt router_name: it samples the<br/>
        /// requests the router did not serve and duplicates them through it. A reverse job<br/>
        /// answers whether a target already on the router still gains from it: it samples the<br/>
        /// requests the router did serve and duplicates them against baseline_model. A target<br/>
        /// can hold one active job per direction, so both questions can run at once, and a<br/>
        /// request matching several jobs' targets (say its key and its team) is sampled by<br/>
        /// each, separately budgeted.<br/>
        /// Shadow responses are never served to users. Each target samples until its recorded<br/>
        /// eval spend, the shadow and judge calls' own cost, reaches max_budget dollars, the<br/>
        /// job's window ends, or the job is stopped, so one target running out of budget does<br/>
        /// not end sampling for the others; sampling changes propagate to pods within about 10<br/>
        /// seconds. Shadow and judge calls bill to the sampled request's own identity but are<br/>
        /// excluded from request counts and auto-router adoption metrics.
        /// </summary>
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
        /// <param name="shadowPercentage">
        /// Percentage of each target's requests to duplicate through the router
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse> StartShadowEvalAutoRouterShadowEvalStartPostAsync(
            double shadowPercentage,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            string? routerName = default,
            global::System.Collections.Generic.IList<string>? routerNames = default,
            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequestDirection? direction = default,
            string? baselineModel = default,
            string? judgeModel = default,
            int? durationDays = default,
            double? maxBudget = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}