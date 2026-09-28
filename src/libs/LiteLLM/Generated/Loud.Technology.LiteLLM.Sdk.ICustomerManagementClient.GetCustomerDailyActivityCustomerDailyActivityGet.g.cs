#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICustomerManagementClient
    {
        /// <summary>
        /// Get Customer Daily Activity<br/>
        /// Get daily activity for specific organizations or all accessible organizations.
        /// </summary>
        /// <param name="endUserIds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="apiKey"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="excludeEndUserIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse> GetCustomerDailyActivityCustomerDailyActivityGetAsync(
            string? endUserIds = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            int? page = default,
            int? pageSize = default,
            string? excludeEndUserIds = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Customer Daily Activity<br/>
        /// Get daily activity for specific organizations or all accessible organizations.
        /// </summary>
        /// <param name="endUserIds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="model"></param>
        /// <param name="apiKey"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 10
        /// </param>
        /// <param name="excludeEndUserIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SpendAnalyticsPaginatedResponse>> GetCustomerDailyActivityCustomerDailyActivityGetAsResponseAsync(
            string? endUserIds = default,
            string? startDate = default,
            string? endDate = default,
            string? model = default,
            string? apiKey = default,
            int? page = default,
            int? pageSize = default,
            string? excludeEndUserIds = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}