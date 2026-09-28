
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class ClaudeCodeMarketplaceClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_UpdatePluginClaudeCodePluginsPluginNamePutSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_UpdatePluginClaudeCodePluginsPluginNamePutSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_UpdatePluginClaudeCodePluginsPluginNamePutSecurityRequirement0,
            };
        partial void PrepareUpdatePluginClaudeCodePluginsPluginNamePutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pluginName,
            global::Loud.Technology.LiteLLM.Sdk.UpdatePluginRequest request);
        partial void PrepareUpdatePluginClaudeCodePluginsPluginNamePutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pluginName,
            global::Loud.Technology.LiteLLM.Sdk.UpdatePluginRequest request);
        partial void ProcessUpdatePluginClaudeCodePluginsPluginNamePutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdatePluginClaudeCodePluginsPluginNamePutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Plugin<br/>
        /// Update an existing plugin in the LiteLLM marketplace.<br/>
        /// The plugin is identified by its name in the path, which is the resource<br/>
        /// identity and cannot be changed here. This is a full replace, not a merge:<br/>
        /// the manifest is rebuilt from the request body, so any optional field left<br/>
        /// out is reset to its default (e.g. an omitted version is cleared, not kept).<br/>
        /// Send the full desired state.<br/>
        /// Returns 404 if no plugin with the given name exists; use<br/>
        /// POST /claude-code/plugins to create a new plugin.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: Name of the plugin to update (path parameter)<br/>
        ///     - source: Plugin source reference (github, url, git-subdir, or archive format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Update status (action is always "updated") and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X PUT http://localhost:4000/claude-code/plugins/my-plugin \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "2.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse> UpdatePluginClaudeCodePluginsPluginNamePutAsync(
            string pluginName,

            global::Loud.Technology.LiteLLM.Sdk.UpdatePluginRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UpdatePluginClaudeCodePluginsPluginNamePutAsResponseAsync(
                pluginName: pluginName,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update Plugin<br/>
        /// Update an existing plugin in the LiteLLM marketplace.<br/>
        /// The plugin is identified by its name in the path, which is the resource<br/>
        /// identity and cannot be changed here. This is a full replace, not a merge:<br/>
        /// the manifest is rebuilt from the request body, so any optional field left<br/>
        /// out is reset to its default (e.g. an omitted version is cleared, not kept).<br/>
        /// Send the full desired state.<br/>
        /// Returns 404 if no plugin with the given name exists; use<br/>
        /// POST /claude-code/plugins to create a new plugin.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: Name of the plugin to update (path parameter)<br/>
        ///     - source: Plugin source reference (github, url, git-subdir, or archive format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Update status (action is always "updated") and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X PUT http://localhost:4000/claude-code/plugins/my-plugin \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "2.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse>> UpdatePluginClaudeCodePluginsPluginNamePutAsResponseAsync(
            string pluginName,

            global::Loud.Technology.LiteLLM.Sdk.UpdatePluginRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdatePluginClaudeCodePluginsPluginNamePutArguments(
                httpClient: HttpClient,
                pluginName: ref pluginName,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpdatePluginClaudeCodePluginsPluginNamePutSecurityRequirements,
                operationName: "UpdatePluginClaudeCodePluginsPluginNamePutAsync");

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
                                path: $"/claude-code/plugins/{pluginName}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Put,
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
                PrepareUpdatePluginClaudeCodePluginsPluginNamePutRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    pluginName: pluginName!,
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
                                operationId: "UpdatePluginClaudeCodePluginsPluginNamePut",
                                methodName: "UpdatePluginClaudeCodePluginsPluginNamePutAsync",
                                pathTemplate: "$\"/claude-code/plugins/{pluginName}\"",
                                httpMethod: "PUT",
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
                                operationId: "UpdatePluginClaudeCodePluginsPluginNamePut",
                                methodName: "UpdatePluginClaudeCodePluginsPluginNamePutAsync",
                                pathTemplate: "$\"/claude-code/plugins/{pluginName}\"",
                                httpMethod: "PUT",
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
                                operationId: "UpdatePluginClaudeCodePluginsPluginNamePut",
                                methodName: "UpdatePluginClaudeCodePluginsPluginNamePutAsync",
                                pathTemplate: "$\"/claude-code/plugins/{pluginName}\"",
                                httpMethod: "PUT",
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
                ProcessUpdatePluginClaudeCodePluginsPluginNamePutResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdatePluginClaudeCodePluginsPluginNamePut",
                                methodName: "UpdatePluginClaudeCodePluginsPluginNamePutAsync",
                                pathTemplate: "$\"/claude-code/plugins/{pluginName}\"",
                                httpMethod: "PUT",
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
                                operationId: "UpdatePluginClaudeCodePluginsPluginNamePut",
                                methodName: "UpdatePluginClaudeCodePluginsPluginNamePutAsync",
                                pathTemplate: "$\"/claude-code/plugins/{pluginName}\"",
                                httpMethod: "PUT",
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
                                ProcessUpdatePluginClaudeCodePluginsPluginNamePutResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse>(
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
        /// Update Plugin<br/>
        /// Update an existing plugin in the LiteLLM marketplace.<br/>
        /// The plugin is identified by its name in the path, which is the resource<br/>
        /// identity and cannot be changed here. This is a full replace, not a merge:<br/>
        /// the manifest is rebuilt from the request body, so any optional field left<br/>
        /// out is reset to its default (e.g. an omitted version is cleared, not kept).<br/>
        /// Send the full desired state.<br/>
        /// Returns 404 if no plugin with the given name exists; use<br/>
        /// POST /claude-code/plugins to create a new plugin.<br/>
        /// Requires a proxy admin API key.<br/>
        /// Parameters:<br/>
        ///     - plugin_name: Name of the plugin to update (path parameter)<br/>
        ///     - source: Plugin source reference (github, url, git-subdir, or archive format)<br/>
        ///     - version: Semantic version (optional)<br/>
        ///     - description: Plugin description (optional)<br/>
        ///     - author: Author information (optional)<br/>
        ///     - homepage: Plugin homepage URL (optional)<br/>
        ///     - keywords: Search keywords (optional)<br/>
        ///     - category: Plugin category (optional)<br/>
        /// Returns:<br/>
        ///     Update status (action is always "updated") and plugin information.<br/>
        /// Example:<br/>
        ///     ```bash<br/>
        ///     curl -X PUT http://localhost:4000/claude-code/plugins/my-plugin \<br/>
        ///       -H "Authorization: Bearer sk-..." \<br/>
        ///       -H "Content-Type: application/json" \<br/>
        ///       -d '{<br/>
        ///         "source": {"source": "github", "repo": "org/my-plugin"},<br/>
        ///         "version": "2.0.0",<br/>
        ///         "description": "My awesome plugin"<br/>
        ///       }'<br/>
        ///     ```
        /// </summary>
        /// <param name="pluginName"></param>
        /// <param name="author">
        /// Plugin author
        /// </param>
        /// <param name="category">
        /// Plugin category
        /// </param>
        /// <param name="description">
        /// Plugin description
        /// </param>
        /// <param name="domain">
        /// Skill domain (e.g., 'Productivity')
        /// </param>
        /// <param name="homepage">
        /// Plugin homepage URL
        /// </param>
        /// <param name="keywords">
        /// Search keywords
        /// </param>
        /// <param name="namespace">
        /// Skill namespace within domain (e.g., 'workflows')
        /// </param>
        /// <param name="source">
        /// Plugin source reference. Supported formats:<br/>
        /// - GitHub: {'source': 'github', 'repo': 'org/repo'}<br/>
        /// - Git URL: {'source': 'url', 'url': 'https://github.com/org/repo.git'}<br/>
        /// - Git Subdir: {'source': 'git-subdir', 'url': 'https://github.com/org/repo.git', 'path': 'plugins/plugin-name'}<br/>
        /// - Zip archive on any https host (e.g. S3): {'source': 'archive', 'url': 'https://bucket.s3.amazonaws.com/plugin.zip', 'sha256': '&lt;optional hex digest&gt;'}
        /// </param>
        /// <param name="version">
        /// Semantic version; cleared if omitted
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RegisterPluginResponse> UpdatePluginClaudeCodePluginsPluginNamePutAsync(
            string pluginName,
            global::System.Collections.Generic.Dictionary<string, string> source,
            global::Loud.Technology.LiteLLM.Sdk.PluginAuthor? author = default,
            string? category = default,
            string? description = default,
            string? domain = default,
            string? homepage = default,
            global::System.Collections.Generic.IList<string>? keywords = default,
            string? @namespace = default,
            string? version = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.UpdatePluginRequest
            {
                Author = author,
                Category = category,
                Description = description,
                Domain = domain,
                Homepage = homepage,
                Keywords = keywords,
                Namespace = @namespace,
                Source = source,
                Version = version,
            };

            return await UpdatePluginClaudeCodePluginsPluginNamePutAsync(
                pluginName: pluginName,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}