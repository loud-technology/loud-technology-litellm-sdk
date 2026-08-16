#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IJwtMappingsClient
    {
        /// <summary>
        /// Update Jwt Key Mapping
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.JWTKeyMappingResponse> UpdateJwtKeyMappingJwtKeyMappingUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateJWTKeyMappingRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Jwt Key Mapping
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.JWTKeyMappingResponse>> UpdateJwtKeyMappingJwtKeyMappingUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateJWTKeyMappingRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Jwt Key Mapping
        /// </summary>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="isActive"></param>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.JWTKeyMappingResponse> UpdateJwtKeyMappingJwtKeyMappingUpdatePostAsync(
            string id,
            string? description = default,
            bool? isActive = default,
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}