
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class KeyManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_GenerateKeyFnKeyGeneratePostSecurityRequirement0 =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Loud.Technology.LiteLLM.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Loud.Technology.LiteLLM.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_GenerateKeyFnKeyGeneratePostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_GenerateKeyFnKeyGeneratePostSecurityRequirement0,
            };
        partial void PrepareGenerateKeyFnKeyGeneratePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? litellmChangedBy,
            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequest request);
        partial void PrepareGenerateKeyFnKeyGeneratePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? litellmChangedBy,
            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequest request);
        partial void ProcessGenerateKeyFnKeyGeneratePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateKeyFnKeyGeneratePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Key Fn<br/>
        /// Generate an API key based on the provided data.<br/>
        /// Docs: https://docs.litellm.ai/docs/proxy/virtual_keys<br/>
        /// Parameters:<br/>
        /// - duration: Optional[str] - Specify the length of time the token is valid for. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - key_alias: Optional[str] - User defined key alias<br/>
        /// - key: Optional[str] - User defined key value. Must start with 'sk-' and be at least 16 characters long. If not set, a 16-digit unique sk-key is created for you.<br/>
        /// - team_id: Optional[str] - The team id of the key<br/>
        /// - user_id: Optional[str] - The user id of the key<br/>
        /// - agent_id: Optional[str] - The agent id associated with the key.<br/>
        /// - organization_id: Optional[str] - The organization id of the key. If not set, and team_id is set, the organization id will be the same as the team id. If conflict, an error will be raised.<br/>
        /// - project_id: Optional[str] - The project id of the key. When set, models and max_budget are validated against the project's limits.<br/>
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
        /// - policies: Optional[List[str]] - List of policy names to apply to the key. Policies define guardrails, conditions, and inheritance rules.<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - throttle_on_budget_exceeded: Optional[bool] - When the key exceeds its max_budget, throttle its tpm/rpm to the global budget_exceeded_throttle_percentage instead of blocking the key entirely.<br/>
        /// - permissions: Optional[dict] - key-specific permissions. Currently just used for turning off pii masking (if connected). Example - {"pii": false}<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}}. IF null or {} then no model specific budget.<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - model_rpm_limit: Optional[dict] - key-specific model rpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - key-specific model tpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific tpm limit.<br/>
        /// - mcp_rpm_limit: Optional[dict] - key-specific per-MCP-server rpm limit, keyed by MCP server name (alias if set, else the configured name). Example - {"github": 100, "slack": 200}. IF null or {} then no MCP-specific rpm limit.<br/>
        /// - tag_rpm_limit: Optional[dict] - key-specific per-request-tag rpm limit, keyed by request tag. Example - {"cell-1": 1000, "cell-2": 500}. Each tag gets an independent counter; requests whose tag is absent fall back to the key-level rpm limit.<br/>
        /// - tpm_limit_type: Optional[str] - Type of tpm limit. Options: "best_effort_throughput" (no error if we're overallocating tpm), "guaranteed_throughput" (raise an error if we're overallocating tpm), "dynamic" (dynamically exceed limit when no 429 errors). Defaults to "best_effort_throughput".<br/>
        /// - rpm_limit_type: Optional[str] - Type of rpm limit. Options: "best_effort_throughput" (no error if we're overallocating rpm), "guaranteed_throughput" (raise an error if we're overallocating rpm), "dynamic" (dynamically exceed limit when no 429 errors). Defaults to "best_effort_throughput".<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked.<br/>
        /// - rpm_limit: Optional[int] - Specify rpm limit for a given key (Requests per minute)<br/>
        /// - tpm_limit: Optional[int] - Specify tpm limit for a given key (Tokens per minute)<br/>
        /// - soft_budget: Optional[float] - Specify soft budget for a given key. Will trigger a slack alert when this soft budget is reached.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - allowed_passthrough_routes: Optional[list] - List of allowed pass through endpoints for the key. Store the actual endpoint or store a wildcard pattern for a set of endpoints. Example - ["/my-custom-endpoint"]. Use this instead of allowed_routes, if you just want to specify which pass through endpoints the key can access, without specifying the routes. If allowed_routes is specified, allowed_pass_through_endpoints is ignored.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - key_type: Optional[str] - Type of key that determines default allowed routes. Options: "llm_api" (can call LLM API routes), "management" (can call management routes), "read_only" (can only call info/read routes), "default" (uses default allowed routes). Defaults to "default".<br/>
        /// - prompts: Optional[List[str]] - List of allowed prompts for the key. If specified, the key will only be able to use these specific prompts.<br/>
        /// - auto_rotate: Optional[bool] - Whether this key should be automatically rotated (regenerated)<br/>
        /// - rotation_interval: Optional[str] - How often to auto-rotate this key (e.g., '30s', '30m', '30h', '30d'). Required if auto_rotate=True.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - key-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the key. Access groups define which models a key can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the key. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// Examples:<br/>
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
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse> GenerateKeyFnKeyGeneratePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GenerateKeyFnKeyGeneratePostAsResponseAsync(

                request: request,
                litellmChangedBy: litellmChangedBy,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Generate Key Fn<br/>
        /// Generate an API key based on the provided data.<br/>
        /// Docs: https://docs.litellm.ai/docs/proxy/virtual_keys<br/>
        /// Parameters:<br/>
        /// - duration: Optional[str] - Specify the length of time the token is valid for. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - key_alias: Optional[str] - User defined key alias<br/>
        /// - key: Optional[str] - User defined key value. Must start with 'sk-' and be at least 16 characters long. If not set, a 16-digit unique sk-key is created for you.<br/>
        /// - team_id: Optional[str] - The team id of the key<br/>
        /// - user_id: Optional[str] - The user id of the key<br/>
        /// - agent_id: Optional[str] - The agent id associated with the key.<br/>
        /// - organization_id: Optional[str] - The organization id of the key. If not set, and team_id is set, the organization id will be the same as the team id. If conflict, an error will be raised.<br/>
        /// - project_id: Optional[str] - The project id of the key. When set, models and max_budget are validated against the project's limits.<br/>
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
        /// - policies: Optional[List[str]] - List of policy names to apply to the key. Policies define guardrails, conditions, and inheritance rules.<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - throttle_on_budget_exceeded: Optional[bool] - When the key exceeds its max_budget, throttle its tpm/rpm to the global budget_exceeded_throttle_percentage instead of blocking the key entirely.<br/>
        /// - permissions: Optional[dict] - key-specific permissions. Currently just used for turning off pii masking (if connected). Example - {"pii": false}<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}}. IF null or {} then no model specific budget.<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - model_rpm_limit: Optional[dict] - key-specific model rpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - key-specific model tpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific tpm limit.<br/>
        /// - mcp_rpm_limit: Optional[dict] - key-specific per-MCP-server rpm limit, keyed by MCP server name (alias if set, else the configured name). Example - {"github": 100, "slack": 200}. IF null or {} then no MCP-specific rpm limit.<br/>
        /// - tag_rpm_limit: Optional[dict] - key-specific per-request-tag rpm limit, keyed by request tag. Example - {"cell-1": 1000, "cell-2": 500}. Each tag gets an independent counter; requests whose tag is absent fall back to the key-level rpm limit.<br/>
        /// - tpm_limit_type: Optional[str] - Type of tpm limit. Options: "best_effort_throughput" (no error if we're overallocating tpm), "guaranteed_throughput" (raise an error if we're overallocating tpm), "dynamic" (dynamically exceed limit when no 429 errors). Defaults to "best_effort_throughput".<br/>
        /// - rpm_limit_type: Optional[str] - Type of rpm limit. Options: "best_effort_throughput" (no error if we're overallocating rpm), "guaranteed_throughput" (raise an error if we're overallocating rpm), "dynamic" (dynamically exceed limit when no 429 errors). Defaults to "best_effort_throughput".<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked.<br/>
        /// - rpm_limit: Optional[int] - Specify rpm limit for a given key (Requests per minute)<br/>
        /// - tpm_limit: Optional[int] - Specify tpm limit for a given key (Tokens per minute)<br/>
        /// - soft_budget: Optional[float] - Specify soft budget for a given key. Will trigger a slack alert when this soft budget is reached.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - allowed_passthrough_routes: Optional[list] - List of allowed pass through endpoints for the key. Store the actual endpoint or store a wildcard pattern for a set of endpoints. Example - ["/my-custom-endpoint"]. Use this instead of allowed_routes, if you just want to specify which pass through endpoints the key can access, without specifying the routes. If allowed_routes is specified, allowed_pass_through_endpoints is ignored.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - key_type: Optional[str] - Type of key that determines default allowed routes. Options: "llm_api" (can call LLM API routes), "management" (can call management routes), "read_only" (can only call info/read routes), "default" (uses default allowed routes). Defaults to "default".<br/>
        /// - prompts: Optional[List[str]] - List of allowed prompts for the key. If specified, the key will only be able to use these specific prompts.<br/>
        /// - auto_rotate: Optional[bool] - Whether this key should be automatically rotated (regenerated)<br/>
        /// - rotation_interval: Optional[str] - How often to auto-rotate this key (e.g., '30s', '30m', '30h', '30d'). Required if auto_rotate=True.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - key-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the key. Access groups define which models a key can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the key. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// Examples:<br/>
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
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse>> GenerateKeyFnKeyGeneratePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateKeyFnKeyGeneratePostArguments(
                httpClient: HttpClient,
                litellmChangedBy: ref litellmChangedBy,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GenerateKeyFnKeyGeneratePostSecurityRequirements,
                operationName: "GenerateKeyFnKeyGeneratePostAsync");

            using var __timeoutCancellationTokenSource = global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Loud.Technology.LiteLLM.Sdk.PathBuilder(
                                path: "/key/generate",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

            if (litellmChangedBy != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("litellm-changed-by", litellmChangedBy.ToString());
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGenerateKeyFnKeyGeneratePostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    litellmChangedBy: litellmChangedBy,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateKeyFnKeyGeneratePost",
                                methodName: "GenerateKeyFnKeyGeneratePostAsync",
                                pathTemplate: "\"/key/generate\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateKeyFnKeyGeneratePost",
                                methodName: "GenerateKeyFnKeyGeneratePostAsync",
                                pathTemplate: "\"/key/generate\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateKeyFnKeyGeneratePost",
                                methodName: "GenerateKeyFnKeyGeneratePostAsync",
                                pathTemplate: "\"/key/generate\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGenerateKeyFnKeyGeneratePostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateKeyFnKeyGeneratePost",
                                methodName: "GenerateKeyFnKeyGeneratePostAsync",
                                pathTemplate: "\"/key/generate\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GenerateKeyFnKeyGeneratePost",
                                methodName: "GenerateKeyFnKeyGeneratePostAsync",
                                pathTemplate: "\"/key/generate\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Loud.Technology.LiteLLM.Sdk.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Loud.Technology.LiteLLM.Sdk.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Loud.Technology.LiteLLM.Sdk.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Loud.Technology.LiteLLM.Sdk.ApiException<global::Loud.Technology.LiteLLM.Sdk.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGenerateKeyFnKeyGeneratePostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Loud.Technology.LiteLLM.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Loud.Technology.LiteLLM.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Generate Key Fn<br/>
        /// Generate an API key based on the provided data.<br/>
        /// Docs: https://docs.litellm.ai/docs/proxy/virtual_keys<br/>
        /// Parameters:<br/>
        /// - duration: Optional[str] - Specify the length of time the token is valid for. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - key_alias: Optional[str] - User defined key alias<br/>
        /// - key: Optional[str] - User defined key value. Must start with 'sk-' and be at least 16 characters long. If not set, a 16-digit unique sk-key is created for you.<br/>
        /// - team_id: Optional[str] - The team id of the key<br/>
        /// - user_id: Optional[str] - The user id of the key<br/>
        /// - agent_id: Optional[str] - The agent id associated with the key.<br/>
        /// - organization_id: Optional[str] - The organization id of the key. If not set, and team_id is set, the organization id will be the same as the team id. If conflict, an error will be raised.<br/>
        /// - project_id: Optional[str] - The project id of the key. When set, models and max_budget are validated against the project's limits.<br/>
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
        /// - policies: Optional[List[str]] - List of policy names to apply to the key. Policies define guardrails, conditions, and inheritance rules.<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - throttle_on_budget_exceeded: Optional[bool] - When the key exceeds its max_budget, throttle its tpm/rpm to the global budget_exceeded_throttle_percentage instead of blocking the key entirely.<br/>
        /// - permissions: Optional[dict] - key-specific permissions. Currently just used for turning off pii masking (if connected). Example - {"pii": false}<br/>
        /// - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}}. IF null or {} then no model specific budget.<br/>
        /// - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        /// - model_rpm_limit: Optional[dict] - key-specific model rpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific rpm limit.<br/>
        /// - model_tpm_limit: Optional[dict] - key-specific model tpm limit. Example - {"text-davinci-002": 1000, "gpt-3.5-turbo": 1000}. IF null or {} then no model specific tpm limit.<br/>
        /// - mcp_rpm_limit: Optional[dict] - key-specific per-MCP-server rpm limit, keyed by MCP server name (alias if set, else the configured name). Example - {"github": 100, "slack": 200}. IF null or {} then no MCP-specific rpm limit.<br/>
        /// - tag_rpm_limit: Optional[dict] - key-specific per-request-tag rpm limit, keyed by request tag. Example - {"cell-1": 1000, "cell-2": 500}. Each tag gets an independent counter; requests whose tag is absent fall back to the key-level rpm limit.<br/>
        /// - tpm_limit_type: Optional[str] - Type of tpm limit. Options: "best_effort_throughput" (no error if we're overallocating tpm), "guaranteed_throughput" (raise an error if we're overallocating tpm), "dynamic" (dynamically exceed limit when no 429 errors). Defaults to "best_effort_throughput".<br/>
        /// - rpm_limit_type: Optional[str] - Type of rpm limit. Options: "best_effort_throughput" (no error if we're overallocating rpm), "guaranteed_throughput" (raise an error if we're overallocating rpm), "dynamic" (dynamically exceed limit when no 429 errors). Defaults to "best_effort_throughput".<br/>
        /// - allowed_cache_controls: Optional[list] - List of allowed cache control values. Example - ["no-cache", "no-store"]. See all values - https://docs.litellm.ai/docs/proxy/caching#turn-on--off-caching-per-request<br/>
        /// - blocked: Optional[bool] - Whether the key is blocked.<br/>
        /// - rpm_limit: Optional[int] - Specify rpm limit for a given key (Requests per minute)<br/>
        /// - tpm_limit: Optional[int] - Specify tpm limit for a given key (Tokens per minute)<br/>
        /// - soft_budget: Optional[float] - Specify soft budget for a given key. Will trigger a slack alert when this soft budget is reached.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - enforced_params: Optional[List[str]] - List of enforced params for the key (Enterprise only). [Docs](https://docs.litellm.ai/docs/proxy/enterprise#enforce-required-params-for-llm-requests)<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the key is allowed to use.<br/>
        /// - allowed_routes: Optional[list] - List of allowed routes for the key. Store the actual route or store a wildcard pattern for a set of routes. Example - ["/chat/completions", "/embeddings", "/keys/*"]<br/>
        /// - allowed_passthrough_routes: Optional[list] - List of allowed pass through endpoints for the key. Store the actual endpoint or store a wildcard pattern for a set of endpoints. Example - ["/my-custom-endpoint"]. Use this instead of allowed_routes, if you just want to specify which pass through endpoints the key can access, without specifying the routes. If allowed_routes is specified, allowed_pass_through_endpoints is ignored.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - key-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - key_type: Optional[str] - Type of key that determines default allowed routes. Options: "llm_api" (can call LLM API routes), "management" (can call management routes), "read_only" (can only call info/read routes), "default" (uses default allowed routes). Defaults to "default".<br/>
        /// - prompts: Optional[List[str]] - List of allowed prompts for the key. If specified, the key will only be able to use these specific prompts.<br/>
        /// - auto_rotate: Optional[bool] - Whether this key should be automatically rotated (regenerated)<br/>
        /// - rotation_interval: Optional[str] - How often to auto-rotate this key (e.g., '30s', '30m', '30h', '30d'). Required if auto_rotate=True.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - key-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the key. Access groups define which models a key can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the key. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// Examples:<br/>
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
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse> GenerateKeyFnKeyGeneratePostAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.GenerateKeyRequest
            {
                KeyAlias = keyAlias,
                Duration = duration,
                Models = models,
                Spend = spend,
                MaxBudget = maxBudget,
                UserId = userId,
                TeamId = teamId,
                AgentId = agentId,
                MaxParallelRequests = maxParallelRequests,
                Metadata = metadata,
                TpmLimit = tpmLimit,
                RpmLimit = rpmLimit,
                BudgetDuration = budgetDuration,
                BudgetLimits = budgetLimits,
                AllowedCacheControls = allowedCacheControls,
                Config = config,
                Permissions = permissions,
                ModelMaxBudget = modelMaxBudget,
                BudgetFallbacks = budgetFallbacks,
                ModelRpmLimit = modelRpmLimit,
                ModelTpmLimit = modelTpmLimit,
                McpRpmLimit = mcpRpmLimit,
                TagRpmLimit = tagRpmLimit,
                Guardrails = guardrails,
                Policies = policies,
                Prompts = prompts,
                Blocked = blocked,
                Aliases = aliases,
                ObjectPermission = objectPermission,
                Key = key,
                BudgetId = budgetId,
                Tags = tags,
                DisableGlobalGuardrails = disableGlobalGuardrails,
                ThrottleOnBudgetExceeded = throttleOnBudgetExceeded,
                EnforcedParams = enforcedParams,
                AllowedRoutes = allowedRoutes,
                AllowedPassthroughRoutes = allowedPassthroughRoutes,
                AllowedVectorStoreIndexes = allowedVectorStoreIndexes,
                RpmLimitType = rpmLimitType,
                TpmLimitType = tpmLimitType,
                RouterSettings = routerSettings,
                AccessGroupIds = accessGroupIds,
                SoftBudget = softBudget,
                SendInviteEmail = sendInviteEmail,
                KeyType = keyType,
                AutoRotate = autoRotate,
                RotationInterval = rotationInterval,
                OrganizationId = organizationId,
                ProjectId = projectId,
            };

            return await GenerateKeyFnKeyGeneratePostAsync(
                litellmChangedBy: litellmChangedBy,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}