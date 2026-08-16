#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Update Key Fn<br/>
        /// Update an existing API key's parameters.<br/>
        /// Parameters:<br/>
        /// - key: Optional[str] - The key to update. Either key or key_alias must be provided.<br/>
        /// - key_alias: Optional[str] - User-friendly key alias. If key is omitted, also identifies the key to update (must match exactly one key, same as /key/delete's key_aliases)<br/>
        /// - user_id: Optional[str] - User ID associated with key<br/>
        /// - team_id: Optional[str] - Team ID associated with key<br/>
        /// - agent_id: Optional[str] - The agent id associated with the key.<br/>
        /// - organization_id: Optional[str] - The organization id of the key.<br/>
        /// - budget_id: Optional[str] - The budget id associated with the key. Created by calling `/budget/new`.<br/>
        /// - models: Optional[list] - Model_name's a user is allowed to call<br/>
        /// - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - spend: Optional[float] - Amount spent by key<br/>
        /// - max_budget: Optional[float] - Max budget for key<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        /// - soft_budget: Optional[float] - [TODO] Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        /// - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        /// - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        /// - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        /// - rpm_limit: Optional[int] - Requests per minute limit<br/>
        /// - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        /// - mcp_rpm_limit: Optional[dict] - Per-MCP-server RPM limits, keyed by MCP server name {"github": 100, "slack": 200}<br/>
        /// - tag_rpm_limit: Optional[dict] - Per-request-tag RPM limits, keyed by request tag {"cell-1": 1000, "cell-2": 500}. Each tag gets an independent counter; absent tags fall back to the key-level rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        /// - tpm_limit_type: Optional[str] - TPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - rpm_limit_type: Optional[str] - RPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        /// - duration: Optional[str] - Key validity duration ("30d", "1h", etc.), null to never expire, or "-1" to never expire (deprecated, use null)<br/>
        /// - permissions: Optional[dict] - Key-specific permissions<br/>
        /// - send_invite_email: Optional[bool] - Send invite email to user_id<br/>
        /// - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        /// - policies: Optional[List[str]] - List of policy names to apply to the key. Policies define guardrails, conditions, and inheritance rules.<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - throttle_on_budget_exceeded: Optional[bool] - When the key exceeds its max_budget, throttle its tpm/rpm to the global budget_exceeded_throttle_percentage instead of blocking the key entirely.<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked<br/>
        /// - aliases: Optional[dict] - Model aliases for the key - [Docs](https://litellm.vercel.app/docs/proxy/virtual_keys#model-aliases)<br/>
        /// - config: Optional[dict] - [DEPRECATED PARAM] Key-specific config.<br/>
        /// - temp_budget_increase: Optional[float] - Temporary budget increase for the key (Enterprise only).<br/>
        /// - temp_budget_expiry: Optional[str] - Expiry time for the temporary budget increase (Enterprise only).<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - allowed_passthrough_routes: Optional[list] - List of allowed pass through routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/my-custom-endpoint"]. Use this instead of allowed_routes, if you just want to specify which pass through routes the key can access, without specifying the routes. If allowed_routes is specified, allowed_passthrough_routes is ignored.<br/>
        /// - prompts: Optional[List[str]] - List of allowed prompts for the key. If specified, the key will only be able to use these specific prompts.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - auto_rotate: Optional[bool] - Whether this key should be automatically rotated<br/>
        /// - rotation_interval: Optional[str] - How often to rotate this key (e.g., '30d', '90d'). Required if auto_rotate=True<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - key-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the key. Access groups define which models a key can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the key. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "key": "sk-1234",<br/>
        ///     "key_alias": "my-key",<br/>
        ///     "user_id": "user-1234",<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"any_key": "any-val"},<br/>
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
        global::System.Threading.Tasks.Task<string> UpdateKeyFnKeyUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Key Fn<br/>
        /// Update an existing API key's parameters.<br/>
        /// Parameters:<br/>
        /// - key: Optional[str] - The key to update. Either key or key_alias must be provided.<br/>
        /// - key_alias: Optional[str] - User-friendly key alias. If key is omitted, also identifies the key to update (must match exactly one key, same as /key/delete's key_aliases)<br/>
        /// - user_id: Optional[str] - User ID associated with key<br/>
        /// - team_id: Optional[str] - Team ID associated with key<br/>
        /// - agent_id: Optional[str] - The agent id associated with the key.<br/>
        /// - organization_id: Optional[str] - The organization id of the key.<br/>
        /// - budget_id: Optional[str] - The budget id associated with the key. Created by calling `/budget/new`.<br/>
        /// - models: Optional[list] - Model_name's a user is allowed to call<br/>
        /// - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - spend: Optional[float] - Amount spent by key<br/>
        /// - max_budget: Optional[float] - Max budget for key<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        /// - soft_budget: Optional[float] - [TODO] Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        /// - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        /// - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        /// - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        /// - rpm_limit: Optional[int] - Requests per minute limit<br/>
        /// - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        /// - mcp_rpm_limit: Optional[dict] - Per-MCP-server RPM limits, keyed by MCP server name {"github": 100, "slack": 200}<br/>
        /// - tag_rpm_limit: Optional[dict] - Per-request-tag RPM limits, keyed by request tag {"cell-1": 1000, "cell-2": 500}. Each tag gets an independent counter; absent tags fall back to the key-level rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        /// - tpm_limit_type: Optional[str] - TPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - rpm_limit_type: Optional[str] - RPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        /// - duration: Optional[str] - Key validity duration ("30d", "1h", etc.), null to never expire, or "-1" to never expire (deprecated, use null)<br/>
        /// - permissions: Optional[dict] - Key-specific permissions<br/>
        /// - send_invite_email: Optional[bool] - Send invite email to user_id<br/>
        /// - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        /// - policies: Optional[List[str]] - List of policy names to apply to the key. Policies define guardrails, conditions, and inheritance rules.<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - throttle_on_budget_exceeded: Optional[bool] - When the key exceeds its max_budget, throttle its tpm/rpm to the global budget_exceeded_throttle_percentage instead of blocking the key entirely.<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked<br/>
        /// - aliases: Optional[dict] - Model aliases for the key - [Docs](https://litellm.vercel.app/docs/proxy/virtual_keys#model-aliases)<br/>
        /// - config: Optional[dict] - [DEPRECATED PARAM] Key-specific config.<br/>
        /// - temp_budget_increase: Optional[float] - Temporary budget increase for the key (Enterprise only).<br/>
        /// - temp_budget_expiry: Optional[str] - Expiry time for the temporary budget increase (Enterprise only).<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - allowed_passthrough_routes: Optional[list] - List of allowed pass through routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/my-custom-endpoint"]. Use this instead of allowed_routes, if you just want to specify which pass through routes the key can access, without specifying the routes. If allowed_routes is specified, allowed_passthrough_routes is ignored.<br/>
        /// - prompts: Optional[List[str]] - List of allowed prompts for the key. If specified, the key will only be able to use these specific prompts.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - auto_rotate: Optional[bool] - Whether this key should be automatically rotated<br/>
        /// - rotation_interval: Optional[str] - How often to rotate this key (e.g., '30d', '90d'). Required if auto_rotate=True<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - key-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the key. Access groups define which models a key can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the key. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "key": "sk-1234",<br/>
        ///     "key_alias": "my-key",<br/>
        ///     "user_id": "user-1234",<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"any_key": "any-val"},<br/>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateKeyFnKeyUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Key Fn<br/>
        /// Update an existing API key's parameters.<br/>
        /// Parameters:<br/>
        /// - key: Optional[str] - The key to update. Either key or key_alias must be provided.<br/>
        /// - key_alias: Optional[str] - User-friendly key alias. If key is omitted, also identifies the key to update (must match exactly one key, same as /key/delete's key_aliases)<br/>
        /// - user_id: Optional[str] - User ID associated with key<br/>
        /// - team_id: Optional[str] - Team ID associated with key<br/>
        /// - agent_id: Optional[str] - The agent id associated with the key.<br/>
        /// - organization_id: Optional[str] - The organization id of the key.<br/>
        /// - budget_id: Optional[str] - The budget id associated with the key. Created by calling `/budget/new`.<br/>
        /// - models: Optional[list] - Model_name's a user is allowed to call<br/>
        /// - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - spend: Optional[float] - Amount spent by key<br/>
        /// - max_budget: Optional[float] - Max budget for key<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        /// - soft_budget: Optional[float] - [TODO] Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        /// - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        /// - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        /// - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        /// - rpm_limit: Optional[int] - Requests per minute limit<br/>
        /// - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        /// - mcp_rpm_limit: Optional[dict] - Per-MCP-server RPM limits, keyed by MCP server name {"github": 100, "slack": 200}<br/>
        /// - tag_rpm_limit: Optional[dict] - Per-request-tag RPM limits, keyed by request tag {"cell-1": 1000, "cell-2": 500}. Each tag gets an independent counter; absent tags fall back to the key-level rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        /// - tpm_limit_type: Optional[str] - TPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - rpm_limit_type: Optional[str] - RPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        /// - duration: Optional[str] - Key validity duration ("30d", "1h", etc.), null to never expire, or "-1" to never expire (deprecated, use null)<br/>
        /// - permissions: Optional[dict] - Key-specific permissions<br/>
        /// - send_invite_email: Optional[bool] - Send invite email to user_id<br/>
        /// - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        /// - policies: Optional[List[str]] - List of policy names to apply to the key. Policies define guardrails, conditions, and inheritance rules.<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - throttle_on_budget_exceeded: Optional[bool] - When the key exceeds its max_budget, throttle its tpm/rpm to the global budget_exceeded_throttle_percentage instead of blocking the key entirely.<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked<br/>
        /// - aliases: Optional[dict] - Model aliases for the key - [Docs](https://litellm.vercel.app/docs/proxy/virtual_keys#model-aliases)<br/>
        /// - config: Optional[dict] - [DEPRECATED PARAM] Key-specific config.<br/>
        /// - temp_budget_increase: Optional[float] - Temporary budget increase for the key (Enterprise only).<br/>
        /// - temp_budget_expiry: Optional[str] - Expiry time for the temporary budget increase (Enterprise only).<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - allowed_passthrough_routes: Optional[list] - List of allowed pass through routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/my-custom-endpoint"]. Use this instead of allowed_routes, if you just want to specify which pass through routes the key can access, without specifying the routes. If allowed_routes is specified, allowed_passthrough_routes is ignored.<br/>
        /// - prompts: Optional[List[str]] - List of allowed prompts for the key. If specified, the key will only be able to use these specific prompts.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - auto_rotate: Optional[bool] - Whether this key should be automatically rotated<br/>
        /// - rotation_interval: Optional[str] - How often to rotate this key (e.g., '30d', '90d'). Required if auto_rotate=True<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - key-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the key. Access groups define which models a key can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the key. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/update'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///     "key": "sk-1234",<br/>
        ///     "key_alias": "my-key",<br/>
        ///     "user_id": "user-1234",<br/>
        ///     "team_id": "team-1234",<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"any_key": "any-val"},<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
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
        /// <param name="key"></param>
        /// <param name="budgetId"></param>
        /// <param name="tags"></param>
        /// <param name="disableGlobalGuardrails"></param>
        /// <param name="throttleOnBudgetExceeded"></param>
        /// <param name="enforcedParams"></param>
        /// <param name="allowedRoutes">
        /// Default Value: []
        /// </param>
        /// <param name="allowedPassthroughRoutes"></param>
        /// <param name="allowedVectorStoreIndexes"></param>
        /// <param name="rpmLimitType"></param>
        /// <param name="tpmLimitType"></param>
        /// <param name="routerSettings"></param>
        /// <param name="accessGroupIds"></param>
        /// <param name="tempBudgetIncrease"></param>
        /// <param name="tempBudgetExpiry"></param>
        /// <param name="autoRotate"></param>
        /// <param name="rotationInterval"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateKeyFnKeyUpdatePostAsync(
            string? litellmChangedBy = default,
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
            string? key = default,
            string? budgetId = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? disableGlobalGuardrails = default,
            bool? throttleOnBudgetExceeded = default,
            global::System.Collections.Generic.IList<string>? enforcedParams = default,
            global::System.Collections.Generic.IList<object>? allowedRoutes = default,
            global::System.Collections.Generic.IList<object>? allowedPassthroughRoutes = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? allowedVectorStoreIndexes = default,
            global::Loud.Technology.LiteLLM.Sdk.UpdateKeyRequestRpmLimitType2? rpmLimitType = default,
            global::Loud.Technology.LiteLLM.Sdk.UpdateKeyRequestTpmLimitType2? tpmLimitType = default,
            global::Loud.Technology.LiteLLM.Sdk.UpdateRouterConfig? routerSettings = default,
            global::System.Collections.Generic.IList<string>? accessGroupIds = default,
            double? tempBudgetIncrease = default,
            global::System.DateTime? tempBudgetExpiry = default,
            bool? autoRotate = default,
            string? rotationInterval = default,
            string? organizationId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}