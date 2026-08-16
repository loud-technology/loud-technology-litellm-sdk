#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Bulk Update Keys<br/>
        /// Bulk update multiple keys at once.<br/>
        /// This endpoint allows updating multiple keys in a single request. Each key update<br/>
        /// is processed independently - if some updates fail, others will still succeed.<br/>
        /// Parameters:<br/>
        /// - keys: List[BulkUpdateKeyRequestItem] - List of key update requests, each containing:<br/>
        ///     - key: str - The key identifier (token) to update<br/>
        ///     - budget_id: Optional[str] - Budget ID associated with the key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys<br/>
        /// Returns:<br/>
        /// - total_requested: int - Total number of keys requested for update<br/>
        /// - successful_updates: List[SuccessfulKeyUpdate] - List of successfully updated keys with their updated info<br/>
        /// - failed_updates: List[FailedKeyUpdate] - List of failed updates with key_info and failed_reason<br/>
        /// Example request:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "keys": [<br/>
        ///         {<br/>
        ///             "key": "sk-1234",<br/>
        ///             "max_budget": 100.0,<br/>
        ///             "team_id": "team-123",<br/>
        ///             "tags": ["production", "api"]<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "key": "sk-5678",<br/>
        ///             "budget_id": "budget-456",<br/>
        ///             "tags": ["staging"]<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyResponse> BulkUpdateKeysKeyBulkUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update Keys<br/>
        /// Bulk update multiple keys at once.<br/>
        /// This endpoint allows updating multiple keys in a single request. Each key update<br/>
        /// is processed independently - if some updates fail, others will still succeed.<br/>
        /// Parameters:<br/>
        /// - keys: List[BulkUpdateKeyRequestItem] - List of key update requests, each containing:<br/>
        ///     - key: str - The key identifier (token) to update<br/>
        ///     - budget_id: Optional[str] - Budget ID associated with the key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys<br/>
        /// Returns:<br/>
        /// - total_requested: int - Total number of keys requested for update<br/>
        /// - successful_updates: List[SuccessfulKeyUpdate] - List of successfully updated keys with their updated info<br/>
        /// - failed_updates: List[FailedKeyUpdate] - List of failed updates with key_info and failed_reason<br/>
        /// Example request:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "keys": [<br/>
        ///         {<br/>
        ///             "key": "sk-1234",<br/>
        ///             "max_budget": 100.0,<br/>
        ///             "team_id": "team-123",<br/>
        ///             "tags": ["production", "api"]<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "key": "sk-5678",<br/>
        ///             "budget_id": "budget-456",<br/>
        ///             "tags": ["staging"]<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyResponse>> BulkUpdateKeysKeyBulkUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update Keys<br/>
        /// Bulk update multiple keys at once.<br/>
        /// This endpoint allows updating multiple keys in a single request. Each key update<br/>
        /// is processed independently - if some updates fail, others will still succeed.<br/>
        /// Parameters:<br/>
        /// - keys: List[BulkUpdateKeyRequestItem] - List of key update requests, each containing:<br/>
        ///     - key: str - The key identifier (token) to update<br/>
        ///     - budget_id: Optional[str] - Budget ID associated with the key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys<br/>
        /// Returns:<br/>
        /// - total_requested: int - Total number of keys requested for update<br/>
        /// - successful_updates: List[SuccessfulKeyUpdate] - List of successfully updated keys with their updated info<br/>
        /// - failed_updates: List[FailedKeyUpdate] - List of failed updates with key_info and failed_reason<br/>
        /// Example request:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/bulk_update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "keys": [<br/>
        ///         {<br/>
        ///             "key": "sk-1234",<br/>
        ///             "max_budget": 100.0,<br/>
        ///             "team_id": "team-123",<br/>
        ///             "tags": ["production", "api"]<br/>
        ///         },<br/>
        ///         {<br/>
        ///             "key": "sk-5678",<br/>
        ///             "budget_id": "budget-456",<br/>
        ///             "tags": ["staging"]<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="keys"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyResponse> BulkUpdateKeysKeyBulkUpdatePostAsync(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyRequestItem> keys,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}