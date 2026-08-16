
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class InternalUserManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_UserUpdateUserUpdatePostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_UserUpdateUserUpdatePostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_UserUpdateUserUpdatePostSecurityRequirement0,
            };
        partial void PrepareUserUpdateUserUpdatePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest request);
        partial void PrepareUserUpdateUserUpdatePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest request);
        partial void ProcessUserUpdateUserUpdatePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUserUpdateUserUpdatePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<string> UserUpdateUserUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UserUpdateUserUpdatePostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UserUpdateUserUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUserUpdateUserUpdatePostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UserUpdateUserUpdatePostSecurityRequirements,
                operationName: "UserUpdateUserUpdatePostAsync");

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
                                path: "/user/update",
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
                PrepareUserUpdateUserUpdatePostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "UserUpdateUserUpdatePost",
                                methodName: "UserUpdateUserUpdatePostAsync",
                                pathTemplate: "\"/user/update\"",
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
                                operationId: "UserUpdateUserUpdatePost",
                                methodName: "UserUpdateUserUpdatePostAsync",
                                pathTemplate: "\"/user/update\"",
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
                                operationId: "UserUpdateUserUpdatePost",
                                methodName: "UserUpdateUserUpdatePostAsync",
                                pathTemplate: "\"/user/update\"",
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
                ProcessUserUpdateUserUpdatePostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UserUpdateUserUpdatePost",
                                methodName: "UserUpdateUserUpdatePostAsync",
                                pathTemplate: "\"/user/update\"",
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
                                operationId: "UserUpdateUserUpdatePost",
                                methodName: "UserUpdateUserUpdatePostAsync",
                                pathTemplate: "\"/user/update\"",
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
                                ProcessUserUpdateUserUpdatePostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
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
                                    var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __content);
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
        public async global::System.Threading.Tasks.Task<string> UserUpdateUserUpdatePostAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest
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
                Password = password,
                UserAlias = userAlias,
                UserRole = userRole,
                UserEmail = userEmail,
            };

            return await UserUpdateUserUpdatePostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}