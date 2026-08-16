
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class ProjectManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_UpdateProjectProjectUpdatePostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_UpdateProjectProjectUpdatePostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_UpdateProjectProjectUpdatePostSecurityRequirement0,
            };
        partial void PrepareUpdateProjectProjectUpdatePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.LiteLLM.Sdk.UpdateProjectRequest request);
        partial void PrepareUpdateProjectProjectUpdatePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.LiteLLM.Sdk.UpdateProjectRequest request);
        partial void ProcessUpdateProjectProjectUpdatePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateProjectProjectUpdatePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Project<br/>
        /// Update a project<br/>
        /// Parameters:<br/>
        /// - project_id: *str* - The project id to update. Required.<br/>
        /// - project_alias: *Optional[str]* - Updated name for the project<br/>
        /// - description: *Optional[str]* - Updated description for the project<br/>
        /// - team_id: *Optional[str]* - Updated team_id for the project<br/>
        /// - metadata: *Optional[dict]* - Updated metadata for project<br/>
        /// - models: *Optional[list]* - Updated list of models for the project<br/>
        /// - blocked: *Optional[bool]* - Updated blocked status<br/>
        /// - max_budget: *Optional[float]* - Updated max budget<br/>
        /// - tpm_limit: *Optional[int]* - Updated tpm limit<br/>
        /// - rpm_limit: *Optional[int]* - Updated rpm limit<br/>
        /// - model_rpm_limit: *Optional[dict]* - Updated RPM limits per model<br/>
        /// - model_tpm_limit: *Optional[dict]* - Updated TPM limits per model<br/>
        /// - budget_duration: *Optional[str]* - Updated budget duration<br/>
        /// - tags: *Optional[list]* - Updated list of tags for the project<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Updated object permission<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/update' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_id": "project-123",<br/>
        ///     "description": "Updated flight search system with enhanced capabilities",<br/>
        ///     "max_budget": 200,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 2000,<br/>
        ///         "gpt-3.5-turbo": 10000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "status": "active"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable> UpdateProjectProjectUpdatePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateProjectRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UpdateProjectProjectUpdatePostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update Project<br/>
        /// Update a project<br/>
        /// Parameters:<br/>
        /// - project_id: *str* - The project id to update. Required.<br/>
        /// - project_alias: *Optional[str]* - Updated name for the project<br/>
        /// - description: *Optional[str]* - Updated description for the project<br/>
        /// - team_id: *Optional[str]* - Updated team_id for the project<br/>
        /// - metadata: *Optional[dict]* - Updated metadata for project<br/>
        /// - models: *Optional[list]* - Updated list of models for the project<br/>
        /// - blocked: *Optional[bool]* - Updated blocked status<br/>
        /// - max_budget: *Optional[float]* - Updated max budget<br/>
        /// - tpm_limit: *Optional[int]* - Updated tpm limit<br/>
        /// - rpm_limit: *Optional[int]* - Updated rpm limit<br/>
        /// - model_rpm_limit: *Optional[dict]* - Updated RPM limits per model<br/>
        /// - model_tpm_limit: *Optional[dict]* - Updated TPM limits per model<br/>
        /// - budget_duration: *Optional[str]* - Updated budget duration<br/>
        /// - tags: *Optional[list]* - Updated list of tags for the project<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Updated object permission<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/update' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_id": "project-123",<br/>
        ///     "description": "Updated flight search system with enhanced capabilities",<br/>
        ///     "max_budget": 200,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 2000,<br/>
        ///         "gpt-3.5-turbo": 10000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "status": "active"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable>> UpdateProjectProjectUpdatePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.UpdateProjectRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateProjectProjectUpdatePostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UpdateProjectProjectUpdatePostSecurityRequirements,
                operationName: "UpdateProjectProjectUpdatePostAsync");

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
                                path: "/project/update",
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
                PrepareUpdateProjectProjectUpdatePostRequest(
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
                                operationId: "UpdateProjectProjectUpdatePost",
                                methodName: "UpdateProjectProjectUpdatePostAsync",
                                pathTemplate: "\"/project/update\"",
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
                                operationId: "UpdateProjectProjectUpdatePost",
                                methodName: "UpdateProjectProjectUpdatePostAsync",
                                pathTemplate: "\"/project/update\"",
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
                                operationId: "UpdateProjectProjectUpdatePost",
                                methodName: "UpdateProjectProjectUpdatePostAsync",
                                pathTemplate: "\"/project/update\"",
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
                ProcessUpdateProjectProjectUpdatePostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UpdateProjectProjectUpdatePost",
                                methodName: "UpdateProjectProjectUpdatePostAsync",
                                pathTemplate: "\"/project/update\"",
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
                                operationId: "UpdateProjectProjectUpdatePost",
                                methodName: "UpdateProjectProjectUpdatePostAsync",
                                pathTemplate: "\"/project/update\"",
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
                                ProcessUpdateProjectProjectUpdatePostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable>(
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
        /// Update Project<br/>
        /// Update a project<br/>
        /// Parameters:<br/>
        /// - project_id: *str* - The project id to update. Required.<br/>
        /// - project_alias: *Optional[str]* - Updated name for the project<br/>
        /// - description: *Optional[str]* - Updated description for the project<br/>
        /// - team_id: *Optional[str]* - Updated team_id for the project<br/>
        /// - metadata: *Optional[dict]* - Updated metadata for project<br/>
        /// - models: *Optional[list]* - Updated list of models for the project<br/>
        /// - blocked: *Optional[bool]* - Updated blocked status<br/>
        /// - max_budget: *Optional[float]* - Updated max budget<br/>
        /// - tpm_limit: *Optional[int]* - Updated tpm limit<br/>
        /// - rpm_limit: *Optional[int]* - Updated rpm limit<br/>
        /// - model_rpm_limit: *Optional[dict]* - Updated RPM limits per model<br/>
        /// - model_tpm_limit: *Optional[dict]* - Updated TPM limits per model<br/>
        /// - budget_duration: *Optional[str]* - Updated budget duration<br/>
        /// - tags: *Optional[list]* - Updated list of tags for the project<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Updated object permission<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/update' \<br/>
        /// --header 'Authorization: Bearer sk-1234' \<br/>
        /// --header 'Content-Type: application/json' \<br/>
        /// --data '{<br/>
        ///     "project_id": "project-123",<br/>
        ///     "description": "Updated flight search system with enhanced capabilities",<br/>
        ///     "max_budget": 200,<br/>
        ///     "model_rpm_limit": {<br/>
        ///         "gpt-4": 2000,<br/>
        ///         "gpt-3.5-turbo": 10000<br/>
        ///     },<br/>
        ///     "metadata": {<br/>
        ///         "use_case_id": "SNOW-12345",<br/>
        ///         "status": "active"<br/>
        ///     }<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="softBudget"></param>
        /// <param name="maxBudget"></param>
        /// <param name="maxParallelRequests"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="modelMaxBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="allowedModels"></param>
        /// <param name="projectId"></param>
        /// <param name="projectAlias"></param>
        /// <param name="description"></param>
        /// <param name="teamId"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="models"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="blocked"></param>
        /// <param name="objectPermission"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable> UpdateProjectProjectUpdatePostAsync(
            string projectId,
            string? budgetId = default,
            double? softBudget = default,
            double? maxBudget = default,
            int? maxParallelRequests = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            object? modelMaxBudget = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            string? projectAlias = default,
            string? description = default,
            string? teamId = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? guardrails = default,
            global::System.Collections.Generic.IList<string>? policies = default,
            global::System.Collections.Generic.IList<string>? models = default,
            object? modelRpmLimit = default,
            object? modelTpmLimit = default,
            bool? blocked = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.UpdateProjectRequest
            {
                BudgetId = budgetId,
                SoftBudget = softBudget,
                MaxBudget = maxBudget,
                MaxParallelRequests = maxParallelRequests,
                TpmLimit = tpmLimit,
                RpmLimit = rpmLimit,
                ModelMaxBudget = modelMaxBudget,
                BudgetDuration = budgetDuration,
                AllowedModels = allowedModels,
                ProjectId = projectId,
                ProjectAlias = projectAlias,
                Description = description,
                TeamId = teamId,
                Metadata = metadata,
                Tags = tags,
                Guardrails = guardrails,
                Policies = policies,
                Models = models,
                ModelRpmLimit = modelRpmLimit,
                ModelTpmLimit = modelTpmLimit,
                Blocked = blocked,
                ObjectPermission = objectPermission,
            };

            return await UpdateProjectProjectUpdatePostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}