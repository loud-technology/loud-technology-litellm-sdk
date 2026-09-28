#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICostTrackingClient
    {
        /// <summary>
        /// Predict Cache Cost<br/>
        /// Compare the next native Anthropic request on two configured deployment IDs.<br/>
        /// Estimates use provider token counting and recent successful cache telemetry for this key.<br/>
        /// Unknown cache state uses the cold scenario when prices/counts are available. Cache observations<br/>
        /// do not guarantee retention. v0 supports one message-content breakpoint, text and client tools;<br/>
        /// system/tool-only breakpoints, thinking, images, nondefault Anthropic versions, beta headers and<br/>
        /// request transforms are unknown.<br/>
        /// Each provider count consumes one RPM unit and holds concurrency capacity; a comparison uses<br/>
        /// up to four counts. The legacy rate limiter returns unknown without contacting the provider.<br/>
        /// This endpoint does not generate tokens, prewarm caches, choose a model or alter routing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CachePredictionResponse> PredictCacheCostCostPredictCachePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CachePredictionRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Predict Cache Cost<br/>
        /// Compare the next native Anthropic request on two configured deployment IDs.<br/>
        /// Estimates use provider token counting and recent successful cache telemetry for this key.<br/>
        /// Unknown cache state uses the cold scenario when prices/counts are available. Cache observations<br/>
        /// do not guarantee retention. v0 supports one message-content breakpoint, text and client tools;<br/>
        /// system/tool-only breakpoints, thinking, images, nondefault Anthropic versions, beta headers and<br/>
        /// request transforms are unknown.<br/>
        /// Each provider count consumes one RPM unit and holds concurrency capacity; a comparison uses<br/>
        /// up to four counts. The legacy rate limiter returns unknown without contacting the provider.<br/>
        /// This endpoint does not generate tokens, prewarm caches, choose a model or alter routing.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CachePredictionResponse>> PredictCacheCostCostPredictCachePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CachePredictionRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Predict Cache Cost<br/>
        /// Compare the next native Anthropic request on two configured deployment IDs.<br/>
        /// Estimates use provider token counting and recent successful cache telemetry for this key.<br/>
        /// Unknown cache state uses the cold scenario when prices/counts are available. Cache observations<br/>
        /// do not guarantee retention. v0 supports one message-content breakpoint, text and client tools;<br/>
        /// system/tool-only breakpoints, thinking, images, nondefault Anthropic versions, beta headers and<br/>
        /// request transforms are unknown.<br/>
        /// Each provider count consumes one RPM unit and holds concurrency capacity; a comparison uses<br/>
        /// up to four counts. The legacy rate limiter returns unknown without contacting the provider.<br/>
        /// This endpoint does not generate tokens, prewarm caches, choose a model or alter routing.
        /// </summary>
        /// <param name="currentDeploymentId"></param>
        /// <param name="candidateDeploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CachePredictionResponse> PredictCacheCostCostPredictCachePostAsync(
            string currentDeploymentId,
            string candidateDeploymentId,
            object request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}