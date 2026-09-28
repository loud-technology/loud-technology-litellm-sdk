
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class McpDiscoverableClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_TokenEndpointTokenPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_TokenEndpointTokenPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_TokenEndpointTokenPostSecurityRequirement0,
            };
        partial void PrepareTokenEndpointTokenPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? mcpServerName,
            global::Loud.Technology.LiteLLM.Sdk.BodyTokenEndpointTokenPost request);
        partial void PrepareTokenEndpointTokenPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? mcpServerName,
            global::Loud.Technology.LiteLLM.Sdk.BodyTokenEndpointTokenPost request);
        partial void ProcessTokenEndpointTokenPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTokenEndpointTokenPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Token Endpoint<br/>
        /// Accept the authorization code from client and exchange it for OAuth token.<br/>
        /// Supports PKCE flow by forwarding code_verifier to upstream provider.<br/>
        /// 1. Call the token endpoint with PKCE parameters<br/>
        /// 2. Store the user's token in the db - and generate a LiteLLM virtual key<br/>
        /// 3. Return the token<br/>
        /// 4. Return a virtual key in this response
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> TokenEndpointTokenPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyTokenEndpointTokenPost request,
            string? mcpServerName = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await TokenEndpointTokenPostAsResponseAsync(

                request: request,
                mcpServerName: mcpServerName,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Token Endpoint<br/>
        /// Accept the authorization code from client and exchange it for OAuth token.<br/>
        /// Supports PKCE flow by forwarding code_verifier to upstream provider.<br/>
        /// 1. Call the token endpoint with PKCE parameters<br/>
        /// 2. Store the user's token in the db - and generate a LiteLLM virtual key<br/>
        /// 3. Return the token<br/>
        /// 4. Return a virtual key in this response
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TokenEndpointTokenPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyTokenEndpointTokenPost request,
            string? mcpServerName = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTokenEndpointTokenPostArguments(
                httpClient: HttpClient,
                mcpServerName: ref mcpServerName,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TokenEndpointTokenPostSecurityRequirements,
                operationName: "TokenEndpointTokenPostAsync");

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
                                path: "/token",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("mcp_server_name", mcpServerName)
                                ;
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
                            var __formValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
                            __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                "client_id",
                                request.ClientId ?? string.Empty));
                            if (request.ClientSecret != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "client_secret",
                                    request.ClientSecret ?? string.Empty));
                            }
                            if (request.Code != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "code",
                                    request.Code ?? string.Empty));
                            }
                            if (request.CodeVerifier != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "code_verifier",
                                    request.CodeVerifier ?? string.Empty));
                            }
                            __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                "grant_type",
                                request.GrantType ?? string.Empty));
                            if (request.RedirectUri != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "redirect_uri",
                                    request.RedirectUri ?? string.Empty));
                            }
                            if (request.RefreshToken != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "refresh_token",
                                    request.RefreshToken ?? string.Empty));
                            }
                            if (request.RequestedTokenType != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "requested_token_type",
                                    request.RequestedTokenType ?? string.Empty));
                            }
                            if (request.Resource != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "resource",
                                    request.Resource ?? string.Empty));
                            }
                            if (request.Scope != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "scope",
                                    request.Scope ?? string.Empty));
                            }
                            if (request.SubjectToken != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "subject_token",
                                    request.SubjectToken ?? string.Empty));
                            }
                            if (request.SubjectTokenType != default)
                            {
                                __formValues.Add(new global::System.Collections.Generic.KeyValuePair<string, string>(
                                    "subject_token_type",
                                    request.SubjectTokenType ?? string.Empty));
                            }
                            var __httpRequestContent = new global::System.Net.Http.FormUrlEncodedContent(__formValues);
                            __httpRequest.Content = __httpRequestContent;

                global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareTokenEndpointTokenPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    mcpServerName: mcpServerName,
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
                                operationId: "TokenEndpointTokenPost",
                                methodName: "TokenEndpointTokenPostAsync",
                                pathTemplate: "\"/token\"",
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
                                operationId: "TokenEndpointTokenPost",
                                methodName: "TokenEndpointTokenPostAsync",
                                pathTemplate: "\"/token\"",
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
                                operationId: "TokenEndpointTokenPost",
                                methodName: "TokenEndpointTokenPostAsync",
                                pathTemplate: "\"/token\"",
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
                ProcessTokenEndpointTokenPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TokenEndpointTokenPost",
                                methodName: "TokenEndpointTokenPostAsync",
                                pathTemplate: "\"/token\"",
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
                                operationId: "TokenEndpointTokenPost",
                                methodName: "TokenEndpointTokenPostAsync",
                                pathTemplate: "\"/token\"",
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
                                ProcessTokenEndpointTokenPostResponseContent(
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
        /// Token Endpoint<br/>
        /// Accept the authorization code from client and exchange it for OAuth token.<br/>
        /// Supports PKCE flow by forwarding code_verifier to upstream provider.<br/>
        /// 1. Call the token endpoint with PKCE parameters<br/>
        /// 2. Store the user's token in the db - and generate a LiteLLM virtual key<br/>
        /// 3. Return the token<br/>
        /// 4. Return a virtual key in this response
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="code"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="grantType"></param>
        /// <param name="redirectUri"></param>
        /// <param name="refreshToken"></param>
        /// <param name="requestedTokenType"></param>
        /// <param name="resource"></param>
        /// <param name="scope"></param>
        /// <param name="subjectToken"></param>
        /// <param name="subjectTokenType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TokenEndpointTokenPostAsync(
            string clientId,
            string grantType,
            string? mcpServerName = default,
            string? clientSecret = default,
            string? code = default,
            string? codeVerifier = default,
            string? redirectUri = default,
            string? refreshToken = default,
            string? requestedTokenType = default,
            string? resource = default,
            string? scope = default,
            string? subjectToken = default,
            string? subjectTokenType = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.BodyTokenEndpointTokenPost
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                Code = code,
                CodeVerifier = codeVerifier,
                GrantType = grantType,
                RedirectUri = redirectUri,
                RefreshToken = refreshToken,
                RequestedTokenType = requestedTokenType,
                Resource = resource,
                Scope = scope,
                SubjectToken = subjectToken,
                SubjectTokenType = subjectTokenType,
            };

            return await TokenEndpointTokenPostAsync(
                mcpServerName: mcpServerName,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}