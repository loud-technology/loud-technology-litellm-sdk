
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class AutoRouterClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_StartShadowEvalAutoRouterShadowEvalStartPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_StartShadowEvalAutoRouterShadowEvalStartPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_StartShadowEvalAutoRouterShadowEvalStartPostSecurityRequirement0,
            };
        partial void PrepareStartShadowEvalAutoRouterShadowEvalStartPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequest request);
        partial void PrepareStartShadowEvalAutoRouterShadowEvalStartPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequest request);
        partial void ProcessStartShadowEvalAutoRouterShadowEvalStartPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessStartShadowEvalAutoRouterShadowEvalStartPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start Shadow Eval<br/>
        /// Start a shadow eval: duplicate a sampled slice of one or more targets' live traffic<br/>
        /// against a second arm, judge the two responses blind, and stratify win rates by tier,<br/>
        /// by the model that served the real arm, and by target.<br/>
        /// A target is a virtual key, a team, or a user. Team and user targets match on the<br/>
        /// identity every request resolves to at auth time, so they cover JWT-authenticated<br/>
        /// traffic, which presents no virtual key; a user target samples that user's traffic<br/>
        /// across all their teams, whether it arrives on a JWT or a key they own. models narrows<br/>
        /// every target to requests for those model groups, so a user plus one model samples that<br/>
        /// user's traffic on that model across every key they own; it is forward-only, since a<br/>
        /// reverse job already samples exactly the traffic its own router served.<br/>
        /// A forward job answers whether the targets should adopt router_name: it samples the<br/>
        /// requests the router did not serve and duplicates them through it. A reverse job<br/>
        /// answers whether a target already on the router still gains from it: it samples the<br/>
        /// requests the router did serve and duplicates them against baseline_model. A target<br/>
        /// can hold one active job per direction, so both questions can run at once, and a<br/>
        /// request matching several jobs' targets (say its key and its team) is sampled by<br/>
        /// each, separately budgeted.<br/>
        /// Shadow responses are never served to users. Each target samples until its recorded<br/>
        /// eval spend, the shadow and judge calls' own cost, reaches max_budget dollars, the<br/>
        /// job's window ends, or the job is stopped, so one target running out of budget does<br/>
        /// not end sampling for the others; sampling changes propagate to pods within about 10<br/>
        /// seconds. Shadow and judge calls bill to the sampled request's own identity but are<br/>
        /// excluded from request counts and auto-router adoption metrics.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse> StartShadowEvalAutoRouterShadowEvalStartPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await StartShadowEvalAutoRouterShadowEvalStartPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Start Shadow Eval<br/>
        /// Start a shadow eval: duplicate a sampled slice of one or more targets' live traffic<br/>
        /// against a second arm, judge the two responses blind, and stratify win rates by tier,<br/>
        /// by the model that served the real arm, and by target.<br/>
        /// A target is a virtual key, a team, or a user. Team and user targets match on the<br/>
        /// identity every request resolves to at auth time, so they cover JWT-authenticated<br/>
        /// traffic, which presents no virtual key; a user target samples that user's traffic<br/>
        /// across all their teams, whether it arrives on a JWT or a key they own. models narrows<br/>
        /// every target to requests for those model groups, so a user plus one model samples that<br/>
        /// user's traffic on that model across every key they own; it is forward-only, since a<br/>
        /// reverse job already samples exactly the traffic its own router served.<br/>
        /// A forward job answers whether the targets should adopt router_name: it samples the<br/>
        /// requests the router did not serve and duplicates them through it. A reverse job<br/>
        /// answers whether a target already on the router still gains from it: it samples the<br/>
        /// requests the router did serve and duplicates them against baseline_model. A target<br/>
        /// can hold one active job per direction, so both questions can run at once, and a<br/>
        /// request matching several jobs' targets (say its key and its team) is sampled by<br/>
        /// each, separately budgeted.<br/>
        /// Shadow responses are never served to users. Each target samples until its recorded<br/>
        /// eval spend, the shadow and judge calls' own cost, reaches max_budget dollars, the<br/>
        /// job's window ends, or the job is stopped, so one target running out of budget does<br/>
        /// not end sampling for the others; sampling changes propagate to pods within about 10<br/>
        /// seconds. Shadow and judge calls bill to the sampled request's own identity but are<br/>
        /// excluded from request counts and auto-router adoption metrics.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse>> StartShadowEvalAutoRouterShadowEvalStartPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareStartShadowEvalAutoRouterShadowEvalStartPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_StartShadowEvalAutoRouterShadowEvalStartPostSecurityRequirements,
                operationName: "StartShadowEvalAutoRouterShadowEvalStartPostAsync");

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
                                path: "/auto_router/shadow_eval/start",
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
                PrepareStartShadowEvalAutoRouterShadowEvalStartPostRequest(
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
                                operationId: "StartShadowEvalAutoRouterShadowEvalStartPost",
                                methodName: "StartShadowEvalAutoRouterShadowEvalStartPostAsync",
                                pathTemplate: "\"/auto_router/shadow_eval/start\"",
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
                                operationId: "StartShadowEvalAutoRouterShadowEvalStartPost",
                                methodName: "StartShadowEvalAutoRouterShadowEvalStartPostAsync",
                                pathTemplate: "\"/auto_router/shadow_eval/start\"",
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
                                operationId: "StartShadowEvalAutoRouterShadowEvalStartPost",
                                methodName: "StartShadowEvalAutoRouterShadowEvalStartPostAsync",
                                pathTemplate: "\"/auto_router/shadow_eval/start\"",
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
                ProcessStartShadowEvalAutoRouterShadowEvalStartPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "StartShadowEvalAutoRouterShadowEvalStartPost",
                                methodName: "StartShadowEvalAutoRouterShadowEvalStartPostAsync",
                                pathTemplate: "\"/auto_router/shadow_eval/start\"",
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
                                operationId: "StartShadowEvalAutoRouterShadowEvalStartPost",
                                methodName: "StartShadowEvalAutoRouterShadowEvalStartPostAsync",
                                pathTemplate: "\"/auto_router/shadow_eval/start\"",
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
                                ProcessStartShadowEvalAutoRouterShadowEvalStartPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse>(
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
        /// Start Shadow Eval<br/>
        /// Start a shadow eval: duplicate a sampled slice of one or more targets' live traffic<br/>
        /// against a second arm, judge the two responses blind, and stratify win rates by tier,<br/>
        /// by the model that served the real arm, and by target.<br/>
        /// A target is a virtual key, a team, or a user. Team and user targets match on the<br/>
        /// identity every request resolves to at auth time, so they cover JWT-authenticated<br/>
        /// traffic, which presents no virtual key; a user target samples that user's traffic<br/>
        /// across all their teams, whether it arrives on a JWT or a key they own. models narrows<br/>
        /// every target to requests for those model groups, so a user plus one model samples that<br/>
        /// user's traffic on that model across every key they own; it is forward-only, since a<br/>
        /// reverse job already samples exactly the traffic its own router served.<br/>
        /// A forward job answers whether the targets should adopt router_name: it samples the<br/>
        /// requests the router did not serve and duplicates them through it. A reverse job<br/>
        /// answers whether a target already on the router still gains from it: it samples the<br/>
        /// requests the router did serve and duplicates them against baseline_model. A target<br/>
        /// can hold one active job per direction, so both questions can run at once, and a<br/>
        /// request matching several jobs' targets (say its key and its team) is sampled by<br/>
        /// each, separately budgeted.<br/>
        /// Shadow responses are never served to users. Each target samples until its recorded<br/>
        /// eval spend, the shadow and judge calls' own cost, reaches max_budget dollars, the<br/>
        /// job's window ends, or the job is stopped, so one target running out of budget does<br/>
        /// not end sampling for the others; sampling changes propagate to pods within about 10<br/>
        /// seconds. Shadow and judge calls bill to the sampled request's own identity but are<br/>
        /// excluded from request counts and auto-router adoption metrics.
        /// </summary>
        /// <param name="apiKeyIds">
        /// Hashed virtual keys whose traffic will be shadowed. Combined with team_ids and user_ids the job needs at least one target and at most 100, which also bounds every read the job's endpoints make. Each target carries its own max_budget spend budget, so one exhausting its budget leaves the others sampling.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="teamIds">
        /// Teams whose traffic will be shadowed, matched on the team every authenticated request resolves to, so a team's JWT-auth and virtual-key traffic are both sampled<br/>
        /// Default Value: []
        /// </param>
        /// <param name="userIds">
        /// Users whose traffic will be shadowed, matched on the user every authenticated request resolves to across all their teams: JWT requests carrying their subject claim and virtual keys they own<br/>
        /// Default Value: []
        /// </param>
        /// <param name="models">
        /// Model groups to narrow the sampled traffic to, matched on the group the caller requested and resolved through model_group_alias, so an alias and its target are one name. Empty samples every model the targets use. This ANDs with the targets: a job over a user and one model samples that user's requests on that model across every key they own, and none of their other traffic. Forward jobs only: a reverse job samples exactly the traffic its own router served, which no other model group can name<br/>
        /// Default Value: []
        /// </param>
        /// <param name="routerName">
        /// The auto-router under evaluation, in either direction: the single-router spelling of router_names. Provide exactly one of the two fields
        /// </param>
        /// <param name="routerNames">
        /// The auto-routers under evaluation, at most 4. Every sampled request runs through every router listed and each arm is judged independently against the same real response, so routers compare head-to-head on identical traffic. More than one router requires direction 'forward'. After validation this field always carries the full deduplicated set, whichever spelling the caller used<br/>
        /// Default Value: []
        /// </param>
        /// <param name="direction">
        /// forward answers 'should this key adopt router_name': it samples the requests the key did NOT route through the router and duplicates them through it. reverse answers 'is the router still worth it for a key already on it': it samples the requests the router did serve and duplicates them against baseline_model. The response the caller received is always the real arm<br/>
        /// Default Value: forward
        /// </param>
        /// <param name="baselineModel">
        /// Required when direction is reverse and rejected otherwise: the fixed model the router's own responses are judged against. Must be a plain model rather than another auto-router
        /// </param>
        /// <param name="shadowPercentage">
        /// Percentage of each target's requests to duplicate through the router
        /// </param>
        /// <param name="judgeModel">
        /// Model used to blindly judge real vs. shadow responses. The judge only compares two answers, so a mid-tier model (Claude Sonnet or GPT-4o class) is the sweet spot: small/nano-class models produce unreliable or malformed verdicts, while frontier reasoning models add cost without changing outcomes.<br/>
        /// Default Value: anthropic/claude-sonnet-5
        /// </param>
        /// <param name="durationDays">
        /// How many days the job samples traffic before completing on its own<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="maxBudget">
        /// Per-target USD budget for the eval's own overhead, the shadow-arm and judge calls, priced with the same figures the spend pipeline bills. EACH scoped target samples until its recorded eval spend reaches this, so a job over N targets spends at most about N times max_budget; in-flight samples can overshoot the cap by one sampling cache window. Every router arm draws from the same per-target budget, so a multi-router job reaches it proportionally sooner<br/>
        /// Default Value: 10F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse> StartShadowEvalAutoRouterShadowEvalStartPostAsync(
            double shadowPercentage,
            global::System.Collections.Generic.IList<string>? apiKeyIds = default,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            string? routerName = default,
            global::System.Collections.Generic.IList<string>? routerNames = default,
            global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequestDirection? direction = default,
            string? baselineModel = default,
            string? judgeModel = default,
            int? durationDays = default,
            double? maxBudget = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.StartShadowEvalRequest
            {
                ApiKeyIds = apiKeyIds,
                TeamIds = teamIds,
                UserIds = userIds,
                Models = models,
                RouterName = routerName,
                RouterNames = routerNames,
                Direction = direction,
                BaselineModel = baselineModel,
                ShadowPercentage = shadowPercentage,
                JudgeModel = judgeModel,
                DurationDays = durationDays,
                MaxBudget = maxBudget,
            };

            return await StartShadowEvalAutoRouterShadowEvalStartPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}