
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class ModelManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_PreviewAutoRouterRoutingAutoRouterTestRoutingPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_PreviewAutoRouterRoutingAutoRouterTestRoutingPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_PreviewAutoRouterRoutingAutoRouterTestRoutingPostSecurityRequirement0,
            };
        partial void PreparePreviewAutoRouterRoutingAutoRouterTestRoutingPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestRequest request);
        partial void PreparePreviewAutoRouterRoutingAutoRouterTestRoutingPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestRequest request);
        partial void ProcessPreviewAutoRouterRoutingAutoRouterTestRoutingPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPreviewAutoRouterRoutingAutoRouterTestRoutingPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Preview Auto Router Routing<br/>
        /// Route a single request through a complexity-router config and report where it landed.<br/>
        /// Answers "which model would this request get?" for a config that only exists in a form,<br/>
        /// so an auto router can be checked before it is created. The request is classified by the<br/>
        /// same pre-routing hook a live request runs, over the same messages, system prompt and tool<br/>
        /// definitions, then dropped: nothing is sent to the model it routed to, and no auto router is<br/>
        /// created. A heuristic config therefore spends nothing, while an `llm` classifier or semantic<br/>
        /// keyword matching bills its classifier/embedding call to the calling key, like Test Connection<br/>
        /// does.<br/>
        /// Send `messages` to classify a real turn, with `system` and `tools` beside it when the surface<br/>
        /// carries them top level, as Anthropic /v1/messages does. `prompt` is the single-ask shorthand and<br/>
        /// routes as one user turn with nothing around it.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "messages": [<br/>
        ///         {"role": "system", "content": "You are a database migration assistant"},<br/>
        ///         {"role": "user", "content": "the index is not unique"},<br/>
        ///         {"role": "assistant", "content": "Then two workers can both insert. Add a unique index"},<br/>
        ///         {"role": "user", "content": "ok do it"}<br/>
        ///     ],<br/>
        ///     "tools": [{"type": "function", "function": {"name": "Bash", "description": "Run a command"}}],<br/>
        ///     "complexity_router_config": {<br/>
        ///         "tiers": {"SIMPLE": ["gpt-4o-mini"], "REASONING": ["o3"]},<br/>
        ///         "classifier_type": "heuristic"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse> PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Preview Auto Router Routing<br/>
        /// Route a single request through a complexity-router config and report where it landed.<br/>
        /// Answers "which model would this request get?" for a config that only exists in a form,<br/>
        /// so an auto router can be checked before it is created. The request is classified by the<br/>
        /// same pre-routing hook a live request runs, over the same messages, system prompt and tool<br/>
        /// definitions, then dropped: nothing is sent to the model it routed to, and no auto router is<br/>
        /// created. A heuristic config therefore spends nothing, while an `llm` classifier or semantic<br/>
        /// keyword matching bills its classifier/embedding call to the calling key, like Test Connection<br/>
        /// does.<br/>
        /// Send `messages` to classify a real turn, with `system` and `tools` beside it when the surface<br/>
        /// carries them top level, as Anthropic /v1/messages does. `prompt` is the single-ask shorthand and<br/>
        /// routes as one user turn with nothing around it.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "messages": [<br/>
        ///         {"role": "system", "content": "You are a database migration assistant"},<br/>
        ///         {"role": "user", "content": "the index is not unique"},<br/>
        ///         {"role": "assistant", "content": "Then two workers can both insert. Add a unique index"},<br/>
        ///         {"role": "user", "content": "ok do it"}<br/>
        ///     ],<br/>
        ///     "tools": [{"type": "function", "function": {"name": "Bash", "description": "Run a command"}}],<br/>
        ///     "complexity_router_config": {<br/>
        ///         "tiers": {"SIMPLE": ["gpt-4o-mini"], "REASONING": ["o3"]},<br/>
        ///         "classifier_type": "heuristic"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse>> PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePreviewAutoRouterRoutingAutoRouterTestRoutingPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PreviewAutoRouterRoutingAutoRouterTestRoutingPostSecurityRequirements,
                operationName: "PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync");

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
                                path: "/auto_router/test_routing",
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
                PreparePreviewAutoRouterRoutingAutoRouterTestRoutingPostRequest(
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
                                operationId: "PreviewAutoRouterRoutingAutoRouterTestRoutingPost",
                                methodName: "PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync",
                                pathTemplate: "\"/auto_router/test_routing\"",
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
                                operationId: "PreviewAutoRouterRoutingAutoRouterTestRoutingPost",
                                methodName: "PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync",
                                pathTemplate: "\"/auto_router/test_routing\"",
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
                                operationId: "PreviewAutoRouterRoutingAutoRouterTestRoutingPost",
                                methodName: "PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync",
                                pathTemplate: "\"/auto_router/test_routing\"",
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
                ProcessPreviewAutoRouterRoutingAutoRouterTestRoutingPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "PreviewAutoRouterRoutingAutoRouterTestRoutingPost",
                                methodName: "PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync",
                                pathTemplate: "\"/auto_router/test_routing\"",
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
                                operationId: "PreviewAutoRouterRoutingAutoRouterTestRoutingPost",
                                methodName: "PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync",
                                pathTemplate: "\"/auto_router/test_routing\"",
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
                                ProcessPreviewAutoRouterRoutingAutoRouterTestRoutingPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse>(
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
        /// Preview Auto Router Routing<br/>
        /// Route a single request through a complexity-router config and report where it landed.<br/>
        /// Answers "which model would this request get?" for a config that only exists in a form,<br/>
        /// so an auto router can be checked before it is created. The request is classified by the<br/>
        /// same pre-routing hook a live request runs, over the same messages, system prompt and tool<br/>
        /// definitions, then dropped: nothing is sent to the model it routed to, and no auto router is<br/>
        /// created. A heuristic config therefore spends nothing, while an `llm` classifier or semantic<br/>
        /// keyword matching bills its classifier/embedding call to the calling key, like Test Connection<br/>
        /// does.<br/>
        /// Send `messages` to classify a real turn, with `system` and `tools` beside it when the surface<br/>
        /// carries them top level, as Anthropic /v1/messages does. `prompt` is the single-ask shorthand and<br/>
        /// routes as one user turn with nothing around it.<br/>
        /// **Example Request:**<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "messages": [<br/>
        ///         {"role": "system", "content": "You are a database migration assistant"},<br/>
        ///         {"role": "user", "content": "the index is not unique"},<br/>
        ///         {"role": "assistant", "content": "Then two workers can both insert. Add a unique index"},<br/>
        ///         {"role": "user", "content": "ok do it"}<br/>
        ///     ],<br/>
        ///     "tools": [{"type": "function", "function": {"name": "Bash", "description": "Run a command"}}],<br/>
        ///     "complexity_router_config": {<br/>
        ///         "tiers": {"SIMPLE": ["gpt-4o-mini"], "REASONING": ["o3"]},<br/>
        ///         "classifier_type": "heuristic"<br/>
        ///     }<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="prompt">
        /// A single ask to route, as an end user would send it. Mutually exclusive with messages
        /// </param>
        /// <param name="messages">
        /// The full message list to route, exactly as the serving path would receive it. Mutually exclusive with prompt
        /// </param>
        /// <param name="system">
        /// The top-level system prompt an Anthropic /v1/messages body carries beside its messages
        /// </param>
        /// <param name="tools">
        /// The tool definitions the request advertises, which decide whether the plan-mode floor applies
        /// </param>
        /// <param name="complexityRouterConfig">
        /// The complexity router config to route against, in the shape /model/new accepts
        /// </param>
        /// <param name="savedModelId">
        /// Test this saved deployment's server-side configuration instead of the supplied config and default model
        /// </param>
        /// <param name="defaultModel">
        /// Model to route to when no tier resolves, i.e. complexity_router_default_model
        /// </param>
        /// <param name="routerName">
        /// Name reported as the router in the routing decision. Display only<br/>
        /// Default Value: auto_router_routing_test
        /// </param>
        /// <param name="teamId">
        /// Team the router is being created for. Required for a team admin, who may only test their own team's routers
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestResponse> PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.RequestComplexityRouterConfig complexityRouterConfig,
            string? prompt = default,
            global::System.Collections.Generic.IList<object>? messages = default,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::System.Collections.Generic.IList<object>, object>? system = default,
            global::System.Collections.Generic.IList<object>? tools = default,
            string? savedModelId = default,
            string? defaultModel = default,
            string? routerName = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.AutoRouterRoutingTestRequest
            {
                Prompt = prompt,
                Messages = messages,
                System = system,
                Tools = tools,
                ComplexityRouterConfig = complexityRouterConfig,
                SavedModelId = savedModelId,
                DefaultModel = defaultModel,
                RouterName = routerName,
                TeamId = teamId,
            };

            return await PreviewAutoRouterRoutingAutoRouterTestRoutingPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}