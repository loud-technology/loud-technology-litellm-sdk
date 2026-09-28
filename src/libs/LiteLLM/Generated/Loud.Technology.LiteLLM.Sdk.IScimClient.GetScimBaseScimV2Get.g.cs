#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Get Scim Base<br/>
        /// Base SCIM v2 endpoint for resource discovery per RFC 7644 Section 4.<br/>
        /// Returns a ListResponse of ResourceTypes supported by this SCIM service provider.<br/>
        /// Identity providers (Okta, Azure AD, etc.) use this endpoint for resource discovery.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetScimBaseScimV2GetAsync(
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Scim Base<br/>
        /// Base SCIM v2 endpoint for resource discovery per RFC 7644 Section 4.<br/>
        /// Returns a ListResponse of ResourceTypes supported by this SCIM service provider.<br/>
        /// Identity providers (Okta, Azure AD, etc.) use this endpoint for resource discovery.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetScimBaseScimV2GetAsResponseAsync(
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}