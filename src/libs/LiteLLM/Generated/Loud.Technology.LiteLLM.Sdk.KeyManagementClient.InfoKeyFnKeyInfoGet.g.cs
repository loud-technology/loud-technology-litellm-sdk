
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class KeyManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_InfoKeyFnKeyInfoGetSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_InfoKeyFnKeyInfoGetSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_InfoKeyFnKeyInfoGetSecurityRequirement0,
            };
        partial void PrepareInfoKeyFnKeyInfoGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? key);
        partial void PrepareInfoKeyFnKeyInfoGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? key);
        partial void ProcessInfoKeyFnKeyInfoGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInfoKeyFnKeyInfoGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Info Key Fn<br/>
        /// Retrieve information about a key.<br/>
        /// Parameters:<br/>
        /// - key: str | None (query parameter) - The key to look up. Accepts the plaintext key or its hash;<br/>
        ///   prefer the hash, since a query parameter is recorded verbatim by any HTTP access log in front<br/>
        ///   of the proxy. Defaults to the key in the Authorization header.<br/>
        /// Returns:<br/>
        /// - key: str - The key that was looked up, echoed back as it was passed in<br/>
        /// - info: dict - The key's row, minus the hashed token. Deleted keys are served from the<br/>
        ///   LiteLLM_DeletedVerificationToken archive and carry deleted_at / deleted_by<br/>
        ///     - status: "active" | "expired" | "revoked" | "deleted" - Derived from blocked, expires and<br/>
        ///       whether the row came from the archive<br/>
        ///     - key_alias: str | None - User-friendly key alias<br/>
        ///     - spend: float - Amount spent by the key. When budget_duration is set this covers only the<br/>
        ///       current budget window, not the key's lifetime<br/>
        ///     - max_budget: float | None - Max budget for the key, enforced against spend<br/>
        ///     - budget_duration: str | None - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - budget_reset_at: datetime | None - When the current budget window ends and spend is next<br/>
        ///       reset to 0, not when it was last reset. Reset times snap to standard boundaries in the<br/>
        ///       configured timezone (30d and 1mo land on the 1st of the month, 7d on Monday, 1h on the<br/>
        ///       hour), so subtracting budget_duration from it does not give the window's start<br/>
        ///     - model_max_budget: dict - Per-model budgets, e.g. {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - model_max_budget_usage: dict | None - Current-window spend per model, present only when<br/>
        ///       the key has per-model budgets<br/>
        ///     - budget_limits: list | None - Concurrent budget windows, exactly as stored<br/>
        ///     - budget_limits_usage: dict | None - Current-window spend per budget window, e.g.<br/>
        ///       {"1h": {"current_spend": 0.0009}}, present only when the key has budget windows<br/>
        ///       (read from the same cross-pod spend counter the budget enforcement uses)<br/>
        ///     - models: list - Model_name's the key is allowed to call<br/>
        ///     - tpm_limit / rpm_limit: int | None - Tokens and requests per minute limits<br/>
        ///     - metadata: dict - Metadata for the key, e.g. {"team": "core-infra"}<br/>
        ///     - blocked: bool | None - Whether the key is blocked<br/>
        ///     - expires: datetime | None - When the key stops authenticating requests<br/>
        ///     - last_active: datetime | None - When the key was last used<br/>
        ///     - object_permission: dict | None - Resolved vector store / MCP permissions when the key has<br/>
        ///       an object_permission_id<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info?key=d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Curl - if no key is passed, it will use the Key Passed in Authorization Header<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info" -H "Authorization: Bearer sk-test-example-key-123"<br/>
        /// ```
        /// </summary>
        /// <param name="key">
        /// Key to look up. Pass the key's sha256 hash so the raw key stays out of URLs and access logs. Example key='d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> InfoKeyFnKeyInfoGetAsync(
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await InfoKeyFnKeyInfoGetAsResponseAsync(
                key: key,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Info Key Fn<br/>
        /// Retrieve information about a key.<br/>
        /// Parameters:<br/>
        /// - key: str | None (query parameter) - The key to look up. Accepts the plaintext key or its hash;<br/>
        ///   prefer the hash, since a query parameter is recorded verbatim by any HTTP access log in front<br/>
        ///   of the proxy. Defaults to the key in the Authorization header.<br/>
        /// Returns:<br/>
        /// - key: str - The key that was looked up, echoed back as it was passed in<br/>
        /// - info: dict - The key's row, minus the hashed token. Deleted keys are served from the<br/>
        ///   LiteLLM_DeletedVerificationToken archive and carry deleted_at / deleted_by<br/>
        ///     - status: "active" | "expired" | "revoked" | "deleted" - Derived from blocked, expires and<br/>
        ///       whether the row came from the archive<br/>
        ///     - key_alias: str | None - User-friendly key alias<br/>
        ///     - spend: float - Amount spent by the key. When budget_duration is set this covers only the<br/>
        ///       current budget window, not the key's lifetime<br/>
        ///     - max_budget: float | None - Max budget for the key, enforced against spend<br/>
        ///     - budget_duration: str | None - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - budget_reset_at: datetime | None - When the current budget window ends and spend is next<br/>
        ///       reset to 0, not when it was last reset. Reset times snap to standard boundaries in the<br/>
        ///       configured timezone (30d and 1mo land on the 1st of the month, 7d on Monday, 1h on the<br/>
        ///       hour), so subtracting budget_duration from it does not give the window's start<br/>
        ///     - model_max_budget: dict - Per-model budgets, e.g. {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - model_max_budget_usage: dict | None - Current-window spend per model, present only when<br/>
        ///       the key has per-model budgets<br/>
        ///     - budget_limits: list | None - Concurrent budget windows, exactly as stored<br/>
        ///     - budget_limits_usage: dict | None - Current-window spend per budget window, e.g.<br/>
        ///       {"1h": {"current_spend": 0.0009}}, present only when the key has budget windows<br/>
        ///       (read from the same cross-pod spend counter the budget enforcement uses)<br/>
        ///     - models: list - Model_name's the key is allowed to call<br/>
        ///     - tpm_limit / rpm_limit: int | None - Tokens and requests per minute limits<br/>
        ///     - metadata: dict - Metadata for the key, e.g. {"team": "core-infra"}<br/>
        ///     - blocked: bool | None - Whether the key is blocked<br/>
        ///     - expires: datetime | None - When the key stops authenticating requests<br/>
        ///     - last_active: datetime | None - When the key was last used<br/>
        ///     - object_permission: dict | None - Resolved vector store / MCP permissions when the key has<br/>
        ///       an object_permission_id<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info?key=d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Curl - if no key is passed, it will use the Key Passed in Authorization Header<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info" -H "Authorization: Bearer sk-test-example-key-123"<br/>
        /// ```
        /// </summary>
        /// <param name="key">
        /// Key to look up. Pass the key's sha256 hash so the raw key stays out of URLs and access logs. Example key='d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> InfoKeyFnKeyInfoGetAsResponseAsync(
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareInfoKeyFnKeyInfoGetArguments(
                httpClient: HttpClient,
                key: ref key);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InfoKeyFnKeyInfoGetSecurityRequirements,
                operationName: "InfoKeyFnKeyInfoGetAsync");

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
                                path: "/key/info",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("key", key)
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
                PrepareInfoKeyFnKeyInfoGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    key: key);

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
                                operationId: "InfoKeyFnKeyInfoGet",
                                methodName: "InfoKeyFnKeyInfoGetAsync",
                                pathTemplate: "\"/key/info\"",
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
                                operationId: "InfoKeyFnKeyInfoGet",
                                methodName: "InfoKeyFnKeyInfoGetAsync",
                                pathTemplate: "\"/key/info\"",
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
                                operationId: "InfoKeyFnKeyInfoGet",
                                methodName: "InfoKeyFnKeyInfoGetAsync",
                                pathTemplate: "\"/key/info\"",
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
                ProcessInfoKeyFnKeyInfoGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InfoKeyFnKeyInfoGet",
                                methodName: "InfoKeyFnKeyInfoGetAsync",
                                pathTemplate: "\"/key/info\"",
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
                                operationId: "InfoKeyFnKeyInfoGet",
                                methodName: "InfoKeyFnKeyInfoGetAsync",
                                pathTemplate: "\"/key/info\"",
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
                                ProcessInfoKeyFnKeyInfoGetResponseContent(
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