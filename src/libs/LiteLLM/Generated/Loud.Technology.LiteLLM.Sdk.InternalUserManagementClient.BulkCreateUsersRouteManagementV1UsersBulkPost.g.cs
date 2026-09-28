
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class InternalUserManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_BulkCreateUsersRouteManagementV1UsersBulkPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_BulkCreateUsersRouteManagementV1UsersBulkPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_BulkCreateUsersRouteManagementV1UsersBulkPostSecurityRequirement0,
            };
        partial void PrepareBulkCreateUsersRouteManagementV1UsersBulkPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.LiteLLM.Sdk.BulkNewUserRequest request);
        partial void PrepareBulkCreateUsersRouteManagementV1UsersBulkPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.LiteLLM.Sdk.BulkNewUserRequest request);
        partial void ProcessBulkCreateUsersRouteManagementV1UsersBulkPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBulkCreateUsersRouteManagementV1UsersBulkPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Bulk Create Users Route<br/>
        /// Create up to 500 internal users in one request, optionally adding each one to teams.<br/>
        /// Every entry in `users` takes the same fields as `/user/new`, with two differences: `auto_create_key`<br/>
        /// defaults to `false` (opt in per user to also get a virtual key back) and `send_invite_email` is not<br/>
        /// supported. Unknown fields are rejected with 422. Rows are validated together (duplicate ids or emails,<br/>
        /// unknown teams, roles the caller may not grant), inserted in one statement, and each referenced team is<br/>
        /// written once for all of its new members.<br/>
        /// Rows fail independently: a bad row is reported in `data` with `success: false` and an `error`, and the<br/>
        /// other rows still get created. A user that was created but could not be added to one of its teams is<br/>
        /// reported with `success: true`, `teams` listing where they did land, and `error` naming the failed team.<br/>
        /// The whole request is refused with a 403 problem document only if creating the valid rows would exceed<br/>
        /// the license seat limit.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST "http://localhost:4000/management/v1/users/bulk" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -H "Authorization: Bearer sk-1234" \<br/>
        /// -d '{<br/>
        ///     "users": [<br/>
        ///         {"user_email": "a@example.com", "user_role": "internal_user", "teams": ["team-1"]},<br/>
        ///         {"user_email": "b@example.com", "user_role": "internal_user", "auto_create_key": true}<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns `data` (one entry per input row, in order, with `user_id`, `user_email`, `success`, `teams`,<br/>
        /// `key`, `error`) and `meta` with `total_requested`, `created` and `failed`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse> BulkCreateUsersRouteManagementV1UsersBulkPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkNewUserRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await BulkCreateUsersRouteManagementV1UsersBulkPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Bulk Create Users Route<br/>
        /// Create up to 500 internal users in one request, optionally adding each one to teams.<br/>
        /// Every entry in `users` takes the same fields as `/user/new`, with two differences: `auto_create_key`<br/>
        /// defaults to `false` (opt in per user to also get a virtual key back) and `send_invite_email` is not<br/>
        /// supported. Unknown fields are rejected with 422. Rows are validated together (duplicate ids or emails,<br/>
        /// unknown teams, roles the caller may not grant), inserted in one statement, and each referenced team is<br/>
        /// written once for all of its new members.<br/>
        /// Rows fail independently: a bad row is reported in `data` with `success: false` and an `error`, and the<br/>
        /// other rows still get created. A user that was created but could not be added to one of its teams is<br/>
        /// reported with `success: true`, `teams` listing where they did land, and `error` naming the failed team.<br/>
        /// The whole request is refused with a 403 problem document only if creating the valid rows would exceed<br/>
        /// the license seat limit.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST "http://localhost:4000/management/v1/users/bulk" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -H "Authorization: Bearer sk-1234" \<br/>
        /// -d '{<br/>
        ///     "users": [<br/>
        ///         {"user_email": "a@example.com", "user_role": "internal_user", "teams": ["team-1"]},<br/>
        ///         {"user_email": "b@example.com", "user_role": "internal_user", "auto_create_key": true}<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns `data` (one entry per input row, in order, with `user_id`, `user_email`, `success`, `teams`,<br/>
        /// `key`, `error`) and `meta` with `total_requested`, `created` and `failed`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse>> BulkCreateUsersRouteManagementV1UsersBulkPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BulkNewUserRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareBulkCreateUsersRouteManagementV1UsersBulkPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_BulkCreateUsersRouteManagementV1UsersBulkPostSecurityRequirements,
                operationName: "BulkCreateUsersRouteManagementV1UsersBulkPostAsync");

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
                                path: "/management/v1/users/bulk",
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
                PrepareBulkCreateUsersRouteManagementV1UsersBulkPostRequest(
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
                                operationId: "BulkCreateUsersRouteManagementV1UsersBulkPost",
                                methodName: "BulkCreateUsersRouteManagementV1UsersBulkPostAsync",
                                pathTemplate: "\"/management/v1/users/bulk\"",
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
                                operationId: "BulkCreateUsersRouteManagementV1UsersBulkPost",
                                methodName: "BulkCreateUsersRouteManagementV1UsersBulkPostAsync",
                                pathTemplate: "\"/management/v1/users/bulk\"",
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
                                operationId: "BulkCreateUsersRouteManagementV1UsersBulkPost",
                                methodName: "BulkCreateUsersRouteManagementV1UsersBulkPostAsync",
                                pathTemplate: "\"/management/v1/users/bulk\"",
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
                ProcessBulkCreateUsersRouteManagementV1UsersBulkPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "BulkCreateUsersRouteManagementV1UsersBulkPost",
                                methodName: "BulkCreateUsersRouteManagementV1UsersBulkPostAsync",
                                pathTemplate: "\"/management/v1/users/bulk\"",
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
                                operationId: "BulkCreateUsersRouteManagementV1UsersBulkPost",
                                methodName: "BulkCreateUsersRouteManagementV1UsersBulkPostAsync",
                                pathTemplate: "\"/management/v1/users/bulk\"",
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
                                ProcessBulkCreateUsersRouteManagementV1UsersBulkPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse>(
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
        /// Bulk Create Users Route<br/>
        /// Create up to 500 internal users in one request, optionally adding each one to teams.<br/>
        /// Every entry in `users` takes the same fields as `/user/new`, with two differences: `auto_create_key`<br/>
        /// defaults to `false` (opt in per user to also get a virtual key back) and `send_invite_email` is not<br/>
        /// supported. Unknown fields are rejected with 422. Rows are validated together (duplicate ids or emails,<br/>
        /// unknown teams, roles the caller may not grant), inserted in one statement, and each referenced team is<br/>
        /// written once for all of its new members.<br/>
        /// Rows fail independently: a bad row is reported in `data` with `success: false` and an `error`, and the<br/>
        /// other rows still get created. A user that was created but could not be added to one of its teams is<br/>
        /// reported with `success: true`, `teams` listing where they did land, and `error` naming the failed team.<br/>
        /// The whole request is refused with a 403 problem document only if creating the valid rows would exceed<br/>
        /// the license seat limit.<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST "http://localhost:4000/management/v1/users/bulk" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -H "Authorization: Bearer sk-1234" \<br/>
        /// -d '{<br/>
        ///     "users": [<br/>
        ///         {"user_email": "a@example.com", "user_role": "internal_user", "teams": ["team-1"]},<br/>
        ///         {"user_email": "b@example.com", "user_role": "internal_user", "auto_create_key": true}<br/>
        ///     ]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Returns `data` (one entry per input row, in order, with `user_id`, `user_email`, `success`, `teams`,<br/>
        /// `key`, `error`) and `meta` with `total_requested`, `created` and `failed`.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserResponse> BulkCreateUsersRouteManagementV1UsersBulkPostAsync(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BulkNewUserItem> users,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.BulkNewUserRequest
            {
                Users = users,
            };

            return await BulkCreateUsersRouteManagementV1UsersBulkPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}