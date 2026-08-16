#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IInternalUserManagementClient
    {
        /// <summary>
        /// User Update<br/>
        /// Example curl <br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/user/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "test-litellm-user-4",<br/>
        ///     "user_role": "proxy_admin_viewer"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        ///     - user_id: Optional[str] - Specify a user id. If not set, a unique id will be generated.<br/>
        ///     - user_email: Optional[str] - Specify a user email.<br/>
        ///     - password: Optional[str] - Specify a user password.<br/>
        ///     - user_alias: Optional[str] - A descriptive name for you to know who this user id refers to.<br/>
        ///     - teams: Optional[list] - specify a list of team id's a user belongs to.<br/>
        ///     - send_invite_email: Optional[bool] - Specify if an invite email should be sent.<br/>
        ///     - user_role: Optional[str] - Specify a user role - "proxy_admin", "proxy_admin_viewer", "internal_user", "internal_user_viewer", "team", "customer". Info about each role here: `https://github.com/BerriAI/litellm/litellm/proxy/_types.py#L20`<br/>
        ///     - max_budget: Optional[float] - Specify max budget for a given user.<br/>
        ///     - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d"), months ("1mo").<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call. (if empty, key is allowed to call all models)<br/>
        ///     - tpm_limit: Optional[int] - Specify tpm limit for a given user (Tokens per minute)<br/>
        ///     - rpm_limit: Optional[int] - Specify rpm limit for a given user (Requests per minute)<br/>
        ///     - auto_create_key: bool - Default=True. Flag used for returning a key as part of the /user/new response<br/>
        ///     - aliases: Optional[dict] - Model aliases for the user - [Docs](https://litellm.vercel.app/docs/proxy/virtual_keys#model-aliases)<br/>
        ///     - config: Optional[dict] - [DEPRECATED PARAM] User-specific config.<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request-<br/>
        ///     - blocked: Optional[bool] - [Not Implemented Yet] Whether the user is blocked.<br/>
        ///     - guardrails: Optional[List[str]] - [Not Implemented Yet] List of active guardrails for the user<br/>
        ///     - policies: Optional[List[str]] - List of policy names to apply to the user. Policies define guardrails, conditions, and inheritance rules.<br/>
        ///     - permissions: Optional[dict] - [Not Implemented Yet] User-specific permissions, eg. turning off pii masking.<br/>
        ///     - metadata: Optional[dict] - Metadata for user, store information for user. Example metadata = {"team": "core-infra", "app": "app2", "email": "ishaan@berri.ai" }<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit a user based on the number of parallel requests. Raises 429 error, if user's parallel requests &gt; x.<br/>
        ///     - soft_budget: Optional[float] - Get alerts when user crosses given budget, doesn't block requests.<br/>
        ///     - model_max_budget: Optional[dict] - Model-specific max budget for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-budgets-to-keys)<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - model_rpm_limit: Optional[float] - Model-specific rpm limit for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-limits-to-keys)<br/>
        ///     - mcp_rpm_limit: Optional[dict] - Per-MCP-server rpm limit, keyed by MCP server name {"github": 100, "slack": 200}. Enforced for keys and teams only; values set on a user are stored but not enforced per user.<br/>
        ///     - tag_rpm_limit: Optional[dict] - Per-request-tag rpm limit, keyed by request tag {"cell-1": 1000, "cell-2": 500}. Enforced for keys only; values set on a user are stored but not enforced per user.<br/>
        ///     - model_tpm_limit: Optional[float] - Model-specific tpm limit for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-limits-to-keys)<br/>
        ///     - spend: Optional[float] - Amount spent by user. Default is 0. Will be updated by proxy whenever user is used. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d"), months ("1mo").<br/>
        ///     - agent_id: Optional[str] - The agent id associated with the user.<br/>
        ///     - team_id: Optional[str] - [DEPRECATED PARAM] The team id of the user. Default is None.<br/>
        ///     - duration: Optional[str] - [NOT IMPLEMENTED].<br/>
        ///     - key_alias: Optional[str] - [NOT IMPLEMENTED].<br/>
        ///     - object_permission: Optional[LiteLLM_ObjectPermissionBase] - internal user-specific object permission. Example - {"vector_stores": ["vector_store_1"], "mcp_servers": ["github"], "mcp_tool_permissions": {"github": ["list_issues"]}}. The MCP grants act as a ceiling on every key this user holds. IF null or {} then no object permission.<br/>
        ///     - prompts: Optional[List[str]] - List of allowed prompts for the user. If specified, the user will only be able to use these specific prompts.<br/>
        ///     - budget_limits: Optional[list] - List of concurrent budget windows for the user. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UserUpdateUserUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// User Update<br/>
        /// Example curl <br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/user/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "test-litellm-user-4",<br/>
        ///     "user_role": "proxy_admin_viewer"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        ///     - user_id: Optional[str] - Specify a user id. If not set, a unique id will be generated.<br/>
        ///     - user_email: Optional[str] - Specify a user email.<br/>
        ///     - password: Optional[str] - Specify a user password.<br/>
        ///     - user_alias: Optional[str] - A descriptive name for you to know who this user id refers to.<br/>
        ///     - teams: Optional[list] - specify a list of team id's a user belongs to.<br/>
        ///     - send_invite_email: Optional[bool] - Specify if an invite email should be sent.<br/>
        ///     - user_role: Optional[str] - Specify a user role - "proxy_admin", "proxy_admin_viewer", "internal_user", "internal_user_viewer", "team", "customer". Info about each role here: `https://github.com/BerriAI/litellm/litellm/proxy/_types.py#L20`<br/>
        ///     - max_budget: Optional[float] - Specify max budget for a given user.<br/>
        ///     - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d"), months ("1mo").<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call. (if empty, key is allowed to call all models)<br/>
        ///     - tpm_limit: Optional[int] - Specify tpm limit for a given user (Tokens per minute)<br/>
        ///     - rpm_limit: Optional[int] - Specify rpm limit for a given user (Requests per minute)<br/>
        ///     - auto_create_key: bool - Default=True. Flag used for returning a key as part of the /user/new response<br/>
        ///     - aliases: Optional[dict] - Model aliases for the user - [Docs](https://litellm.vercel.app/docs/proxy/virtual_keys#model-aliases)<br/>
        ///     - config: Optional[dict] - [DEPRECATED PARAM] User-specific config.<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request-<br/>
        ///     - blocked: Optional[bool] - [Not Implemented Yet] Whether the user is blocked.<br/>
        ///     - guardrails: Optional[List[str]] - [Not Implemented Yet] List of active guardrails for the user<br/>
        ///     - policies: Optional[List[str]] - List of policy names to apply to the user. Policies define guardrails, conditions, and inheritance rules.<br/>
        ///     - permissions: Optional[dict] - [Not Implemented Yet] User-specific permissions, eg. turning off pii masking.<br/>
        ///     - metadata: Optional[dict] - Metadata for user, store information for user. Example metadata = {"team": "core-infra", "app": "app2", "email": "ishaan@berri.ai" }<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit a user based on the number of parallel requests. Raises 429 error, if user's parallel requests &gt; x.<br/>
        ///     - soft_budget: Optional[float] - Get alerts when user crosses given budget, doesn't block requests.<br/>
        ///     - model_max_budget: Optional[dict] - Model-specific max budget for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-budgets-to-keys)<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - model_rpm_limit: Optional[float] - Model-specific rpm limit for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-limits-to-keys)<br/>
        ///     - mcp_rpm_limit: Optional[dict] - Per-MCP-server rpm limit, keyed by MCP server name {"github": 100, "slack": 200}. Enforced for keys and teams only; values set on a user are stored but not enforced per user.<br/>
        ///     - tag_rpm_limit: Optional[dict] - Per-request-tag rpm limit, keyed by request tag {"cell-1": 1000, "cell-2": 500}. Enforced for keys only; values set on a user are stored but not enforced per user.<br/>
        ///     - model_tpm_limit: Optional[float] - Model-specific tpm limit for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-limits-to-keys)<br/>
        ///     - spend: Optional[float] - Amount spent by user. Default is 0. Will be updated by proxy whenever user is used. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d"), months ("1mo").<br/>
        ///     - agent_id: Optional[str] - The agent id associated with the user.<br/>
        ///     - team_id: Optional[str] - [DEPRECATED PARAM] The team id of the user. Default is None.<br/>
        ///     - duration: Optional[str] - [NOT IMPLEMENTED].<br/>
        ///     - key_alias: Optional[str] - [NOT IMPLEMENTED].<br/>
        ///     - object_permission: Optional[LiteLLM_ObjectPermissionBase] - internal user-specific object permission. Example - {"vector_stores": ["vector_store_1"], "mcp_servers": ["github"], "mcp_tool_permissions": {"github": ["list_issues"]}}. The MCP grants act as a ceiling on every key this user holds. IF null or {} then no object permission.<br/>
        ///     - prompts: Optional[List[str]] - List of allowed prompts for the user. If specified, the user will only be able to use these specific prompts.<br/>
        ///     - budget_limits: Optional[list] - List of concurrent budget windows for the user. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UserUpdateUserUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// User Update<br/>
        /// Example curl <br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/user/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "user_id": "test-litellm-user-4",<br/>
        ///     "user_role": "proxy_admin_viewer"<br/>
        /// }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        ///     - user_id: Optional[str] - Specify a user id. If not set, a unique id will be generated.<br/>
        ///     - user_email: Optional[str] - Specify a user email.<br/>
        ///     - password: Optional[str] - Specify a user password.<br/>
        ///     - user_alias: Optional[str] - A descriptive name for you to know who this user id refers to.<br/>
        ///     - teams: Optional[list] - specify a list of team id's a user belongs to.<br/>
        ///     - send_invite_email: Optional[bool] - Specify if an invite email should be sent.<br/>
        ///     - user_role: Optional[str] - Specify a user role - "proxy_admin", "proxy_admin_viewer", "internal_user", "internal_user_viewer", "team", "customer". Info about each role here: `https://github.com/BerriAI/litellm/litellm/proxy/_types.py#L20`<br/>
        ///     - max_budget: Optional[float] - Specify max budget for a given user.<br/>
        ///     - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d"), months ("1mo").<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call. (if empty, key is allowed to call all models)<br/>
        ///     - tpm_limit: Optional[int] - Specify tpm limit for a given user (Tokens per minute)<br/>
        ///     - rpm_limit: Optional[int] - Specify rpm limit for a given user (Requests per minute)<br/>
        ///     - auto_create_key: bool - Default=True. Flag used for returning a key as part of the /user/new response<br/>
        ///     - aliases: Optional[dict] - Model aliases for the user - [Docs](https://litellm.vercel.app/docs/proxy/virtual_keys#model-aliases)<br/>
        ///     - config: Optional[dict] - [DEPRECATED PARAM] User-specific config.<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request-<br/>
        ///     - blocked: Optional[bool] - [Not Implemented Yet] Whether the user is blocked.<br/>
        ///     - guardrails: Optional[List[str]] - [Not Implemented Yet] List of active guardrails for the user<br/>
        ///     - policies: Optional[List[str]] - List of policy names to apply to the user. Policies define guardrails, conditions, and inheritance rules.<br/>
        ///     - permissions: Optional[dict] - [Not Implemented Yet] User-specific permissions, eg. turning off pii masking.<br/>
        ///     - metadata: Optional[dict] - Metadata for user, store information for user. Example metadata = {"team": "core-infra", "app": "app2", "email": "ishaan@berri.ai" }<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit a user based on the number of parallel requests. Raises 429 error, if user's parallel requests &gt; x.<br/>
        ///     - soft_budget: Optional[float] - Get alerts when user crosses given budget, doesn't block requests.<br/>
        ///     - model_max_budget: Optional[dict] - Model-specific max budget for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-budgets-to-keys)<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - model_rpm_limit: Optional[float] - Model-specific rpm limit for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-limits-to-keys)<br/>
        ///     - mcp_rpm_limit: Optional[dict] - Per-MCP-server rpm limit, keyed by MCP server name {"github": 100, "slack": 200}. Enforced for keys and teams only; values set on a user are stored but not enforced per user.<br/>
        ///     - tag_rpm_limit: Optional[dict] - Per-request-tag rpm limit, keyed by request tag {"cell-1": 1000, "cell-2": 500}. Enforced for keys only; values set on a user are stored but not enforced per user.<br/>
        ///     - model_tpm_limit: Optional[float] - Model-specific tpm limit for user. [Docs](https://docs.litellm.ai/docs/proxy/users#add-model-specific-limits-to-keys)<br/>
        ///     - spend: Optional[float] - Amount spent by user. Default is 0. Will be updated by proxy whenever user is used. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d"), months ("1mo").<br/>
        ///     - agent_id: Optional[str] - The agent id associated with the user.<br/>
        ///     - team_id: Optional[str] - [DEPRECATED PARAM] The team id of the user. Default is None.<br/>
        ///     - duration: Optional[str] - [NOT IMPLEMENTED].<br/>
        ///     - key_alias: Optional[str] - [NOT IMPLEMENTED].<br/>
        ///     - object_permission: Optional[LiteLLM_ObjectPermissionBase] - internal user-specific object permission. Example - {"vector_stores": ["vector_store_1"], "mcp_servers": ["github"], "mcp_tool_permissions": {"github": ["list_issues"]}}. The MCP grants act as a ceiling on every key this user holds. IF null or {} then no object permission.<br/>
        ///     - prompts: Optional[List[str]] - List of allowed prompts for the user. If specified, the user will only be able to use these specific prompts.<br/>
        ///     - budget_limits: Optional[list] - List of concurrent budget windows for the user. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].
        /// </summary>
        /// <param name="keyAlias"></param>
        /// <param name="duration"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="spend"></param>
        /// <param name="maxBudget"></param>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="agentId"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="metadata"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetLimits"></param>
        /// <param name="allowedCacheControls">
        /// Default Value: []
        /// </param>
        /// <param name="config">
        /// Default Value: {}
        /// </param>
        /// <param name="permissions">
        /// Default Value: {}
        /// </param>
        /// <param name="modelMaxBudget">
        /// Default Value: {}
        /// </param>
        /// <param name="budgetFallbacks"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="mcpRpmLimit"></param>
        /// <param name="tagRpmLimit"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="prompts"></param>
        /// <param name="blocked"></param>
        /// <param name="aliases">
        /// Default Value: {}
        /// </param>
        /// <param name="objectPermission"></param>
        /// <param name="password"></param>
        /// <param name="userAlias"></param>
        /// <param name="userRole"></param>
        /// <param name="userEmail"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UserUpdateUserUpdatePostAsync(
            string? keyAlias = default,
            string? duration = default,
            global::System.Collections.Generic.IList<object>? models = default,
            double? spend = default,
            double? maxBudget = default,
            string? userId = default,
            string? teamId = default,
            string? agentId = default,
            int? maxParallelRequests = default,
            object? metadata = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? budgetLimits = default,
            global::System.Collections.Generic.IList<object>? allowedCacheControls = default,
            object? config = default,
            object? permissions = default,
            object? modelMaxBudget = default,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? budgetFallbacks = default,
            object? modelRpmLimit = default,
            object? modelTpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, int>? mcpRpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, int>? tagRpmLimit = default,
            global::System.Collections.Generic.IList<string>? guardrails = default,
            global::System.Collections.Generic.IList<string>? policies = default,
            global::System.Collections.Generic.IList<string>? prompts = default,
            bool? blocked = default,
            object? aliases = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            string? password = default,
            string? userAlias = default,
            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequestUserRole2? userRole = default,
            string? userEmail = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}