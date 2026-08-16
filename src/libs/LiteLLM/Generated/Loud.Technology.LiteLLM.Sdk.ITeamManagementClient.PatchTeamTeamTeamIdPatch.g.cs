#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Patch Team<br/>
        /// Partially update a team using RFC 7386 JSON Merge Patch semantics.<br/>
        /// `team_id` is taken from the path; a `team_id` in the body is accepted only when it<br/>
        /// matches. `metadata` is merged with the team's stored metadata rather than replacing<br/>
        /// it: an omitted key is preserved, `key: null` deletes it, and any other value<br/>
        /// overwrites (recursing into nested objects). Every other field behaves exactly like<br/>
        /// `POST /team/update` (omitted preserves, a value overwrites). Returns the full<br/>
        /// updated team.<br/>
        /// ```<br/>
        /// curl --location --request PATCH 'http://0.0.0.0:4000/team/8d916b1c-510d-4894-a334-1c16a93344f5'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "metadata": {"cost_center": "1234", "deprecated_key": null}<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable> PatchTeamTeamTeamIdPatchAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.PatchTeamRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Team<br/>
        /// Partially update a team using RFC 7386 JSON Merge Patch semantics.<br/>
        /// `team_id` is taken from the path; a `team_id` in the body is accepted only when it<br/>
        /// matches. `metadata` is merged with the team's stored metadata rather than replacing<br/>
        /// it: an omitted key is preserved, `key: null` deletes it, and any other value<br/>
        /// overwrites (recursing into nested objects). Every other field behaves exactly like<br/>
        /// `POST /team/update` (omitted preserves, a value overwrites). Returns the full<br/>
        /// updated team.<br/>
        /// ```<br/>
        /// curl --location --request PATCH 'http://0.0.0.0:4000/team/8d916b1c-510d-4894-a334-1c16a93344f5'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "metadata": {"cost_center": "1234", "deprecated_key": null}<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable>> PatchTeamTeamTeamIdPatchAsResponseAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.PatchTeamRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Team<br/>
        /// Partially update a team using RFC 7386 JSON Merge Patch semantics.<br/>
        /// `team_id` is taken from the path; a `team_id` in the body is accepted only when it<br/>
        /// matches. `metadata` is merged with the team's stored metadata rather than replacing<br/>
        /// it: an omitted key is preserved, `key: null` deletes it, and any other value<br/>
        /// overwrites (recursing into nested objects). Every other field behaves exactly like<br/>
        /// `POST /team/update` (omitted preserves, a value overwrites). Returns the full<br/>
        /// updated team.<br/>
        /// ```<br/>
        /// curl --location --request PATCH 'http://0.0.0.0:4000/team/8d916b1c-510d-4894-a334-1c16a93344f5'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "metadata": {"cost_center": "1234", "deprecated_key": null}<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="requestTeamId"></param>
        /// <param name="teamAlias"></param>
        /// <param name="organizationId"></param>
        /// <param name="metadata"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="models"></param>
        /// <param name="blocked"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="tags"></param>
        /// <param name="modelAliases"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="objectPermission"></param>
        /// <param name="disableGlobalGuardrails"></param>
        /// <param name="teamMemberBudget"></param>
        /// <param name="teamMemberBudgetDuration"></param>
        /// <param name="teamMemberRpmLimit"></param>
        /// <param name="teamMemberTpmLimit"></param>
        /// <param name="teamMemberKeyDuration"></param>
        /// <param name="allowedPassthroughRoutes"></param>
        /// <param name="secretManagerSettings"></param>
        /// <param name="prompts"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="mcpRpmLimit"></param>
        /// <param name="allowedVectorStoreIndexes"></param>
        /// <param name="enforcedBatchOutputExpiresAfter"></param>
        /// <param name="enforcedFileExpiresAfter"></param>
        /// <param name="routerSettings"></param>
        /// <param name="accessGroupIds"></param>
        /// <param name="budgetLimits"></param>
        /// <param name="defaultTeamMemberModels"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable> PatchTeamTeamTeamIdPatchAsync(
            string teamId,
            string? litellmChangedBy = default,
            string? requestTeamId = default,
            string? teamAlias = default,
            string? organizationId = default,
            object? metadata = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            double? maxBudget = default,
            double? softBudget = default,
            global::System.Collections.Generic.IList<object>? models = default,
            bool? blocked = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<object>? tags = default,
            object? modelAliases = default,
            global::System.Collections.Generic.IList<string>? guardrails = default,
            global::System.Collections.Generic.IList<string>? policies = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            bool? disableGlobalGuardrails = default,
            double? teamMemberBudget = default,
            string? teamMemberBudgetDuration = default,
            int? teamMemberRpmLimit = default,
            int? teamMemberTpmLimit = default,
            string? teamMemberKeyDuration = default,
            global::System.Collections.Generic.IList<object>? allowedPassthroughRoutes = default,
            object? secretManagerSettings = default,
            global::System.Collections.Generic.IList<string>? prompts = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelRpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelTpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, int>? mcpRpmLimit = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? allowedVectorStoreIndexes = default,
            object? enforcedBatchOutputExpiresAfter = default,
            object? enforcedFileExpiresAfter = default,
            object? routerSettings = default,
            global::System.Collections.Generic.IList<string>? accessGroupIds = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? budgetLimits = default,
            global::System.Collections.Generic.IList<string>? defaultTeamMemberModels = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}