#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
        /// <summary>
        /// Health Services Endpoint<br/>
        /// Use this admin-only endpoint to check if the service is healthy.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -L -X GET 'http://0.0.0.0:4000/health/services?service=datadog'     -H 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="service">
        /// Specify the service being hit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthServicesEndpointHealthServicesGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.HealthServicesEndpointHealthServicesGetService2?, string> service,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Health Services Endpoint<br/>
        /// Use this admin-only endpoint to check if the service is healthy.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -L -X GET 'http://0.0.0.0:4000/health/services?service=datadog'     -H 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="service">
        /// Specify the service being hit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> HealthServicesEndpointHealthServicesGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::Loud.Technology.LiteLLM.Sdk.HealthServicesEndpointHealthServicesGetService2?, string> service,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}