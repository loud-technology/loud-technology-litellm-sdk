
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class HealthClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_TestModelConnectionHealthTestConnectionPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_TestModelConnectionHealthTestConnectionPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_TestModelConnectionHealthTestConnectionPostSecurityRequirement0,
            };
        partial void PrepareTestModelConnectionHealthTestConnectionPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPost request);
        partial void PrepareTestModelConnectionHealthTestConnectionPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPost request);
        partial void ProcessTestModelConnectionHealthTestConnectionPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTestModelConnectionHealthTestConnectionPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Test Model Connection<br/>
        /// Test a direct connection to a specific model.<br/>
        /// This endpoint allows you to verify if your proxy can successfully connect to a specific model.<br/>
        /// It's useful for troubleshooting model connectivity issues without going through the full proxy routing.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// # If model is configured in proxy_config.yaml, you only need to specify the model name:<br/>
        /// curl -X POST 'http://localhost:4000/health/test_connection' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "litellm_params": {<br/>
        ///         "model": "gpt-4o"<br/>
        ///     },<br/>
        ///     "mode": "chat"<br/>
        ///   }'<br/>
        /// # The endpoint will automatically use api_key, api_base, etc. from proxy_config.yaml<br/>
        /// # You can also override specific params or test with custom credentials:<br/>
        /// curl -X POST 'http://localhost:4000/health/test_connection' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "litellm_params": {<br/>
        ///         "model": "azure/gpt-4o",<br/>
        ///         "api_key": "os.environ/AZURE_OPENAI_API_KEY",<br/>
        ///         "api_base": "os.environ/AZURE_OPENAI_ENDPOINT",<br/>
        ///         "api_version": "2024-10-21"<br/>
        ///     },<br/>
        ///     "mode": "chat"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Note: <br/>
        /// - If the model is configured in proxy_config.yaml, credentials (api_key, api_base, etc.) <br/>
        ///   will be automatically loaded from the config (with resolved environment variables).<br/>
        /// - You can override specific params by including them in the request.<br/>
        /// - You can use `os.environ/VARIABLE_NAME` syntax to reference environment variables,<br/>
        ///   which will be resolved automatically (same as in proxy_config.yaml).<br/>
        /// Returns:<br/>
        ///     dict: A dictionary containing the health check result with either success information or error details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> TestModelConnectionHealthTestConnectionPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await TestModelConnectionHealthTestConnectionPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Test Model Connection<br/>
        /// Test a direct connection to a specific model.<br/>
        /// This endpoint allows you to verify if your proxy can successfully connect to a specific model.<br/>
        /// It's useful for troubleshooting model connectivity issues without going through the full proxy routing.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// # If model is configured in proxy_config.yaml, you only need to specify the model name:<br/>
        /// curl -X POST 'http://localhost:4000/health/test_connection' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "litellm_params": {<br/>
        ///         "model": "gpt-4o"<br/>
        ///     },<br/>
        ///     "mode": "chat"<br/>
        ///   }'<br/>
        /// # The endpoint will automatically use api_key, api_base, etc. from proxy_config.yaml<br/>
        /// # You can also override specific params or test with custom credentials:<br/>
        /// curl -X POST 'http://localhost:4000/health/test_connection' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "litellm_params": {<br/>
        ///         "model": "azure/gpt-4o",<br/>
        ///         "api_key": "os.environ/AZURE_OPENAI_API_KEY",<br/>
        ///         "api_base": "os.environ/AZURE_OPENAI_ENDPOINT",<br/>
        ///         "api_version": "2024-10-21"<br/>
        ///     },<br/>
        ///     "mode": "chat"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Note: <br/>
        /// - If the model is configured in proxy_config.yaml, credentials (api_key, api_base, etc.) <br/>
        ///   will be automatically loaded from the config (with resolved environment variables).<br/>
        /// - You can override specific params by including them in the request.<br/>
        /// - You can use `os.environ/VARIABLE_NAME` syntax to reference environment variables,<br/>
        ///   which will be resolved automatically (same as in proxy_config.yaml).<br/>
        /// Returns:<br/>
        ///     dict: A dictionary containing the health check result with either success information or error details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestModelConnectionHealthTestConnectionPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTestModelConnectionHealthTestConnectionPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TestModelConnectionHealthTestConnectionPostSecurityRequirements,
                operationName: "TestModelConnectionHealthTestConnectionPostAsync");

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
                                path: "/health/test_connection",
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
                PrepareTestModelConnectionHealthTestConnectionPostRequest(
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
                                operationId: "TestModelConnectionHealthTestConnectionPost",
                                methodName: "TestModelConnectionHealthTestConnectionPostAsync",
                                pathTemplate: "\"/health/test_connection\"",
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
                                operationId: "TestModelConnectionHealthTestConnectionPost",
                                methodName: "TestModelConnectionHealthTestConnectionPostAsync",
                                pathTemplate: "\"/health/test_connection\"",
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
                                operationId: "TestModelConnectionHealthTestConnectionPost",
                                methodName: "TestModelConnectionHealthTestConnectionPostAsync",
                                pathTemplate: "\"/health/test_connection\"",
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
                ProcessTestModelConnectionHealthTestConnectionPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "TestModelConnectionHealthTestConnectionPost",
                                methodName: "TestModelConnectionHealthTestConnectionPostAsync",
                                pathTemplate: "\"/health/test_connection\"",
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
                                operationId: "TestModelConnectionHealthTestConnectionPost",
                                methodName: "TestModelConnectionHealthTestConnectionPostAsync",
                                pathTemplate: "\"/health/test_connection\"",
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
                                ProcessTestModelConnectionHealthTestConnectionPostResponseContent(
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
        /// Test Model Connection<br/>
        /// Test a direct connection to a specific model.<br/>
        /// This endpoint allows you to verify if your proxy can successfully connect to a specific model.<br/>
        /// It's useful for troubleshooting model connectivity issues without going through the full proxy routing.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// # If model is configured in proxy_config.yaml, you only need to specify the model name:<br/>
        /// curl -X POST 'http://localhost:4000/health/test_connection' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "litellm_params": {<br/>
        ///         "model": "gpt-4o"<br/>
        ///     },<br/>
        ///     "mode": "chat"<br/>
        ///   }'<br/>
        /// # The endpoint will automatically use api_key, api_base, etc. from proxy_config.yaml<br/>
        /// # You can also override specific params or test with custom credentials:<br/>
        /// curl -X POST 'http://localhost:4000/health/test_connection' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "litellm_params": {<br/>
        ///         "model": "azure/gpt-4o",<br/>
        ///         "api_key": "os.environ/AZURE_OPENAI_API_KEY",<br/>
        ///         "api_base": "os.environ/AZURE_OPENAI_ENDPOINT",<br/>
        ///         "api_version": "2024-10-21"<br/>
        ///     },<br/>
        ///     "mode": "chat"<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Note: <br/>
        /// - If the model is configured in proxy_config.yaml, credentials (api_key, api_base, etc.) <br/>
        ///   will be automatically loaded from the config (with resolved environment variables).<br/>
        /// - You can override specific params by including them in the request.<br/>
        /// - You can use `os.environ/VARIABLE_NAME` syntax to reference environment variables,<br/>
        ///   which will be resolved automatically (same as in proxy_config.yaml).<br/>
        /// Returns:<br/>
        ///     dict: A dictionary containing the health check result with either success information or error details.
        /// </summary>
        /// <param name="mode">
        /// The mode to test the model with. If not provided, auto-detected from model capabilities.
        /// </param>
        /// <param name="litellmParams">
        /// Parameters for litellm.completion, litellm.embedding for the health check
        /// </param>
        /// <param name="modelInfo">
        /// Model info for the health check
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> TestModelConnectionHealthTestConnectionPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPostMode2? mode = default,
            object? litellmParams = default,
            object? modelInfo = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPost
            {
                Mode = mode,
                LitellmParams = litellmParams,
                ModelInfo = modelInfo,
            };

            return await TestModelConnectionHealthTestConnectionPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}