#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get Resource Type<br/>
        /// Get a single ResourceType by ID per RFC 7644.
        /// </summary>
        /// <param name="resourceTypeId"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetResourceTypeScimV2ResourceTypesResourceTypeIdGetAsync(
            string resourceTypeId,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Resource Type<br/>
        /// Get a single ResourceType by ID per RFC 7644.
        /// </summary>
        /// <param name="resourceTypeId"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetResourceTypeScimV2ResourceTypesResourceTypeIdGetAsResponseAsync(
            string resourceTypeId,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}