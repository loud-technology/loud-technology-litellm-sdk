#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IInternalUserManagementClient
    {
        /// <summary>
        /// User Info V2<br/>
        /// Lightweight endpoint to get user info. Returns only the user object — no keys, no teams objects.<br/>
        /// This is the v2 replacement for /user/info, designed to avoid the "god endpoint" problem<br/>
        /// where the old endpoint loaded all keys and teams into memory.<br/>
        /// Access control:<br/>
        /// - Proxy admins can query any user<br/>
        /// - Team admins can query users within their teams<br/>
        /// - Internal users can only query themselves (omit user_id or pass own)<br/>
        /// - Returns 404 for non-existent users or unauthorized access<br/>
        /// Example request:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/v2/user/info?user_id=user123' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="userId">
        /// User ID in the request parameters
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.UserInfoV2Response> UserInfoV2V2UserInfoGetAsync(
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// User Info V2<br/>
        /// Lightweight endpoint to get user info. Returns only the user object — no keys, no teams objects.<br/>
        /// This is the v2 replacement for /user/info, designed to avoid the "god endpoint" problem<br/>
        /// where the old endpoint loaded all keys and teams into memory.<br/>
        /// Access control:<br/>
        /// - Proxy admins can query any user<br/>
        /// - Team admins can query users within their teams<br/>
        /// - Internal users can only query themselves (omit user_id or pass own)<br/>
        /// - Returns 404 for non-existent users or unauthorized access<br/>
        /// Example request:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/v2/user/info?user_id=user123' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="userId">
        /// User ID in the request parameters
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.UserInfoV2Response>> UserInfoV2V2UserInfoGetAsResponseAsync(
            string? userId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}