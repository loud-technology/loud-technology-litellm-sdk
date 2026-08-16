
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class TeamManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_NewTeamTeamNewPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_NewTeamTeamNewPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_NewTeamTeamNewPostSecurityRequirement0,
            };
        partial void PrepareNewTeamTeamNewPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? litellmChangedBy,
            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequest request);
        partial void PrepareNewTeamTeamNewPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? litellmChangedBy,
            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequest request);
        partial void ProcessNewTeamTeamNewPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessNewTeamTeamNewPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// New Team<br/>
        /// Allow users to create a new team. Apply user permissions to their team.<br/>
        /// 👉 [Detailed Doc on setting team budgets](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// Parameters:<br/>
        /// - team_alias: Optional[str] - User defined team alias<br/>
        /// - team_id: Optional[str] - The team id of the user. If none passed, we'll generate it.<br/>
        /// - members_with_roles: List[{"role": "admin" or "user", "user_id": "&lt;user-id&gt;"}] - A list of users and their roles in the team. Get user_id when making a new user via `/user/new`.<br/>
        /// - team_member_permissions: Optional[List[str]] - A list of routes that non-admin team members can access. example: ["/key/generate", "/key/update", "/key/delete"]<br/>
        /// - metadata: Optional[dict] - Metadata for team, store information for team. Example metadata = {"extra_info": "some info"}<br/>
        /// - model_rpm_limit: Optional[Dict[str, int]] - The RPM (Requests Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - model_tpm_limit: Optional[Dict[str, int]] - The TPM (Tokens Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - mcp_rpm_limit: Optional[Dict[str, int]] - Per-MCP-server RPM limit for this team, keyed by MCP server name (alias if set, else the configured name). Example: {"github": 100, "slack": 200}. Applied across all keys for this team.<br/>
        /// - tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for this team - all keys with this team_id will have at max this TPM limit<br/>
        /// - rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for this team - all keys associated with this team_id will have at max this RPM limit<br/>
        /// - rpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of RPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating RPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - tpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of TPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating TPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the team - all keys for this team_id will have at max this max_budget<br/>
        /// - soft_budget: Optional[float] - The soft budget threshold for the team. If max_budget is set, soft_budget must be strictly lower than max_budget. Can be set independently if max_budget is not set.<br/>
        /// - budget_duration: Optional[str] - The duration of the budget for the team. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - models: Optional[list] - A list of models associated with the team - all keys for this team_id will have at most, these models. If empty, assumes all models are allowed.<br/>
        /// - blocked: bool - Flag indicating if the team is blocked or not - will stop all calls from keys with this team_id.<br/>
        /// - members: Optional[List] - Control team members via `/team/member/add` and `/team/member/delete`.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the team is allowed to use.<br/>
        /// - organization_id: Optional[str] - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - guardrails: Optional[List[str]] - Guardrails for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails)<br/>
        /// - policies: Optional[List[str]] - Policies for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails/guardrail_policies)<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - team-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - team_member_budget: Optional[float] - The maximum budget allocated to an individual team member.<br/>
        /// - team_member_budget_duration: Optional[str] - The duration of the budget for the team member. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - team_member_rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for individual team members.<br/>
        /// - team_member_tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for individual team members.<br/>
        /// - team_member_key_duration: Optional[str] - The duration for a team member's key. e.g. "1d", "1w", "1mo"<br/>
        /// - allowed_passthrough_routes: Optional[List[str]] - List of allowed pass through routes for the team.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - secret_manager_settings: Optional[dict] - Secret manager settings for the team. [Docs](https://docs.litellm.ai/docs/secret_managers/overview)<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - team-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the team. Access groups define which models the team can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - enforced_file_expires_after: Optional[dict] - Enforced file expiration policy for the team. Keys created under this team will inherit this policy for file uploads. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - enforced_batch_output_expires_after: Optional[dict] - Enforced batch output file expiration policy for the team. Keys created under this team will inherit this policy for batch output files. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the team. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// - default_team_member_models: Optional[List[str]] - Default models assigned to new team members when they join this team. Must be a subset of the team's models.<br/>
        /// Returns:<br/>
        /// - team_id: (str) Unique team id - used for tracking spend across multiple keys for same team id.<br/>
        /// _deprecated_params:<br/>
        /// - admins: list - A list of user_id's for the admin role<br/>
        /// - users: list - A list of user_id's for the user role<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///   "team_alias": "my-new-team_2",<br/>
        ///   "members_with_roles": [{"role": "admin", "user_id": "user-1234"},<br/>
        ///     {"role": "user", "user_id": "user-2434"}]<br/>
        /// }'<br/>
        /// ```<br/>
        ///  ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///             "team_alias": "QA Prod Bot",<br/>
        ///             "max_budget": 0.000000001,<br/>
        ///             "budget_duration": "1d"<br/>
        ///         }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable> NewTeamTeamNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await NewTeamTeamNewPostAsResponseAsync(

                request: request,
                litellmChangedBy: litellmChangedBy,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// New Team<br/>
        /// Allow users to create a new team. Apply user permissions to their team.<br/>
        /// 👉 [Detailed Doc on setting team budgets](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// Parameters:<br/>
        /// - team_alias: Optional[str] - User defined team alias<br/>
        /// - team_id: Optional[str] - The team id of the user. If none passed, we'll generate it.<br/>
        /// - members_with_roles: List[{"role": "admin" or "user", "user_id": "&lt;user-id&gt;"}] - A list of users and their roles in the team. Get user_id when making a new user via `/user/new`.<br/>
        /// - team_member_permissions: Optional[List[str]] - A list of routes that non-admin team members can access. example: ["/key/generate", "/key/update", "/key/delete"]<br/>
        /// - metadata: Optional[dict] - Metadata for team, store information for team. Example metadata = {"extra_info": "some info"}<br/>
        /// - model_rpm_limit: Optional[Dict[str, int]] - The RPM (Requests Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - model_tpm_limit: Optional[Dict[str, int]] - The TPM (Tokens Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - mcp_rpm_limit: Optional[Dict[str, int]] - Per-MCP-server RPM limit for this team, keyed by MCP server name (alias if set, else the configured name). Example: {"github": 100, "slack": 200}. Applied across all keys for this team.<br/>
        /// - tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for this team - all keys with this team_id will have at max this TPM limit<br/>
        /// - rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for this team - all keys associated with this team_id will have at max this RPM limit<br/>
        /// - rpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of RPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating RPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - tpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of TPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating TPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the team - all keys for this team_id will have at max this max_budget<br/>
        /// - soft_budget: Optional[float] - The soft budget threshold for the team. If max_budget is set, soft_budget must be strictly lower than max_budget. Can be set independently if max_budget is not set.<br/>
        /// - budget_duration: Optional[str] - The duration of the budget for the team. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - models: Optional[list] - A list of models associated with the team - all keys for this team_id will have at most, these models. If empty, assumes all models are allowed.<br/>
        /// - blocked: bool - Flag indicating if the team is blocked or not - will stop all calls from keys with this team_id.<br/>
        /// - members: Optional[List] - Control team members via `/team/member/add` and `/team/member/delete`.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the team is allowed to use.<br/>
        /// - organization_id: Optional[str] - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - guardrails: Optional[List[str]] - Guardrails for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails)<br/>
        /// - policies: Optional[List[str]] - Policies for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails/guardrail_policies)<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - team-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - team_member_budget: Optional[float] - The maximum budget allocated to an individual team member.<br/>
        /// - team_member_budget_duration: Optional[str] - The duration of the budget for the team member. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - team_member_rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for individual team members.<br/>
        /// - team_member_tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for individual team members.<br/>
        /// - team_member_key_duration: Optional[str] - The duration for a team member's key. e.g. "1d", "1w", "1mo"<br/>
        /// - allowed_passthrough_routes: Optional[List[str]] - List of allowed pass through routes for the team.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - secret_manager_settings: Optional[dict] - Secret manager settings for the team. [Docs](https://docs.litellm.ai/docs/secret_managers/overview)<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - team-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the team. Access groups define which models the team can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - enforced_file_expires_after: Optional[dict] - Enforced file expiration policy for the team. Keys created under this team will inherit this policy for file uploads. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - enforced_batch_output_expires_after: Optional[dict] - Enforced batch output file expiration policy for the team. Keys created under this team will inherit this policy for batch output files. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the team. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// - default_team_member_models: Optional[List[str]] - Default models assigned to new team members when they join this team. Must be a subset of the team's models.<br/>
        /// Returns:<br/>
        /// - team_id: (str) Unique team id - used for tracking spend across multiple keys for same team id.<br/>
        /// _deprecated_params:<br/>
        /// - admins: list - A list of user_id's for the admin role<br/>
        /// - users: list - A list of user_id's for the user role<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///   "team_alias": "my-new-team_2",<br/>
        ///   "members_with_roles": [{"role": "admin", "user_id": "user-1234"},<br/>
        ///     {"role": "user", "user_id": "user-2434"}]<br/>
        /// }'<br/>
        /// ```<br/>
        ///  ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///             "team_alias": "QA Prod Bot",<br/>
        ///             "max_budget": 0.000000001,<br/>
        ///             "budget_duration": "1d"<br/>
        ///         }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable>> NewTeamTeamNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareNewTeamTeamNewPostArguments(
                httpClient: HttpClient,
                litellmChangedBy: ref litellmChangedBy,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_NewTeamTeamNewPostSecurityRequirements,
                operationName: "NewTeamTeamNewPostAsync");

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
                                path: "/team/new",
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
                PrepareNewTeamTeamNewPostRequest(
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
                                operationId: "NewTeamTeamNewPost",
                                methodName: "NewTeamTeamNewPostAsync",
                                pathTemplate: "\"/team/new\"",
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
                                operationId: "NewTeamTeamNewPost",
                                methodName: "NewTeamTeamNewPostAsync",
                                pathTemplate: "\"/team/new\"",
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
                                operationId: "NewTeamTeamNewPost",
                                methodName: "NewTeamTeamNewPostAsync",
                                pathTemplate: "\"/team/new\"",
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
                ProcessNewTeamTeamNewPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "NewTeamTeamNewPost",
                                methodName: "NewTeamTeamNewPostAsync",
                                pathTemplate: "\"/team/new\"",
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
                                operationId: "NewTeamTeamNewPost",
                                methodName: "NewTeamTeamNewPostAsync",
                                pathTemplate: "\"/team/new\"",
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
                                ProcessNewTeamTeamNewPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable>(
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
        /// New Team<br/>
        /// Allow users to create a new team. Apply user permissions to their team.<br/>
        /// 👉 [Detailed Doc on setting team budgets](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// Parameters:<br/>
        /// - team_alias: Optional[str] - User defined team alias<br/>
        /// - team_id: Optional[str] - The team id of the user. If none passed, we'll generate it.<br/>
        /// - members_with_roles: List[{"role": "admin" or "user", "user_id": "&lt;user-id&gt;"}] - A list of users and their roles in the team. Get user_id when making a new user via `/user/new`.<br/>
        /// - team_member_permissions: Optional[List[str]] - A list of routes that non-admin team members can access. example: ["/key/generate", "/key/update", "/key/delete"]<br/>
        /// - metadata: Optional[dict] - Metadata for team, store information for team. Example metadata = {"extra_info": "some info"}<br/>
        /// - model_rpm_limit: Optional[Dict[str, int]] - The RPM (Requests Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - model_tpm_limit: Optional[Dict[str, int]] - The TPM (Tokens Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - mcp_rpm_limit: Optional[Dict[str, int]] - Per-MCP-server RPM limit for this team, keyed by MCP server name (alias if set, else the configured name). Example: {"github": 100, "slack": 200}. Applied across all keys for this team.<br/>
        /// - tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for this team - all keys with this team_id will have at max this TPM limit<br/>
        /// - rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for this team - all keys associated with this team_id will have at max this RPM limit<br/>
        /// - rpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of RPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating RPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - tpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of TPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating TPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the team - all keys for this team_id will have at max this max_budget<br/>
        /// - soft_budget: Optional[float] - The soft budget threshold for the team. If max_budget is set, soft_budget must be strictly lower than max_budget. Can be set independently if max_budget is not set.<br/>
        /// - budget_duration: Optional[str] - The duration of the budget for the team. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - models: Optional[list] - A list of models associated with the team - all keys for this team_id will have at most, these models. If empty, assumes all models are allowed.<br/>
        /// - blocked: bool - Flag indicating if the team is blocked or not - will stop all calls from keys with this team_id.<br/>
        /// - members: Optional[List] - Control team members via `/team/member/add` and `/team/member/delete`.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the team is allowed to use.<br/>
        /// - organization_id: Optional[str] - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - guardrails: Optional[List[str]] - Guardrails for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails)<br/>
        /// - policies: Optional[List[str]] - Policies for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails/guardrail_policies)<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - team-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - team_member_budget: Optional[float] - The maximum budget allocated to an individual team member.<br/>
        /// - team_member_budget_duration: Optional[str] - The duration of the budget for the team member. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - team_member_rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for individual team members.<br/>
        /// - team_member_tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for individual team members.<br/>
        /// - team_member_key_duration: Optional[str] - The duration for a team member's key. e.g. "1d", "1w", "1mo"<br/>
        /// - allowed_passthrough_routes: Optional[List[str]] - List of allowed pass through routes for the team.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - secret_manager_settings: Optional[dict] - Secret manager settings for the team. [Docs](https://docs.litellm.ai/docs/secret_managers/overview)<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - team-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the team. Access groups define which models the team can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - enforced_file_expires_after: Optional[dict] - Enforced file expiration policy for the team. Keys created under this team will inherit this policy for file uploads. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - enforced_batch_output_expires_after: Optional[dict] - Enforced batch output file expiration policy for the team. Keys created under this team will inherit this policy for batch output files. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the team. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// - default_team_member_models: Optional[List[str]] - Default models assigned to new team members when they join this team. Must be a subset of the team's models.<br/>
        /// Returns:<br/>
        /// - team_id: (str) Unique team id - used for tracking spend across multiple keys for same team id.<br/>
        /// _deprecated_params:<br/>
        /// - admins: list - A list of user_id's for the admin role<br/>
        /// - users: list - A list of user_id's for the user role<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///   "team_alias": "my-new-team_2",<br/>
        ///   "members_with_roles": [{"role": "admin", "user_id": "user-1234"},<br/>
        ///     {"role": "user", "user_id": "user-2434"}]<br/>
        /// }'<br/>
        /// ```<br/>
        ///  ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///             "team_alias": "QA Prod Bot",<br/>
        ///             "max_budget": 0.000000001,<br/>
        ///             "budget_duration": "1d"<br/>
        ///         }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="teamAlias"></param>
        /// <param name="teamId"></param>
        /// <param name="organizationId"></param>
        /// <param name="admins">
        /// Default Value: []
        /// </param>
        /// <param name="members">
        /// Default Value: []
        /// </param>
        /// <param name="membersWithRoles">
        /// Default Value: []
        /// </param>
        /// <param name="teamMemberPermissions"></param>
        /// <param name="metadata"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetLimits"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="blocked">
        /// Default Value: false
        /// </param>
        /// <param name="routerSettings"></param>
        /// <param name="accessGroupIds"></param>
        /// <param name="defaultTeamMemberModels"></param>
        /// <param name="modelAliases"></param>
        /// <param name="tags"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="prompts"></param>
        /// <param name="objectPermission"></param>
        /// <param name="allowedPassthroughRoutes"></param>
        /// <param name="disableGlobalGuardrails"></param>
        /// <param name="secretManagerSettings"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="rpmLimitType"></param>
        /// <param name="tpmLimitType"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="mcpRpmLimit"></param>
        /// <param name="teamMemberBudget"></param>
        /// <param name="teamMemberRpmLimit"></param>
        /// <param name="teamMemberTpmLimit"></param>
        /// <param name="teamMemberKeyDuration"></param>
        /// <param name="teamMemberBudgetDuration"></param>
        /// <param name="allowedVectorStoreIndexes"></param>
        /// <param name="enforcedBatchOutputExpiresAfter"></param>
        /// <param name="enforcedFileExpiresAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable> NewTeamTeamNewPostAsync(
            string? litellmChangedBy = default,
            string? teamAlias = default,
            string? teamId = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<object>? admins = default,
            global::System.Collections.Generic.IList<object>? members = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>? membersWithRoles = default,
            global::System.Collections.Generic.IList<string>? teamMemberPermissions = default,
            object? metadata = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            double? maxBudget = default,
            double? softBudget = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? budgetLimits = default,
            global::System.Collections.Generic.IList<object>? models = default,
            bool? blocked = default,
            object? routerSettings = default,
            global::System.Collections.Generic.IList<string>? accessGroupIds = default,
            global::System.Collections.Generic.IList<string>? defaultTeamMemberModels = default,
            object? modelAliases = default,
            global::System.Collections.Generic.IList<object>? tags = default,
            global::System.Collections.Generic.IList<string>? guardrails = default,
            global::System.Collections.Generic.IList<string>? policies = default,
            global::System.Collections.Generic.IList<string>? prompts = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::System.Collections.Generic.IList<object>? allowedPassthroughRoutes = default,
            bool? disableGlobalGuardrails = default,
            object? secretManagerSettings = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelRpmLimit = default,
            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequestRpmLimitType2? rpmLimitType = default,
            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequestTpmLimitType2? tpmLimitType = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelTpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, int>? mcpRpmLimit = default,
            double? teamMemberBudget = default,
            int? teamMemberRpmLimit = default,
            int? teamMemberTpmLimit = default,
            string? teamMemberKeyDuration = default,
            string? teamMemberBudgetDuration = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? allowedVectorStoreIndexes = default,
            object? enforcedBatchOutputExpiresAfter = default,
            object? enforcedFileExpiresAfter = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.NewTeamRequest
            {
                TeamAlias = teamAlias,
                TeamId = teamId,
                OrganizationId = organizationId,
                Admins = admins,
                Members = members,
                MembersWithRoles = membersWithRoles,
                TeamMemberPermissions = teamMemberPermissions,
                Metadata = metadata,
                TpmLimit = tpmLimit,
                RpmLimit = rpmLimit,
                MaxBudget = maxBudget,
                SoftBudget = softBudget,
                BudgetDuration = budgetDuration,
                BudgetLimits = budgetLimits,
                Models = models,
                Blocked = blocked,
                RouterSettings = routerSettings,
                AccessGroupIds = accessGroupIds,
                DefaultTeamMemberModels = defaultTeamMemberModels,
                ModelAliases = modelAliases,
                Tags = tags,
                Guardrails = guardrails,
                Policies = policies,
                Prompts = prompts,
                ObjectPermission = objectPermission,
                AllowedPassthroughRoutes = allowedPassthroughRoutes,
                DisableGlobalGuardrails = disableGlobalGuardrails,
                SecretManagerSettings = secretManagerSettings,
                ModelRpmLimit = modelRpmLimit,
                RpmLimitType = rpmLimitType,
                TpmLimitType = tpmLimitType,
                ModelTpmLimit = modelTpmLimit,
                McpRpmLimit = mcpRpmLimit,
                TeamMemberBudget = teamMemberBudget,
                TeamMemberRpmLimit = teamMemberRpmLimit,
                TeamMemberTpmLimit = teamMemberTpmLimit,
                TeamMemberKeyDuration = teamMemberKeyDuration,
                TeamMemberBudgetDuration = teamMemberBudgetDuration,
                AllowedVectorStoreIndexes = allowedVectorStoreIndexes,
                EnforcedBatchOutputExpiresAfter = enforcedBatchOutputExpiresAfter,
                EnforcedFileExpiresAfter = enforcedFileExpiresAfter,
            };

            return await NewTeamTeamNewPostAsync(
                litellmChangedBy: litellmChangedBy,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}