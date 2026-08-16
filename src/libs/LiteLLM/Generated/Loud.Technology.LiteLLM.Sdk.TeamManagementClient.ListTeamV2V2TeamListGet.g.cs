
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class TeamManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_ListTeamV2V2TeamListGetSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_ListTeamV2V2TeamListGetSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_ListTeamV2V2TeamListGetSecurityRequirement0,
            };
        partial void PrepareListTeamV2V2TeamListGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? userId,
            ref string? organizationId,
            ref string? teamId,
            ref string? teamAlias,
            ref string? search,
            ref global::Loud.Technology.LiteLLM.Sdk.ListTeamV2V2TeamListGetSearchTeamIdMatch? searchTeamIdMatch,
            ref int? page,
            ref int? pageSize,
            ref string? sortBy,
            ref string? sortOrder,
            ref string? status);
        partial void PrepareListTeamV2V2TeamListGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? userId,
            string? organizationId,
            string? teamId,
            string? teamAlias,
            string? search,
            global::Loud.Technology.LiteLLM.Sdk.ListTeamV2V2TeamListGetSearchTeamIdMatch? searchTeamIdMatch,
            int? page,
            int? pageSize,
            string? sortBy,
            string? sortOrder,
            string? status);
        partial void ProcessListTeamV2V2TeamListGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTeamV2V2TeamListGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Team V2<br/>
        /// Get a paginated list of teams with filtering and sorting options.<br/>
        /// Parameters:<br/>
        ///     user_id: Optional[str]<br/>
        ///         Only return teams which this user belongs to<br/>
        ///     organization_id: Optional[str]<br/>
        ///         Only return teams which belong to this organization<br/>
        ///     team_id: Optional[str]<br/>
        ///         Filter teams by exact team_id match<br/>
        ///     team_alias: Optional[str]<br/>
        ///         Filter teams by partial team_alias match<br/>
        ///     page: int<br/>
        ///         The page number to return<br/>
        ///     page_size: int<br/>
        ///         The number of items per page<br/>
        ///     sort_by: Optional[str]<br/>
        ///         Column to sort by (e.g. 'team_id', 'team_alias', 'created_at')<br/>
        ///     sort_order: str<br/>
        ///         Sort order ('asc' or 'desc')<br/>
        ///     status: Optional[str]<br/>
        ///         Filter by status. Currently supports "deleted" to query deleted teams.
        /// </summary>
        /// <param name="userId">
        /// Only return teams which this 'user_id' belongs to
        /// </param>
        /// <param name="organizationId">
        /// Only return teams which this 'organization_id' belongs to
        /// </param>
        /// <param name="teamId">
        /// Only return teams which this 'team_id' belongs to
        /// </param>
        /// <param name="teamAlias">
        /// Only return teams which this 'team_alias' belongs to. Supports partial matching.
        /// </param>
        /// <param name="search">
        /// Combined search: matches teams whose 'team_id' matches the value OR whose 'team_alias' contains it (case-insensitive).
        /// </param>
        /// <param name="searchTeamIdMatch">
        /// How 'search' matches 'team_id': 'exact' (default) or 'prefix' for a case-sensitive prefix match.<br/>
        /// Default Value: exact
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of teams per page<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'team_id', 'team_alias', 'created_at')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="status">
        /// Filter by status (e.g. 'deleted')
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamListResponse> ListTeamV2V2TeamListGetAsync(
            string? userId = default,
            string? organizationId = default,
            string? teamId = default,
            string? teamAlias = default,
            string? search = default,
            global::Loud.Technology.LiteLLM.Sdk.ListTeamV2V2TeamListGetSearchTeamIdMatch? searchTeamIdMatch = default,
            int? page = default,
            int? pageSize = default,
            string? sortBy = default,
            string? sortOrder = default,
            string? status = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListTeamV2V2TeamListGetAsResponseAsync(
                userId: userId,
                organizationId: organizationId,
                teamId: teamId,
                teamAlias: teamAlias,
                search: search,
                searchTeamIdMatch: searchTeamIdMatch,
                page: page,
                pageSize: pageSize,
                sortBy: sortBy,
                sortOrder: sortOrder,
                status: status,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Team V2<br/>
        /// Get a paginated list of teams with filtering and sorting options.<br/>
        /// Parameters:<br/>
        ///     user_id: Optional[str]<br/>
        ///         Only return teams which this user belongs to<br/>
        ///     organization_id: Optional[str]<br/>
        ///         Only return teams which belong to this organization<br/>
        ///     team_id: Optional[str]<br/>
        ///         Filter teams by exact team_id match<br/>
        ///     team_alias: Optional[str]<br/>
        ///         Filter teams by partial team_alias match<br/>
        ///     page: int<br/>
        ///         The page number to return<br/>
        ///     page_size: int<br/>
        ///         The number of items per page<br/>
        ///     sort_by: Optional[str]<br/>
        ///         Column to sort by (e.g. 'team_id', 'team_alias', 'created_at')<br/>
        ///     sort_order: str<br/>
        ///         Sort order ('asc' or 'desc')<br/>
        ///     status: Optional[str]<br/>
        ///         Filter by status. Currently supports "deleted" to query deleted teams.
        /// </summary>
        /// <param name="userId">
        /// Only return teams which this 'user_id' belongs to
        /// </param>
        /// <param name="organizationId">
        /// Only return teams which this 'organization_id' belongs to
        /// </param>
        /// <param name="teamId">
        /// Only return teams which this 'team_id' belongs to
        /// </param>
        /// <param name="teamAlias">
        /// Only return teams which this 'team_alias' belongs to. Supports partial matching.
        /// </param>
        /// <param name="search">
        /// Combined search: matches teams whose 'team_id' matches the value OR whose 'team_alias' contains it (case-insensitive).
        /// </param>
        /// <param name="searchTeamIdMatch">
        /// How 'search' matches 'team_id': 'exact' (default) or 'prefix' for a case-sensitive prefix match.<br/>
        /// Default Value: exact
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of teams per page<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'team_id', 'team_alias', 'created_at')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="status">
        /// Filter by status (e.g. 'deleted')
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamListResponse>> ListTeamV2V2TeamListGetAsResponseAsync(
            string? userId = default,
            string? organizationId = default,
            string? teamId = default,
            string? teamAlias = default,
            string? search = default,
            global::Loud.Technology.LiteLLM.Sdk.ListTeamV2V2TeamListGetSearchTeamIdMatch? searchTeamIdMatch = default,
            int? page = default,
            int? pageSize = default,
            string? sortBy = default,
            string? sortOrder = default,
            string? status = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListTeamV2V2TeamListGetArguments(
                httpClient: HttpClient,
                userId: ref userId,
                organizationId: ref organizationId,
                teamId: ref teamId,
                teamAlias: ref teamAlias,
                search: ref search,
                searchTeamIdMatch: ref searchTeamIdMatch,
                page: ref page,
                pageSize: ref pageSize,
                sortBy: ref sortBy,
                sortOrder: ref sortOrder,
                status: ref status);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListTeamV2V2TeamListGetSecurityRequirements,
                operationName: "ListTeamV2V2TeamListGetAsync");

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
                                path: "/v2/team/list",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("user_id", userId)
                                .AddOptionalParameter("organization_id", organizationId)
                                .AddOptionalParameter("team_id", teamId)
                                .AddOptionalParameter("team_alias", teamAlias)
                                .AddOptionalParameter("search", search)
                                .AddOptionalParameter("search_team_id_match", searchTeamIdMatch?.ToValueString())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("sort_by", sortBy)
                                .AddOptionalParameter("sort_order", sortOrder)
                                .AddOptionalParameter("status", status)
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
                PrepareListTeamV2V2TeamListGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    userId: userId,
                    organizationId: organizationId,
                    teamId: teamId,
                    teamAlias: teamAlias,
                    search: search,
                    searchTeamIdMatch: searchTeamIdMatch,
                    page: page,
                    pageSize: pageSize,
                    sortBy: sortBy,
                    sortOrder: sortOrder,
                    status: status);

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
                                operationId: "ListTeamV2V2TeamListGet",
                                methodName: "ListTeamV2V2TeamListGetAsync",
                                pathTemplate: "\"/v2/team/list\"",
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
                                operationId: "ListTeamV2V2TeamListGet",
                                methodName: "ListTeamV2V2TeamListGetAsync",
                                pathTemplate: "\"/v2/team/list\"",
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
                                operationId: "ListTeamV2V2TeamListGet",
                                methodName: "ListTeamV2V2TeamListGetAsync",
                                pathTemplate: "\"/v2/team/list\"",
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
                ProcessListTeamV2V2TeamListGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListTeamV2V2TeamListGet",
                                methodName: "ListTeamV2V2TeamListGetAsync",
                                pathTemplate: "\"/v2/team/list\"",
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
                                operationId: "ListTeamV2V2TeamListGet",
                                methodName: "ListTeamV2V2TeamListGetAsync",
                                pathTemplate: "\"/v2/team/list\"",
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
                                ProcessListTeamV2V2TeamListGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.TeamListResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamListResponse>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.TeamListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamListResponse>(
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
    }
}