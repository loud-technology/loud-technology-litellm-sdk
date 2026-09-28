
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class A2aRegistrationClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_DiscoverAgentCardV1A2aDiscoverPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_DiscoverAgentCardV1A2aDiscoverPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_DiscoverAgentCardV1A2aDiscoverPostSecurityRequirement0,
            };
        partial void PrepareDiscoverAgentCardV1A2aDiscoverPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentRequest request);
        partial void PrepareDiscoverAgentCardV1A2aDiscoverPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentRequest request);
        partial void ProcessDiscoverAgentCardV1A2aDiscoverPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDiscoverAgentCardV1A2aDiscoverPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Discover Agent Card<br/>
        /// Fetch the upstream agent's well-known card so the UI can show the admin<br/>
        /// which skills/capabilities the agent exposes.<br/>
        /// Only proxy admins can call this — the UI uses it during agent registration,<br/>
        /// and we don't want arbitrary keys probing internal URLs.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/a2a/discover" \<br/>
        ///     -H "Authorization: Bearer &lt;admin_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{"url": "https://upstream-agent.example.com"}'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse> DiscoverAgentCardV1A2aDiscoverPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await DiscoverAgentCardV1A2aDiscoverPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Discover Agent Card<br/>
        /// Fetch the upstream agent's well-known card so the UI can show the admin<br/>
        /// which skills/capabilities the agent exposes.<br/>
        /// Only proxy admins can call this — the UI uses it during agent registration,<br/>
        /// and we don't want arbitrary keys probing internal URLs.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/a2a/discover" \<br/>
        ///     -H "Authorization: Bearer &lt;admin_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{"url": "https://upstream-agent.example.com"}'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse>> DiscoverAgentCardV1A2aDiscoverPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDiscoverAgentCardV1A2aDiscoverPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DiscoverAgentCardV1A2aDiscoverPostSecurityRequirements,
                operationName: "DiscoverAgentCardV1A2aDiscoverPostAsync");

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
                                path: "/v1/a2a/discover",
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
                PrepareDiscoverAgentCardV1A2aDiscoverPostRequest(
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
                                operationId: "DiscoverAgentCardV1A2aDiscoverPost",
                                methodName: "DiscoverAgentCardV1A2aDiscoverPostAsync",
                                pathTemplate: "\"/v1/a2a/discover\"",
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
                                operationId: "DiscoverAgentCardV1A2aDiscoverPost",
                                methodName: "DiscoverAgentCardV1A2aDiscoverPostAsync",
                                pathTemplate: "\"/v1/a2a/discover\"",
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
                                operationId: "DiscoverAgentCardV1A2aDiscoverPost",
                                methodName: "DiscoverAgentCardV1A2aDiscoverPostAsync",
                                pathTemplate: "\"/v1/a2a/discover\"",
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
                ProcessDiscoverAgentCardV1A2aDiscoverPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DiscoverAgentCardV1A2aDiscoverPost",
                                methodName: "DiscoverAgentCardV1A2aDiscoverPostAsync",
                                pathTemplate: "\"/v1/a2a/discover\"",
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
                                operationId: "DiscoverAgentCardV1A2aDiscoverPost",
                                methodName: "DiscoverAgentCardV1A2aDiscoverPostAsync",
                                pathTemplate: "\"/v1/a2a/discover\"",
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
                                ProcessDiscoverAgentCardV1A2aDiscoverPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse>(
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
        /// Discover Agent Card<br/>
        /// Fetch the upstream agent's well-known card so the UI can show the admin<br/>
        /// which skills/capabilities the agent exposes.<br/>
        /// Only proxy admins can call this — the UI uses it during agent registration,<br/>
        /// and we don't want arbitrary keys probing internal URLs.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/a2a/discover" \<br/>
        ///     -H "Authorization: Bearer &lt;admin_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{"url": "https://upstream-agent.example.com"}'<br/>
        /// ```
        /// </summary>
        /// <param name="discoveryMode">
        /// How to locate the upstream card. ``well_known_fallback`` for pure A2A agents (try standard paths); ``langgraph_platform`` for LangGraph Platform deployments where the card is shared across assistants and disambiguated by a query parameter.<br/>
        /// Default Value: well_known_fallback
        /// </param>
        /// <param name="params">
        /// Mode-specific parameters. ``langgraph_platform`` requires ``{'assistant_id': &lt;id&gt;}``. ``well_known_fallback`` ignores this.
        /// </param>
        /// <param name="url">
        /// Base URL of the upstream agent. Behavior depends on ``discovery_mode``: ``well_known_fallback`` (default) tries /.well-known/agent-card.json, /.well-known/agent.json, /agent.json under this URL in order; ``langgraph_platform`` hits ``/.well-known/agent-card.json?assistant_id=&lt;id&gt;`` instead.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentResponse> DiscoverAgentCardV1A2aDiscoverPostAsync(
            string url,
            global::Loud.Technology.LiteLLM.Sdk.DiscoveryMode? discoveryMode = default,
            object? @params = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.DiscoverAgentRequest
            {
                DiscoveryMode = discoveryMode,
                Params = @params,
                Url = url,
            };

            return await DiscoverAgentCardV1A2aDiscoverPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}