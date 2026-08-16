#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICustomerManagementClient
    {
        /// <summary>
        /// End User Info<br/>
        /// Get information about an end-user. An `end_user` is a customer (external user) of the proxy.<br/>
        /// Parameters:<br/>
        /// - end_user_id (str, required): The unique identifier for the end-user<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/customer/info?end_user_id=test-litellm-user-4'         -H 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="endUserId">
        /// End User ID in the request parameters
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CustomerResponse> EndUserInfoCustomerInfoGetAsync(
            string endUserId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// End User Info<br/>
        /// Get information about an end-user. An `end_user` is a customer (external user) of the proxy.<br/>
        /// Parameters:<br/>
        /// - end_user_id (str, required): The unique identifier for the end-user<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/customer/info?end_user_id=test-litellm-user-4'         -H 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="endUserId">
        /// End User ID in the request parameters
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CustomerResponse>> EndUserInfoCustomerInfoGetAsResponseAsync(
            string endUserId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}