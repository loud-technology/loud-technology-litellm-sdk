
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class ModelManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_ModelInfoV2V2ModelInfoGetSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_ModelInfoV2V2ModelInfoGetSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_ModelInfoV2V2ModelInfoGetSecurityRequirement0,
            };
        partial void PrepareModelInfoV2V2ModelInfoGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? model,
            bool? userModelsOnly,
            bool? includeTeamModels,
            bool? debug,
            ref int? page,
            ref int? size,
            ref string? search,
            ref string? modelId,
            ref string? teamId,
            ref string? sortBy,
            ref string? sortOrder,
            bool? excludeAutoRouters);
        partial void PrepareModelInfoV2V2ModelInfoGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? model,
            bool? userModelsOnly,
            bool? includeTeamModels,
            bool? debug,
            int? page,
            int? size,
            string? search,
            string? modelId,
            string? teamId,
            string? sortBy,
            string? sortOrder,
            bool? excludeAutoRouters);
        partial void ProcessModelInfoV2V2ModelInfoGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelInfoV2V2ModelInfoGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Model Info V2<br/>
        /// Paginated model metadata for proxy deployments (pricing, provider, team access).<br/>
        /// Returns configured router deployments with enriched `model_info` (costs, provider,<br/>
        /// context window, etc.). Sensitive fields such as API keys and api_base are omitted.<br/>
        /// Query parameters:<br/>
        ///     model: Filter to a single public `model_name`.<br/>
        ///     user_models_only: When true, only return models created by the calling user.<br/>
        ///     include_team_models: When true, populate `access_via_team_ids` and `direct_access`<br/>
        ///         on each model and filter to deployments the caller can use.<br/>
        ///     page / size: Pagination controls (defaults: page=1, size=50).<br/>
        ///     search: Case-insensitive partial match on model name or team public name.<br/>
        ///     modelId: Return a single deployment by LiteLLM model id.<br/>
        ///     teamId: Filter to models with direct access or team membership for this team id.<br/>
        ///     sortBy / sortOrder: Sort by model_name, created_at, updated_at, costs, or status.<br/>
        /// Example request:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/v2/model/info?include_team_models=true&amp;page=1&amp;size=50' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Example response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "data": [<br/>
        ///         {<br/>
        ///             "model_name": "gpt-4",<br/>
        ///             "litellm_params": {"model": "openai/gpt-4.1"},<br/>
        ///             "model_info": {<br/>
        ///                 "id": "abc123",<br/>
        ///                 "litellm_provider": "openai",<br/>
        ///                 "access_via_team_ids": ["team-1"],<br/>
        ///                 "direct_access": true<br/>
        ///             }<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "total_count": 1,<br/>
        ///     "current_page": 1,<br/>
        ///     "total_pages": 1,<br/>
        ///     "size": 50<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="model">
        /// Specify the model name (optional)
        /// </param>
        /// <param name="userModelsOnly">
        /// Only return models added by this user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTeamModels">
        /// Return all models across all teams user is in.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="debug">
        /// Default Value: false
        /// </param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Search model names (case-insensitive partial match)
        /// </param>
        /// <param name="modelId">
        /// Search for a specific model by its unique ID
        /// </param>
        /// <param name="teamId">
        /// Filter models by team ID. Returns models with direct_access=True or teamId in access_via_team_ids
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by. Options: model_name, created_at, updated_at, costs, status
        /// </param>
        /// <param name="sortOrder">
        /// Sort order. Options: asc, desc<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="excludeAutoRouters">
        /// Omit auto-router deployments (litellm model prefixed `auto_router/`). They select among deployments rather than being deployments themselves, so a caller rendering a deployment list can leave them out. Defaults to false, so existing callers are unaffected<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> ModelInfoV2V2ModelInfoGetAsync(
            string? model = default,
            bool? userModelsOnly = default,
            bool? includeTeamModels = default,
            bool? debug = default,
            int? page = default,
            int? size = default,
            string? search = default,
            string? modelId = default,
            string? teamId = default,
            string? sortBy = default,
            string? sortOrder = default,
            bool? excludeAutoRouters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ModelInfoV2V2ModelInfoGetAsResponseAsync(
                model: model,
                userModelsOnly: userModelsOnly,
                includeTeamModels: includeTeamModels,
                debug: debug,
                page: page,
                size: size,
                search: search,
                modelId: modelId,
                teamId: teamId,
                sortBy: sortBy,
                sortOrder: sortOrder,
                excludeAutoRouters: excludeAutoRouters,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Model Info V2<br/>
        /// Paginated model metadata for proxy deployments (pricing, provider, team access).<br/>
        /// Returns configured router deployments with enriched `model_info` (costs, provider,<br/>
        /// context window, etc.). Sensitive fields such as API keys and api_base are omitted.<br/>
        /// Query parameters:<br/>
        ///     model: Filter to a single public `model_name`.<br/>
        ///     user_models_only: When true, only return models created by the calling user.<br/>
        ///     include_team_models: When true, populate `access_via_team_ids` and `direct_access`<br/>
        ///         on each model and filter to deployments the caller can use.<br/>
        ///     page / size: Pagination controls (defaults: page=1, size=50).<br/>
        ///     search: Case-insensitive partial match on model name or team public name.<br/>
        ///     modelId: Return a single deployment by LiteLLM model id.<br/>
        ///     teamId: Filter to models with direct access or team membership for this team id.<br/>
        ///     sortBy / sortOrder: Sort by model_name, created_at, updated_at, costs, or status.<br/>
        /// Example request:<br/>
        /// ```<br/>
        /// curl -X GET 'http://localhost:4000/v2/model/info?include_team_models=true&amp;page=1&amp;size=50' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Example response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "data": [<br/>
        ///         {<br/>
        ///             "model_name": "gpt-4",<br/>
        ///             "litellm_params": {"model": "openai/gpt-4.1"},<br/>
        ///             "model_info": {<br/>
        ///                 "id": "abc123",<br/>
        ///                 "litellm_provider": "openai",<br/>
        ///                 "access_via_team_ids": ["team-1"],<br/>
        ///                 "direct_access": true<br/>
        ///             }<br/>
        ///         }<br/>
        ///     ],<br/>
        ///     "total_count": 1,<br/>
        ///     "current_page": 1,<br/>
        ///     "total_pages": 1,<br/>
        ///     "size": 50<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="model">
        /// Specify the model name (optional)
        /// </param>
        /// <param name="userModelsOnly">
        /// Only return models added by this user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTeamModels">
        /// Return all models across all teams user is in.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="debug">
        /// Default Value: false
        /// </param>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Search model names (case-insensitive partial match)
        /// </param>
        /// <param name="modelId">
        /// Search for a specific model by its unique ID
        /// </param>
        /// <param name="teamId">
        /// Filter models by team ID. Returns models with direct_access=True or teamId in access_via_team_ids
        /// </param>
        /// <param name="sortBy">
        /// Field to sort by. Options: model_name, created_at, updated_at, costs, status
        /// </param>
        /// <param name="sortOrder">
        /// Sort order. Options: asc, desc<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="excludeAutoRouters">
        /// Omit auto-router deployments (litellm model prefixed `auto_router/`). They select among deployments rather than being deployments themselves, so a caller rendering a deployment list can leave them out. Defaults to false, so existing callers are unaffected<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ModelInfoV2V2ModelInfoGetAsResponseAsync(
            string? model = default,
            bool? userModelsOnly = default,
            bool? includeTeamModels = default,
            bool? debug = default,
            int? page = default,
            int? size = default,
            string? search = default,
            string? modelId = default,
            string? teamId = default,
            string? sortBy = default,
            string? sortOrder = default,
            bool? excludeAutoRouters = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareModelInfoV2V2ModelInfoGetArguments(
                httpClient: HttpClient,
                model: ref model,
                userModelsOnly: userModelsOnly,
                includeTeamModels: includeTeamModels,
                debug: debug,
                page: ref page,
                size: ref size,
                search: ref search,
                modelId: ref modelId,
                teamId: ref teamId,
                sortBy: ref sortBy,
                sortOrder: ref sortOrder,
                excludeAutoRouters: excludeAutoRouters);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ModelInfoV2V2ModelInfoGetSecurityRequirements,
                operationName: "ModelInfoV2V2ModelInfoGetAsync");

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
                                path: "/v2/model/info",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("model", model)
                                .AddOptionalParameter("user_models_only", userModelsOnly?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("include_team_models", includeTeamModels?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("debug", debug?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("size", size?.ToString())
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("modelId", modelId)
                                .AddOptionalParameter("teamId", teamId)
                                .AddOptionalParameter("sortBy", sortBy)
                                .AddOptionalParameter("sortOrder", sortOrder)
                                .AddOptionalParameter("exclude_auto_routers", excludeAutoRouters?.ToString().ToLowerInvariant())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
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
                global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareModelInfoV2V2ModelInfoGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    model: model,
                    userModelsOnly: userModelsOnly,
                    includeTeamModels: includeTeamModels,
                    debug: debug,
                    page: page,
                    size: size,
                    search: search,
                    modelId: modelId,
                    teamId: teamId,
                    sortBy: sortBy,
                    sortOrder: sortOrder,
                    excludeAutoRouters: excludeAutoRouters);

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
                                operationId: "ModelInfoV2V2ModelInfoGet",
                                methodName: "ModelInfoV2V2ModelInfoGetAsync",
                                pathTemplate: "\"/v2/model/info\"",
                                httpMethod: "GET",
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
                                operationId: "ModelInfoV2V2ModelInfoGet",
                                methodName: "ModelInfoV2V2ModelInfoGetAsync",
                                pathTemplate: "\"/v2/model/info\"",
                                httpMethod: "GET",
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
                                operationId: "ModelInfoV2V2ModelInfoGet",
                                methodName: "ModelInfoV2V2ModelInfoGetAsync",
                                pathTemplate: "\"/v2/model/info\"",
                                httpMethod: "GET",
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
                ProcessModelInfoV2V2ModelInfoGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ModelInfoV2V2ModelInfoGet",
                                methodName: "ModelInfoV2V2ModelInfoGetAsync",
                                pathTemplate: "\"/v2/model/info\"",
                                httpMethod: "GET",
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
                                operationId: "ModelInfoV2V2ModelInfoGet",
                                methodName: "ModelInfoV2V2ModelInfoGetAsync",
                                pathTemplate: "\"/v2/model/info\"",
                                httpMethod: "GET",
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
                                ProcessModelInfoV2V2ModelInfoGetResponseContent(
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
    }
}