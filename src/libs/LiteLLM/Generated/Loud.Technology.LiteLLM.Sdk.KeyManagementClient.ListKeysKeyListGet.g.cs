
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class KeyManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_ListKeysKeyListGetSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_ListKeysKeyListGetSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_ListKeysKeyListGetSecurityRequirement0,
            };
        partial void PrepareListKeysKeyListGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? size,
            ref string? userId,
            ref string? teamId,
            ref string? organizationId,
            ref string? keyHash,
            ref string? keyAlias,
            ref bool? returnFullObject,
            ref bool? includeTeamKeys,
            ref bool? includeCreatedByKeys,
            ref string? sortBy,
            ref string? sortOrder,
            global::System.Collections.Generic.IList<string>? expand,
            ref string? status,
            ref string? projectId,
            ref string? accessGroupId,
            ref string? agentId,
            ref bool? substringMatching,
            ref string? expires);
        partial void PrepareListKeysKeyListGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? size,
            string? userId,
            string? teamId,
            string? organizationId,
            string? keyHash,
            string? keyAlias,
            bool? returnFullObject,
            bool? includeTeamKeys,
            bool? includeCreatedByKeys,
            string? sortBy,
            string? sortOrder,
            global::System.Collections.Generic.IList<string>? expand,
            string? status,
            string? projectId,
            string? accessGroupId,
            string? agentId,
            bool? substringMatching,
            string? expires);
        partial void ProcessListKeysKeyListGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListKeysKeyListGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Keys<br/>
        /// List all keys for a given user / team / organization.<br/>
        /// Parameters:<br/>
        ///     expand: Optional[List[str]] - Expand related objects (e.g. 'user' to include user information)<br/>
        ///     status: Optional[str] - Filter by status. Currently supports "deleted" to query deleted keys.<br/>
        /// Returns:<br/>
        ///     {<br/>
        ///         "keys": List[str] or List[UserAPIKeyAuth],<br/>
        ///         "total_count": int,<br/>
        ///         "current_page": int,<br/>
        ///         "total_pages": int,<br/>
        ///     }<br/>
        /// When expand includes "user", each key object will include a "user" field with the associated user object.<br/>
        /// Note: When expand=user is specified, full key objects are returned regardless of the return_full_object parameter.
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="userId">
        /// Filter keys by user ID. Exact match by default; set substring_matching=true (admin only) for case-insensitive substring matching.
        /// </param>
        /// <param name="teamId">
        /// Filter keys by team ID
        /// </param>
        /// <param name="organizationId">
        /// Filter keys by organization ID
        /// </param>
        /// <param name="keyHash">
        /// Filter keys by key hash
        /// </param>
        /// <param name="keyAlias">
        /// Filter keys by key alias. Exact match by default; set substring_matching=true (admin only) for case-insensitive substring matching.
        /// </param>
        /// <param name="returnFullObject">
        /// Return full key object<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTeamKeys">
        /// Include all keys for teams that user is an admin of.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeCreatedByKeys">
        /// Include keys created by the user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'user_id', 'created_at', 'spend')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="expand">
        /// Expand related objects (e.g. 'user')
        /// </param>
        /// <param name="status">
        /// Filter by status (e.g. 'deleted')
        /// </param>
        /// <param name="projectId">
        /// Filter keys by project ID
        /// </param>
        /// <param name="accessGroupId">
        /// Filter keys by access group ID
        /// </param>
        /// <param name="agentId">
        /// Filter keys by agent ID
        /// </param>
        /// <param name="substringMatching">
        /// If true (proxy admins only), match user_id/key_alias as case-insensitive substrings instead of exact values. Defaults to false: /key/list matched these exactly before substring search was added, and an exact user_id/key_alias filter must never return another user's keys.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expires">
        /// Filter keys by expiration. 'expired' returns keys whose expires is in the past; 'active' returns keys that never expire or expire in the future. Omit to return keys regardless of expiration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.KeyListResponseObject> ListKeysKeyListGetAsync(
            int? page = default,
            int? size = default,
            string? userId = default,
            string? teamId = default,
            string? organizationId = default,
            string? keyHash = default,
            string? keyAlias = default,
            bool? returnFullObject = default,
            bool? includeTeamKeys = default,
            bool? includeCreatedByKeys = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            string? status = default,
            string? projectId = default,
            string? accessGroupId = default,
            string? agentId = default,
            bool? substringMatching = default,
            string? expires = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListKeysKeyListGetAsResponseAsync(
                page: page,
                size: size,
                userId: userId,
                teamId: teamId,
                organizationId: organizationId,
                keyHash: keyHash,
                keyAlias: keyAlias,
                returnFullObject: returnFullObject,
                includeTeamKeys: includeTeamKeys,
                includeCreatedByKeys: includeCreatedByKeys,
                sortBy: sortBy,
                sortOrder: sortOrder,
                expand: expand,
                status: status,
                projectId: projectId,
                accessGroupId: accessGroupId,
                agentId: agentId,
                substringMatching: substringMatching,
                expires: expires,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Keys<br/>
        /// List all keys for a given user / team / organization.<br/>
        /// Parameters:<br/>
        ///     expand: Optional[List[str]] - Expand related objects (e.g. 'user' to include user information)<br/>
        ///     status: Optional[str] - Filter by status. Currently supports "deleted" to query deleted keys.<br/>
        /// Returns:<br/>
        ///     {<br/>
        ///         "keys": List[str] or List[UserAPIKeyAuth],<br/>
        ///         "total_count": int,<br/>
        ///         "current_page": int,<br/>
        ///         "total_pages": int,<br/>
        ///     }<br/>
        /// When expand includes "user", each key object will include a "user" field with the associated user object.<br/>
        /// Note: When expand=user is specified, full key objects are returned regardless of the return_full_object parameter.
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="userId">
        /// Filter keys by user ID. Exact match by default; set substring_matching=true (admin only) for case-insensitive substring matching.
        /// </param>
        /// <param name="teamId">
        /// Filter keys by team ID
        /// </param>
        /// <param name="organizationId">
        /// Filter keys by organization ID
        /// </param>
        /// <param name="keyHash">
        /// Filter keys by key hash
        /// </param>
        /// <param name="keyAlias">
        /// Filter keys by key alias. Exact match by default; set substring_matching=true (admin only) for case-insensitive substring matching.
        /// </param>
        /// <param name="returnFullObject">
        /// Return full key object<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTeamKeys">
        /// Include all keys for teams that user is an admin of.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeCreatedByKeys">
        /// Include keys created by the user<br/>
        /// Default Value: false
        /// </param>
        /// <param name="sortBy">
        /// Column to sort by (e.g. 'user_id', 'created_at', 'spend')
        /// </param>
        /// <param name="sortOrder">
        /// Sort order ('asc' or 'desc')<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="expand">
        /// Expand related objects (e.g. 'user')
        /// </param>
        /// <param name="status">
        /// Filter by status (e.g. 'deleted')
        /// </param>
        /// <param name="projectId">
        /// Filter keys by project ID
        /// </param>
        /// <param name="accessGroupId">
        /// Filter keys by access group ID
        /// </param>
        /// <param name="agentId">
        /// Filter keys by agent ID
        /// </param>
        /// <param name="substringMatching">
        /// If true (proxy admins only), match user_id/key_alias as case-insensitive substrings instead of exact values. Defaults to false: /key/list matched these exactly before substring search was added, and an exact user_id/key_alias filter must never return another user's keys.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expires">
        /// Filter keys by expiration. 'expired' returns keys whose expires is in the past; 'active' returns keys that never expire or expire in the future. Omit to return keys regardless of expiration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.KeyListResponseObject>> ListKeysKeyListGetAsResponseAsync(
            int? page = default,
            int? size = default,
            string? userId = default,
            string? teamId = default,
            string? organizationId = default,
            string? keyHash = default,
            string? keyAlias = default,
            bool? returnFullObject = default,
            bool? includeTeamKeys = default,
            bool? includeCreatedByKeys = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::System.Collections.Generic.IList<string>? expand = default,
            string? status = default,
            string? projectId = default,
            string? accessGroupId = default,
            string? agentId = default,
            bool? substringMatching = default,
            string? expires = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListKeysKeyListGetArguments(
                httpClient: HttpClient,
                page: ref page,
                size: ref size,
                userId: ref userId,
                teamId: ref teamId,
                organizationId: ref organizationId,
                keyHash: ref keyHash,
                keyAlias: ref keyAlias,
                returnFullObject: ref returnFullObject,
                includeTeamKeys: ref includeTeamKeys,
                includeCreatedByKeys: ref includeCreatedByKeys,
                sortBy: ref sortBy,
                sortOrder: ref sortOrder,
                expand: expand,
                status: ref status,
                projectId: ref projectId,
                accessGroupId: ref accessGroupId,
                agentId: ref agentId,
                substringMatching: ref substringMatching,
                expires: ref expires);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListKeysKeyListGetSecurityRequirements,
                operationName: "ListKeysKeyListGetAsync");

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
                                path: "/key/list",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("size", size?.ToString())
                                .AddOptionalParameter("user_id", userId)
                                .AddOptionalParameter("team_id", teamId)
                                .AddOptionalParameter("organization_id", organizationId)
                                .AddOptionalParameter("key_hash", keyHash)
                                .AddOptionalParameter("key_alias", keyAlias)
                                .AddOptionalParameter("return_full_object", returnFullObject?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("include_team_keys", includeTeamKeys?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("include_created_by_keys", includeCreatedByKeys?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("sort_by", sortBy)
                                .AddOptionalParameter("sort_order", sortOrder)
                                .AddOptionalParameter("expand", expand?.ToString())
                                .AddOptionalParameter("status", status)
                                .AddOptionalParameter("project_id", projectId)
                                .AddOptionalParameter("access_group_id", accessGroupId)
                                .AddOptionalParameter("agent_id", agentId)
                                .AddOptionalParameter("substring_matching", substringMatching?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("expires", expires)
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
                PrepareListKeysKeyListGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    page: page,
                    size: size,
                    userId: userId,
                    teamId: teamId,
                    organizationId: organizationId,
                    keyHash: keyHash,
                    keyAlias: keyAlias,
                    returnFullObject: returnFullObject,
                    includeTeamKeys: includeTeamKeys,
                    includeCreatedByKeys: includeCreatedByKeys,
                    sortBy: sortBy,
                    sortOrder: sortOrder,
                    expand: expand,
                    status: status,
                    projectId: projectId,
                    accessGroupId: accessGroupId,
                    agentId: agentId,
                    substringMatching: substringMatching,
                    expires: expires);

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
                                operationId: "ListKeysKeyListGet",
                                methodName: "ListKeysKeyListGetAsync",
                                pathTemplate: "\"/key/list\"",
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
                                operationId: "ListKeysKeyListGet",
                                methodName: "ListKeysKeyListGetAsync",
                                pathTemplate: "\"/key/list\"",
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
                                operationId: "ListKeysKeyListGet",
                                methodName: "ListKeysKeyListGetAsync",
                                pathTemplate: "\"/key/list\"",
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
                ProcessListKeysKeyListGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListKeysKeyListGet",
                                methodName: "ListKeysKeyListGetAsync",
                                pathTemplate: "\"/key/list\"",
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
                                operationId: "ListKeysKeyListGet",
                                methodName: "ListKeysKeyListGetAsync",
                                pathTemplate: "\"/key/list\"",
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
                                ProcessListKeysKeyListGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.KeyListResponseObject.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.KeyListResponseObject>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.KeyListResponseObject.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.KeyListResponseObject>(
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