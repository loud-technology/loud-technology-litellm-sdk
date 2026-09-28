#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILlmPassthroughClient
    {
        /// <summary>
        /// Tinyfish Proxy Route<br/>
        /// Pass-through for the TinyFish Agent API (goal-based web automation).<br/>
        /// Forwarded endpoints:<br/>
        /// - POST /v1/automation/run        — run to completion (blocking)<br/>
        /// - POST /v1/automation/run-async  — submit a run, poll GET /v1/runs/{id} for the result<br/>
        /// - POST /v1/automation/run-sse    — run with SSE progress events<br/>
        /// - GET  /v1/runs/{id}             — run status / result<br/>
        /// - POST /v1/runs/{id}/cancel      — cancel a run<br/>
        /// Every other Agent API endpoint (vault, wallet, browser profiles, and the GET /v1/runs<br/>
        /// listing, which would let any caller discover other callers' run ids) returns 403: all<br/>
        /// proxy callers share one upstream key.<br/>
        /// Credential lookup order:<br/>
        /// 1. passthrough_endpoint_router (config.yaml deployments with use_in_pass_through)<br/>
        /// 2. TINYFISH_API_KEY environment variable<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/tinyfish)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TinyfishProxyRouteTinyfishEndpointGetAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tinyfish Proxy Route<br/>
        /// Pass-through for the TinyFish Agent API (goal-based web automation).<br/>
        /// Forwarded endpoints:<br/>
        /// - POST /v1/automation/run        — run to completion (blocking)<br/>
        /// - POST /v1/automation/run-async  — submit a run, poll GET /v1/runs/{id} for the result<br/>
        /// - POST /v1/automation/run-sse    — run with SSE progress events<br/>
        /// - GET  /v1/runs/{id}             — run status / result<br/>
        /// - POST /v1/runs/{id}/cancel      — cancel a run<br/>
        /// Every other Agent API endpoint (vault, wallet, browser profiles, and the GET /v1/runs<br/>
        /// listing, which would let any caller discover other callers' run ids) returns 403: all<br/>
        /// proxy callers share one upstream key.<br/>
        /// Credential lookup order:<br/>
        /// 1. passthrough_endpoint_router (config.yaml deployments with use_in_pass_through)<br/>
        /// 2. TINYFISH_API_KEY environment variable<br/>
        /// [Docs](https://docs.litellm.ai/docs/pass_through/tinyfish)
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TinyfishProxyRouteTinyfishEndpointGetAsResponseAsync(
            string endpoint,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}