#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICostTrackingClient
    {
        /// <summary>
        /// Update Block Requests For Models Without Pricing
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BlockUnpricedModelsResponse> UpdateBlockRequestsForModelsWithoutPricingConfigBlockRequestsForModelsWithoutPricingPatchAsync(

            global::Loud.Technology.LiteLLM.Sdk.BlockUnpricedModelsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Block Requests For Models Without Pricing
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BlockUnpricedModelsResponse>> UpdateBlockRequestsForModelsWithoutPricingConfigBlockRequestsForModelsWithoutPricingPatchAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BlockUnpricedModelsRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Block Requests For Models Without Pricing
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BlockUnpricedModelsResponse> UpdateBlockRequestsForModelsWithoutPricingConfigBlockRequestsForModelsWithoutPricingPatchAsync(
            bool enabled,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}