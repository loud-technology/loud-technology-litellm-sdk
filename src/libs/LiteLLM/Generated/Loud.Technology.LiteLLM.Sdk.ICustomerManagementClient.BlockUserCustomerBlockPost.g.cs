#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICustomerManagementClient
    {
        /// <summary>
        /// Block User<br/>
        /// [BETA] Reject calls with this end-user id<br/>
        /// Parameters:<br/>
        /// - user_ids (List[str], required): The unique `user_id`s for the users to block<br/>
        ///     (any /chat/completion call with this user={end-user-id} param, will be rejected.)<br/>
        ///     ```<br/>
        ///     curl -X POST "http://0.0.0.0:8000/user/block"<br/>
        ///     -H "Authorization: Bearer sk-1234"<br/>
        ///     -d '{<br/>
        ///     "user_ids": [&lt;user_id&gt;, ...]<br/>
        ///     }'<br/>
        ///     ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BlockUsersResponse> BlockUserCustomerBlockPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BlockUsers request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Block User<br/>
        /// [BETA] Reject calls with this end-user id<br/>
        /// Parameters:<br/>
        /// - user_ids (List[str], required): The unique `user_id`s for the users to block<br/>
        ///     (any /chat/completion call with this user={end-user-id} param, will be rejected.)<br/>
        ///     ```<br/>
        ///     curl -X POST "http://0.0.0.0:8000/user/block"<br/>
        ///     -H "Authorization: Bearer sk-1234"<br/>
        ///     -d '{<br/>
        ///     "user_ids": [&lt;user_id&gt;, ...]<br/>
        ///     }'<br/>
        ///     ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BlockUsersResponse>> BlockUserCustomerBlockPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BlockUsers request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Block User<br/>
        /// [BETA] Reject calls with this end-user id<br/>
        /// Parameters:<br/>
        /// - user_ids (List[str], required): The unique `user_id`s for the users to block<br/>
        ///     (any /chat/completion call with this user={end-user-id} param, will be rejected.)<br/>
        ///     ```<br/>
        ///     curl -X POST "http://0.0.0.0:8000/user/block"<br/>
        ///     -H "Authorization: Bearer sk-1234"<br/>
        ///     -d '{<br/>
        ///     "user_ids": [&lt;user_id&gt;, ...]<br/>
        ///     }'<br/>
        ///     ```
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BlockUsersResponse> BlockUserCustomerBlockPostAsync(
            global::System.Collections.Generic.IList<string> userIds,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}