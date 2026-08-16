#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Generate Service Account Key Fn<br/>
        /// Generate a Service Account API key based on the provided data. This key does not belong to any user. It belongs to the team.<br/>
        /// Why use a service account key?<br/>
        /// - Prevent key from being deleted when user is deleted.<br/>
        /// - Apply team limits, not team member limits to key.<br/>
        /// Docs: https://docs.litellm.ai/docs/proxy/virtual_keys<br/>
        /// Parameters:<br/>
        /// - duration: Optional[str] - Specify the length of time the token is valid for. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - key_alias: Optional[str] - User defined key alias<br/>
        /// - key: Optional[str] - User defined key value. Must start with 'sk-' and be at least 16 characters long. If not set, a 16-digit unique sk-key is created for you.<br/>
        /// - team_id: Optional[str] - The team id of the key<br/>
        /// - user_id: Optional[str] - [NON-FUNCTIONAL] THIS WILL BE IGNORED. The user id of the key<br/>
        /// - budget_id: Optional[str] - The budget id associated with the key. Created by calling `/budget/new`.<br/>
        /// - models: Optional[list] - Model_name's a user is allowed to call. (if empty, key is allowed to call all models)<br/>
        /// - aliases: Optional[dict] - Any alias mappings, on top of anything in the config.yaml model list. - https://docs.litellm.ai/docs/proxy/virtual_keys#managing-auth---upgradedowngrade-models<br/>
        /// - config: Optional[dict] - any key-specific configs, overrides config in config.yaml<br/>
        /// - spend: Optional[int] - Amount spent by key. Default is 0. Will be updated by proxy whenever key is used. https://docs.litellm.ai/docs/proxy/virtual_keys#managing-auth---tracking-spend<br/>
        /// - send_invite_email: Optional[bool] - Whether to send an invite email to the user_id, with the generate key<br/>
        /// - max_budget: Optional[float] - Specify max budget for a given key.<br/>
        /// - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - max_parallel_requests: Optional[int] - Rate limit a user based on the number of parallel requests. Raises 429 error, if user's parallel requests &gt; x.<br/>
        /// - metadata: Optional[dict] - Metadata for key, store information for key. Example metadata = {"team": "core-infra", "app": "app2", "email": "ishaan@berri.ai" }<br/>
        /// - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        /// - permissions: Optional[dict] - key-specific permissions. Currently just used for turning off pii masking (if connected). Example - {"pii": false}<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}}. IF null or {} then no model specific budget.<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - model_rpm_limit: Optional[dict] - key-specific model rpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - key-specific model tpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific tpm limit.<br/>
        /// - mcp_rpm_limit: Optional[dict] - key-specific per-MCP-server rpm limit, keyed by MCP server name (alias if set, else the configured name). Example - {"github": 100, "slack": 200}. IF null or {} then no MCP-specific rpm limit.<br/>
        /// - tpm_limit_type: Optional[str] - TPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - rpm_limit_type: Optional[str] - RPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked.<br/>
        /// - rpm_limit: Optional[int] - Specify rpm limit for a given key (Requests per minute)<br/>
        /// - tpm_limit: Optional[int] - Specify tpm limit for a given key (Tokens per minute)<br/>
        /// - soft_budget: Optional[float] - Specify soft budget for a given key. Will trigger a slack alert when this soft budget is reached.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// Examples:<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// 1. Allow users to turn on/off pii masking<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/generate'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "permissions": {"allow_pii_controls": true}<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - key: (str) The generated api key<br/>
        /// - expires: (datetime) Datetime object for when key expires.<br/>
        /// - user_id: (str) Unique user id - used for tracking spend across multiple keys for same user id.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateServiceAccountKeyFnKeyServiceAccountGeneratePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Service Account Key Fn<br/>
        /// Generate a Service Account API key based on the provided data. This key does not belong to any user. It belongs to the team.<br/>
        /// Why use a service account key?<br/>
        /// - Prevent key from being deleted when user is deleted.<br/>
        /// - Apply team limits, not team member limits to key.<br/>
        /// Docs: https://docs.litellm.ai/docs/proxy/virtual_keys<br/>
        /// Parameters:<br/>
        /// - duration: Optional[str] - Specify the length of time the token is valid for. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - key_alias: Optional[str] - User defined key alias<br/>
        /// - key: Optional[str] - User defined key value. Must start with 'sk-' and be at least 16 characters long. If not set, a 16-digit unique sk-key is created for you.<br/>
        /// - team_id: Optional[str] - The team id of the key<br/>
        /// - user_id: Optional[str] - [NON-FUNCTIONAL] THIS WILL BE IGNORED. The user id of the key<br/>
        /// - budget_id: Optional[str] - The budget id associated with the key. Created by calling `/budget/new`.<br/>
        /// - models: Optional[list] - Model_name's a user is allowed to call. (if empty, key is allowed to call all models)<br/>
        /// - aliases: Optional[dict] - Any alias mappings, on top of anything in the config.yaml model list. - https://docs.litellm.ai/docs/proxy/virtual_keys#managing-auth---upgradedowngrade-models<br/>
        /// - config: Optional[dict] - any key-specific configs, overrides config in config.yaml<br/>
        /// - spend: Optional[int] - Amount spent by key. Default is 0. Will be updated by proxy whenever key is used. https://docs.litellm.ai/docs/proxy/virtual_keys#managing-auth---tracking-spend<br/>
        /// - send_invite_email: Optional[bool] - Whether to send an invite email to the user_id, with the generate key<br/>
        /// - max_budget: Optional[float] - Specify max budget for a given key.<br/>
        /// - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - max_parallel_requests: Optional[int] - Rate limit a user based on the number of parallel requests. Raises 429 error, if user's parallel requests &gt; x.<br/>
        /// - metadata: Optional[dict] - Metadata for key, store information for key. Example metadata = {"team": "core-infra", "app": "app2", "email": "ishaan@berri.ai" }<br/>
        /// - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        /// - permissions: Optional[dict] - key-specific permissions. Currently just used for turning off pii masking (if connected). Example - {"pii": false}<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}}. IF null or {} then no model specific budget.<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - model_rpm_limit: Optional[dict] - key-specific model rpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - key-specific model tpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific tpm limit.<br/>
        /// - mcp_rpm_limit: Optional[dict] - key-specific per-MCP-server rpm limit, keyed by MCP server name (alias if set, else the configured name). Example - {"github": 100, "slack": 200}. IF null or {} then no MCP-specific rpm limit.<br/>
        /// - tpm_limit_type: Optional[str] - TPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - rpm_limit_type: Optional[str] - RPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked.<br/>
        /// - rpm_limit: Optional[int] - Specify rpm limit for a given key (Requests per minute)<br/>
        /// - tpm_limit: Optional[int] - Specify tpm limit for a given key (Tokens per minute)<br/>
        /// - soft_budget: Optional[float] - Specify soft budget for a given key. Will trigger a slack alert when this soft budget is reached.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// Examples:<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// 1. Allow users to turn on/off pii masking<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/generate'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "permissions": {"allow_pii_controls": true}<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - key: (str) The generated api key<br/>
        /// - expires: (datetime) Datetime object for when key expires.<br/>
        /// - user_id: (str) Unique user id - used for tracking spend across multiple keys for same user id.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GenerateServiceAccountKeyFnKeyServiceAccountGeneratePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Service Account Key Fn<br/>
        /// Generate a Service Account API key based on the provided data. This key does not belong to any user. It belongs to the team.<br/>
        /// Why use a service account key?<br/>
        /// - Prevent key from being deleted when user is deleted.<br/>
        /// - Apply team limits, not team member limits to key.<br/>
        /// Docs: https://docs.litellm.ai/docs/proxy/virtual_keys<br/>
        /// Parameters:<br/>
        /// - duration: Optional[str] - Specify the length of time the token is valid for. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - key_alias: Optional[str] - User defined key alias<br/>
        /// - key: Optional[str] - User defined key value. Must start with 'sk-' and be at least 16 characters long. If not set, a 16-digit unique sk-key is created for you.<br/>
        /// - team_id: Optional[str] - The team id of the key<br/>
        /// - user_id: Optional[str] - [NON-FUNCTIONAL] THIS WILL BE IGNORED. The user id of the key<br/>
        /// - budget_id: Optional[str] - The budget id associated with the key. Created by calling `/budget/new`.<br/>
        /// - models: Optional[list] - Model_name's a user is allowed to call. (if empty, key is allowed to call all models)<br/>
        /// - aliases: Optional[dict] - Any alias mappings, on top of anything in the config.yaml model list. - https://docs.litellm.ai/docs/proxy/virtual_keys#managing-auth---upgradedowngrade-models<br/>
        /// - config: Optional[dict] - any key-specific configs, overrides config in config.yaml<br/>
        /// - spend: Optional[int] - Amount spent by key. Default is 0. Will be updated by proxy whenever key is used. https://docs.litellm.ai/docs/proxy/virtual_keys#managing-auth---tracking-spend<br/>
        /// - send_invite_email: Optional[bool] - Whether to send an invite email to the user_id, with the generate key<br/>
        /// - max_budget: Optional[float] - Specify max budget for a given key.<br/>
        /// - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - max_parallel_requests: Optional[int] - Rate limit a user based on the number of parallel requests. Raises 429 error, if user's parallel requests &gt; x.<br/>
        /// - metadata: Optional[dict] - Metadata for key, store information for key. Example metadata = {"team": "core-infra", "app": "app2", "email": "ishaan@berri.ai" }<br/>
        /// - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        /// - permissions: Optional[dict] - key-specific permissions. Currently just used for turning off pii masking (if connected). Example - {"pii": false}<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}}. IF null or {} then no model specific budget.<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - model_rpm_limit: Optional[dict] - key-specific model rpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - key-specific model tpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific tpm limit.<br/>
        /// - mcp_rpm_limit: Optional[dict] - key-specific per-MCP-server rpm limit, keyed by MCP server name (alias if set, else the configured name). Example - {"github": 100, "slack": 200}. IF null or {} then no MCP-specific rpm limit.<br/>
        /// - tpm_limit_type: Optional[str] - TPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - rpm_limit_type: Optional[str] - RPM rate limit type - "best_effort_throughput", "guaranteed_throughput", or "dynamic"<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked.<br/>
        /// - rpm_limit: Optional[int] - Specify rpm limit for a given key (Requests per minute)<br/>
        /// - tpm_limit: Optional[int] - Specify tpm limit for a given key (Tokens per minute)<br/>
        /// - soft_budget: Optional[float] - Specify soft budget for a given key. Will trigger a slack alert when this soft budget is reached.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// Examples:<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// 1. Allow users to turn on/off pii masking<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/key/generate'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "permissions": {"allow_pii_controls": true}<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns:<br/>
        /// - key: (str) The generated api key<br/>
        /// - expires: (datetime) Datetime object for when key expires.<br/>
        /// - user_id: (str) Unique user id - used for tracking spend across multiple keys for same user id.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="keyAlias"></param>
        /// <param name="duration"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="spend">
        /// Default Value: 0
        /// </param>
        /// <param name="maxBudget"></param>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="agentId"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="metadata">
        /// Default Value: {}
        /// </param>
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
        /// <param name="softBudget"></param>
        /// <param name="sendInviteEmail"></param>
        /// <param name="keyType">
        /// Type of key that determines default allowed routes.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="autoRotate">
        /// Whether this key should be automatically rotated<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rotationInterval">
        /// How often to rotate this key (e.g., '30d', '90d'). Required if auto_rotate=True
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GenerateServiceAccountKeyFnKeyServiceAccountGeneratePostAsync(
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
            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequestRpmLimitType2? rpmLimitType = default,
            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequestTpmLimitType2? tpmLimitType = default,
            global::Loud.Technology.LiteLLM.Sdk.UpdateRouterConfig? routerSettings = default,
            global::System.Collections.Generic.IList<string>? accessGroupIds = default,
            double? softBudget = default,
            bool? sendInviteEmail = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMKeyType? keyType = default,
            bool? autoRotate = default,
            string? rotationInterval = default,
            string? organizationId = default,
            string? projectId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}