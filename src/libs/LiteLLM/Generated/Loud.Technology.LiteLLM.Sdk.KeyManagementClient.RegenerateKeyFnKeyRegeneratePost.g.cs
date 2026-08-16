
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class KeyManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_RegenerateKeyFnKeyRegeneratePostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_RegenerateKeyFnKeyRegeneratePostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_RegenerateKeyFnKeyRegeneratePostSecurityRequirement0,
            };
        partial void PrepareRegenerateKeyFnKeyRegeneratePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? key,
            ref string? litellmChangedBy,
            global::Loud.Technology.LiteLLM.Sdk.RegenerateKeyRequest request);
        partial void PrepareRegenerateKeyFnKeyRegeneratePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? key,
            string? litellmChangedBy,
            global::Loud.Technology.LiteLLM.Sdk.RegenerateKeyRequest request);
        partial void ProcessRegenerateKeyFnKeyRegeneratePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRegenerateKeyFnKeyRegeneratePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Regenerate Key Fn<br/>
        /// Regenerate an existing API key while optionally updating its parameters.<br/>
        /// Parameters:<br/>
        /// - key: str (path parameter) - The key to regenerate<br/>
        /// - data: Optional[RegenerateKeyRequest] - Request body containing optional parameters to update<br/>
        ///     - key: Optional[str] - The key to regenerate.<br/>
        ///     - new_master_key: Optional[str] - The new master key to use, if key is the master key.<br/>
        ///     - new_key: Optional[str] - The new key to use, if key is not the master key. Must start with 'sk-' and be at least 16 characters long. If both set, new_master_key will be used.<br/>
        ///     - key_alias: Optional[str] - User-friendly key alias<br/>
        ///     - user_id: Optional[str] - User ID associated with key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        ///     - spend: Optional[float] - Amount spent by key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - soft_budget: Optional[float] - Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        ///     - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        ///     - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        ///     - rpm_limit: Optional[int] - Requests per minute limit<br/>
        ///     - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        ///     - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        ///     - duration: Optional[str] - Key validity duration ("30d", "1h", etc.)<br/>
        ///     - permissions: Optional[dict] - Key-specific permissions<br/>
        ///     - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        ///     - blocked: Optional[bool] - Whether the key is blocked<br/>
        ///     - grace_period: Optional[str] - Duration to keep old key valid after rotation (e.g. "24h", "2d"). Omitted = immediate revoke. Env: LITELLM_KEY_ROTATION_GRACE_PERIOD<br/>
        /// Returns:<br/>
        /// - GenerateKeyResponse containing the new key and its updated parameters<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request POST 'http://localhost:4000/key/sk-1234/regenerate'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"team": "core-infra"},<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an Enterprise feature. It requires a premium license to use.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse> RegenerateKeyFnKeyRegeneratePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.RegenerateKeyRequest request,
            string? key = default,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await RegenerateKeyFnKeyRegeneratePostAsResponseAsync(

                request: request,
                key: key,
                litellmChangedBy: litellmChangedBy,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Regenerate Key Fn<br/>
        /// Regenerate an existing API key while optionally updating its parameters.<br/>
        /// Parameters:<br/>
        /// - key: str (path parameter) - The key to regenerate<br/>
        /// - data: Optional[RegenerateKeyRequest] - Request body containing optional parameters to update<br/>
        ///     - key: Optional[str] - The key to regenerate.<br/>
        ///     - new_master_key: Optional[str] - The new master key to use, if key is the master key.<br/>
        ///     - new_key: Optional[str] - The new key to use, if key is not the master key. Must start with 'sk-' and be at least 16 characters long. If both set, new_master_key will be used.<br/>
        ///     - key_alias: Optional[str] - User-friendly key alias<br/>
        ///     - user_id: Optional[str] - User ID associated with key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        ///     - spend: Optional[float] - Amount spent by key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - soft_budget: Optional[float] - Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        ///     - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        ///     - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        ///     - rpm_limit: Optional[int] - Requests per minute limit<br/>
        ///     - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        ///     - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        ///     - duration: Optional[str] - Key validity duration ("30d", "1h", etc.)<br/>
        ///     - permissions: Optional[dict] - Key-specific permissions<br/>
        ///     - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        ///     - blocked: Optional[bool] - Whether the key is blocked<br/>
        ///     - grace_period: Optional[str] - Duration to keep old key valid after rotation (e.g. "24h", "2d"). Omitted = immediate revoke. Env: LITELLM_KEY_ROTATION_GRACE_PERIOD<br/>
        /// Returns:<br/>
        /// - GenerateKeyResponse containing the new key and its updated parameters<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request POST 'http://localhost:4000/key/sk-1234/regenerate'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"team": "core-infra"},<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an Enterprise feature. It requires a premium license to use.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse>> RegenerateKeyFnKeyRegeneratePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.RegenerateKeyRequest request,
            string? key = default,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRegenerateKeyFnKeyRegeneratePostArguments(
                httpClient: HttpClient,
                key: ref key,
                litellmChangedBy: ref litellmChangedBy,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_RegenerateKeyFnKeyRegeneratePostSecurityRequirements,
                operationName: "RegenerateKeyFnKeyRegeneratePostAsync");

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
                                path: "/key/regenerate",
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

            if (litellmChangedBy != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("litellm-changed-by", litellmChangedBy.ToString());
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
                PrepareRegenerateKeyFnKeyRegeneratePostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    key: key,
                    litellmChangedBy: litellmChangedBy,
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
                                operationId: "RegenerateKeyFnKeyRegeneratePost",
                                methodName: "RegenerateKeyFnKeyRegeneratePostAsync",
                                pathTemplate: "\"/key/regenerate\"",
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
                                operationId: "RegenerateKeyFnKeyRegeneratePost",
                                methodName: "RegenerateKeyFnKeyRegeneratePostAsync",
                                pathTemplate: "\"/key/regenerate\"",
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
                                operationId: "RegenerateKeyFnKeyRegeneratePost",
                                methodName: "RegenerateKeyFnKeyRegeneratePostAsync",
                                pathTemplate: "\"/key/regenerate\"",
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
                ProcessRegenerateKeyFnKeyRegeneratePostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "RegenerateKeyFnKeyRegeneratePost",
                                methodName: "RegenerateKeyFnKeyRegeneratePostAsync",
                                pathTemplate: "\"/key/regenerate\"",
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
                                operationId: "RegenerateKeyFnKeyRegeneratePost",
                                methodName: "RegenerateKeyFnKeyRegeneratePostAsync",
                                pathTemplate: "\"/key/regenerate\"",
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
                                ProcessRegenerateKeyFnKeyRegeneratePostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse>(
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
        /// Regenerate Key Fn<br/>
        /// Regenerate an existing API key while optionally updating its parameters.<br/>
        /// Parameters:<br/>
        /// - key: str (path parameter) - The key to regenerate<br/>
        /// - data: Optional[RegenerateKeyRequest] - Request body containing optional parameters to update<br/>
        ///     - key: Optional[str] - The key to regenerate.<br/>
        ///     - new_master_key: Optional[str] - The new master key to use, if key is the master key.<br/>
        ///     - new_key: Optional[str] - The new key to use, if key is not the master key. Must start with 'sk-' and be at least 16 characters long. If both set, new_master_key will be used.<br/>
        ///     - key_alias: Optional[str] - User-friendly key alias<br/>
        ///     - user_id: Optional[str] - User ID associated with key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        ///     - spend: Optional[float] - Amount spent by key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - soft_budget: Optional[float] - Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        ///     - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        ///     - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        ///     - rpm_limit: Optional[int] - Requests per minute limit<br/>
        ///     - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        ///     - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        ///     - duration: Optional[str] - Key validity duration ("30d", "1h", etc.)<br/>
        ///     - permissions: Optional[dict] - Key-specific permissions<br/>
        ///     - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        ///     - blocked: Optional[bool] - Whether the key is blocked<br/>
        ///     - grace_period: Optional[str] - Duration to keep old key valid after rotation (e.g. "24h", "2d"). Omitted = immediate revoke. Env: LITELLM_KEY_ROTATION_GRACE_PERIOD<br/>
        /// Returns:<br/>
        /// - GenerateKeyResponse containing the new key and its updated parameters<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request POST 'http://localhost:4000/key/sk-1234/regenerate'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"team": "core-infra"},<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an Enterprise feature. It requires a premium license to use.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse> RegenerateKeyFnKeyRegeneratePostAsync(
            string? key = default,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.RegenerateKeyRequest
            {
            };

            return await RegenerateKeyFnKeyRegeneratePostAsync(
                key: key,
                litellmChangedBy: litellmChangedBy,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}