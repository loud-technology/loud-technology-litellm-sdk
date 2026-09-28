#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Public Model Hub Facet<br/>
        /// The distinct providers, modes or features across the published model groups, for the<br/>
        /// Model Hub's filter dropdowns. No authentication.<br/>
        /// Carries the same filters and search as the list route, so a dropdown offers exactly<br/>
        /// the values the table can show: asking for providers under `filter[mode][in]=chat`<br/>
        /// lists only the providers that serve a chat model.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --globoff         'http://0.0.0.0:4000/public/v1/model_hub/providers?filter[mode][in]=chat&amp;page_size=50'<br/>
        /// ```
        /// </summary>
        /// <param name="facet"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.FacetListResponse> PublicModelHubFacetPublicV1ModelHubFacetGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.PublicModelHubFacetPublicV1ModelHubFacetGetFacet facet,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Public Model Hub Facet<br/>
        /// The distinct providers, modes or features across the published model groups, for the<br/>
        /// Model Hub's filter dropdowns. No authentication.<br/>
        /// Carries the same filters and search as the list route, so a dropdown offers exactly<br/>
        /// the values the table can show: asking for providers under `filter[mode][in]=chat`<br/>
        /// lists only the providers that serve a chat model.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --globoff         'http://0.0.0.0:4000/public/v1/model_hub/providers?filter[mode][in]=chat&amp;page_size=50'<br/>
        /// ```
        /// </summary>
        /// <param name="facet"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.FacetListResponse>> PublicModelHubFacetPublicV1ModelHubFacetGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.PublicModelHubFacetPublicV1ModelHubFacetGetFacet facet,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}