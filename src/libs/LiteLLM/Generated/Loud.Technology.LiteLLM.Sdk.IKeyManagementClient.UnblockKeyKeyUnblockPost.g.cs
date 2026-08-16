#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Unblock Key<br/>
        /// Unblock a Virtual key to allow it to make requests again.<br/>
        /// Parameters:<br/>
        /// - key: str - The key to unblock. Can be either the unhashed key (sk-...) or the hashed key value<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/unblock'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "key": "sk-Fn8Ej39NxjAXrvpUGKghGw"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an admin-only endpoint. Only proxy admins, team admins, or org admins can unblock keys.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnblockKeyKeyUnblockPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BlockKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unblock Key<br/>
        /// Unblock a Virtual key to allow it to make requests again.<br/>
        /// Parameters:<br/>
        /// - key: str - The key to unblock. Can be either the unhashed key (sk-...) or the hashed key value<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/unblock'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "key": "sk-Fn8Ej39NxjAXrvpUGKghGw"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an admin-only endpoint. Only proxy admins, team admins, or org admins can unblock keys.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UnblockKeyKeyUnblockPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BlockKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unblock Key<br/>
        /// Unblock a Virtual key to allow it to make requests again.<br/>
        /// Parameters:<br/>
        /// - key: str - The key to unblock. Can be either the unhashed key (sk-...) or the hashed key value<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/unblock'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "key": "sk-Fn8Ej39NxjAXrvpUGKghGw"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an admin-only endpoint. Only proxy admins, team admins, or org admins can unblock keys.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="key"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UnblockKeyKeyUnblockPostAsync(
            string key,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}