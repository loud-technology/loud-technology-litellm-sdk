#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Bulk Update Team Keys<br/>
        /// Apply one update payload to many keys inside a single team.<br/>
        /// Pass `team_id` plus either `key_ids` or `all_keys_in_team=True`. The<br/>
        /// `update_fields` payload is broadcast to every selected key. Per-key<br/>
        /// failures are returned in `failed_updates` rather than aborting the batch.<br/>
        /// Callable by proxy admins, or by team admins with `KEY_UPDATE` permission.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyResponse> BulkUpdateTeamKeysTeamKeyBulkUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkUpdateTeamKeysRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update Team Keys<br/>
        /// Apply one update payload to many keys inside a single team.<br/>
        /// Pass `team_id` plus either `key_ids` or `all_keys_in_team=True`. The<br/>
        /// `update_fields` payload is broadcast to every selected key. Per-key<br/>
        /// failures are returned in `failed_updates` rather than aborting the batch.<br/>
        /// Callable by proxy admins, or by team admins with `KEY_UPDATE` permission.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyResponse>> BulkUpdateTeamKeysTeamKeyBulkUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkUpdateTeamKeysRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Update Team Keys<br/>
        /// Apply one update payload to many keys inside a single team.<br/>
        /// Pass `team_id` plus either `key_ids` or `all_keys_in_team=True`. The<br/>
        /// `update_fields` payload is broadcast to every selected key. Per-key<br/>
        /// failures are returned in `failed_updates` rather than aborting the batch.<br/>
        /// Callable by proxy admins, or by team admins with `KEY_UPDATE` permission.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="keyIds"></param>
        /// <param name="allKeysInTeam">
        /// Default Value: false
        /// </param>
        /// <param name="updateFields">
        /// Allowlist of bulk-broadcastable fields for /team/key/bulk_update; `extra="forbid"` blocks RBAC/ownership/scope mutations even by team admins.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkUpdateKeyResponse> BulkUpdateTeamKeysTeamKeyBulkUpdatePostAsync(
            string teamId,
            global::Loud.Technology.LiteLLM.Sdk.KeyUpdateFields updateFields,
            string? litellmChangedBy = default,
            global::System.Collections.Generic.IList<string>? keyIds = default,
            bool? allKeysInTeam = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}