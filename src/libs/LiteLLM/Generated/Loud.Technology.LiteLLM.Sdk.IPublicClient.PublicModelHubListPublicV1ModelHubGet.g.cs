#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Public Model Hub List<br/>
        /// The public model groups this proxy publishes, paged, sortable, searchable and<br/>
        /// filterable, for the public Model Hub page. No authentication.<br/>
        /// A rejected request answers with the parameters, sort fields and filter operators<br/>
        /// it would have accepted, so the accepted set stays discoverable from the endpoint<br/>
        /// itself rather than from a copy of the spec kept here.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --globoff         'http://0.0.0.0:4000/public/v1/model_hub?sort=-input_cost_per_token&amp;filter[mode][in]=chat&amp;page_size=25'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListResponseModelGroupInfoProxy> PublicModelHubListPublicV1ModelHubGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Public Model Hub List<br/>
        /// The public model groups this proxy publishes, paged, sortable, searchable and<br/>
        /// filterable, for the public Model Hub page. No authentication.<br/>
        /// A rejected request answers with the parameters, sort fields and filter operators<br/>
        /// it would have accepted, so the accepted set stays discoverable from the endpoint<br/>
        /// itself rather than from a copy of the spec kept here.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location --globoff         'http://0.0.0.0:4000/public/v1/model_hub?sort=-input_cost_per_token&amp;filter[mode][in]=chat&amp;page_size=25'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListResponseModelGroupInfoProxy>> PublicModelHubListPublicV1ModelHubGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}