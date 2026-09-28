#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICostOptimizationClient
    {
        /// <summary>
        /// Get Prompt Caching Requests
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="cursorStartTime"></param>
        /// <param name="cursorRequestId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.PromptCachingRequestsResponse> GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter? filter = default,
            global::System.DateTime? cursorStartTime = default,
            string? cursorRequestId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Prompt Caching Requests
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="pageSize">
        /// Default Value: 50
        /// </param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="cursorStartTime"></param>
        /// <param name="cursorRequestId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.PromptCachingRequestsResponse>> GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetAsResponseAsync(
            global::System.DateTime startDate,
            global::System.DateTime endDate,
            int? pageSize = default,
            global::Loud.Technology.LiteLLM.Sdk.GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter? filter = default,
            global::System.DateTime? cursorStartTime = default,
            string? cursorRequestId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}