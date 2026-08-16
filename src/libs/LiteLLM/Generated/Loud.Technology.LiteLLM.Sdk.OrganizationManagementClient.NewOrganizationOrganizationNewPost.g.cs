
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class OrganizationManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_NewOrganizationOrganizationNewPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_NewOrganizationOrganizationNewPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_NewOrganizationOrganizationNewPostSecurityRequirement0,
            };
        partial void PrepareNewOrganizationOrganizationNewPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loud.Technology.LiteLLM.Sdk.NewOrganizationRequest request);
        partial void PrepareNewOrganizationOrganizationNewPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loud.Technology.LiteLLM.Sdk.NewOrganizationRequest request);
        partial void ProcessNewOrganizationOrganizationNewPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessNewOrganizationOrganizationNewPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// New Organization<br/>
        /// Allow orgs to own teams<br/>
        /// Set org level budgets + model access.<br/>
        /// Only admins can create orgs.<br/>
        /// # Parameters<br/>
        /// - organization_alias: *str* - The name of the organization.<br/>
        /// - models: *List* - The models the organization has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the organization.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for org<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for org<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for org<br/>
        /// - model_rpm_limit: *Optional[Dict[str, int]]* - The RPM (Requests Per Minute) limit per model for this organization.<br/>
        /// - model_tpm_limit: *Optional[Dict[str, int]]* - The TPM (Tokens Per Minute) limit per model for this organization.<br/>
        /// - max_parallel_requests: *Optional[int]* - [Not Implemented Yet] Max parallel requests for org<br/>
        /// - soft_budget: *Optional[float]* - [Not Implemented Yet] Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting org budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for organization, store information for organization. Example metadata - {"extra_info": "some info"}<br/>
        /// - blocked: *bool* - Flag indicating if the org is blocked or not - will stop all calls from keys with this org_id.<br/>
        /// - tags: *Optional[List[str]]* - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - organization_id: *Optional[str]* - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - organization-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// - allowed_models: Optional[List[str]] - List of models the organization is allowed to access. If not set, defaults to the models field.<br/>
        /// Case 1: Create new org **without** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "max_budget": 100<br/>
        /// }'<br/>
        /// ```<br/>
        /// Case 2: Create new org **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse> NewOrganizationOrganizationNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewOrganizationRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await NewOrganizationOrganizationNewPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// New Organization<br/>
        /// Allow orgs to own teams<br/>
        /// Set org level budgets + model access.<br/>
        /// Only admins can create orgs.<br/>
        /// # Parameters<br/>
        /// - organization_alias: *str* - The name of the organization.<br/>
        /// - models: *List* - The models the organization has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the organization.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for org<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for org<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for org<br/>
        /// - model_rpm_limit: *Optional[Dict[str, int]]* - The RPM (Requests Per Minute) limit per model for this organization.<br/>
        /// - model_tpm_limit: *Optional[Dict[str, int]]* - The TPM (Tokens Per Minute) limit per model for this organization.<br/>
        /// - max_parallel_requests: *Optional[int]* - [Not Implemented Yet] Max parallel requests for org<br/>
        /// - soft_budget: *Optional[float]* - [Not Implemented Yet] Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting org budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for organization, store information for organization. Example metadata - {"extra_info": "some info"}<br/>
        /// - blocked: *bool* - Flag indicating if the org is blocked or not - will stop all calls from keys with this org_id.<br/>
        /// - tags: *Optional[List[str]]* - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - organization_id: *Optional[str]* - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - organization-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// - allowed_models: Optional[List[str]] - List of models the organization is allowed to access. If not set, defaults to the models field.<br/>
        /// Case 1: Create new org **without** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "max_budget": 100<br/>
        /// }'<br/>
        /// ```<br/>
        /// Case 2: Create new org **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689"<br/>
        /// }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse>> NewOrganizationOrganizationNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewOrganizationRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareNewOrganizationOrganizationNewPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_NewOrganizationOrganizationNewPostSecurityRequirements,
                operationName: "NewOrganizationOrganizationNewPostAsync");

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
                                path: "/organization/new",
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
                PrepareNewOrganizationOrganizationNewPostRequest(
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
                                operationId: "NewOrganizationOrganizationNewPost",
                                methodName: "NewOrganizationOrganizationNewPostAsync",
                                pathTemplate: "\"/organization/new\"",
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
                                operationId: "NewOrganizationOrganizationNewPost",
                                methodName: "NewOrganizationOrganizationNewPostAsync",
                                pathTemplate: "\"/organization/new\"",
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
                                operationId: "NewOrganizationOrganizationNewPost",
                                methodName: "NewOrganizationOrganizationNewPostAsync",
                                pathTemplate: "\"/organization/new\"",
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
                ProcessNewOrganizationOrganizationNewPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "NewOrganizationOrganizationNewPost",
                                methodName: "NewOrganizationOrganizationNewPostAsync",
                                pathTemplate: "\"/organization/new\"",
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
                                operationId: "NewOrganizationOrganizationNewPost",
                                methodName: "NewOrganizationOrganizationNewPostAsync",
                                pathTemplate: "\"/organization/new\"",
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
                                ProcessNewOrganizationOrganizationNewPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse>(
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

                                    var __value = await global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse>(
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
        /// New Organization<br/>
        /// Allow orgs to own teams<br/>
        /// Set org level budgets + model access.<br/>
        /// Only admins can create orgs.<br/>
        /// # Parameters<br/>
        /// - organization_alias: *str* - The name of the organization.<br/>
        /// - models: *List* - The models the organization has access to.<br/>
        /// - budget_id: *Optional[str]* - The id for a budget (tpm/rpm/max budget) for the organization.<br/>
        /// ### IF NO BUDGET ID - CREATE ONE WITH THESE PARAMS ###<br/>
        /// - max_budget: *Optional[float]* - Max budget for org<br/>
        /// - tpm_limit: *Optional[int]* - Max tpm limit for org<br/>
        /// - rpm_limit: *Optional[int]* - Max rpm limit for org<br/>
        /// - model_rpm_limit: *Optional[Dict[str, int]]* - The RPM (Requests Per Minute) limit per model for this organization.<br/>
        /// - model_tpm_limit: *Optional[Dict[str, int]]* - The TPM (Tokens Per Minute) limit per model for this organization.<br/>
        /// - max_parallel_requests: *Optional[int]* - [Not Implemented Yet] Max parallel requests for org<br/>
        /// - soft_budget: *Optional[float]* - [Not Implemented Yet] Get a slack alert when this soft budget is reached. Don't block requests.<br/>
        /// - model_max_budget: *Optional[dict]* - Max budget for a specific model<br/>
        /// - budget_duration: *Optional[str]* - Frequency of reseting org budget<br/>
        /// - metadata: *Optional[dict]* - Metadata for organization, store information for organization. Example metadata - {"extra_info": "some info"}<br/>
        /// - blocked: *bool* - Flag indicating if the org is blocked or not - will stop all calls from keys with this org_id.<br/>
        /// - tags: *Optional[List[str]]* - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - organization_id: *Optional[str]* - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - organization-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"]}. IF null or {} then no object permission.<br/>
        /// - allowed_models: Optional[List[str]] - List of models the organization is allowed to access. If not set, defaults to the models field.<br/>
        /// Case 1: Create new org **without** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "max_budget": 100<br/>
        /// }'<br/>
        /// ```<br/>
        /// Case 2: Create new org **with** a budget_id<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/organization/new' <br/>
        /// --header 'Authorization: Bearer sk-1234' <br/>
        /// --header 'Content-Type: application/json' <br/>
        /// --data '{<br/>
        ///     "organization_alias": "my-secret-org",<br/>
        ///     "models": ["model1", "model2"],<br/>
        ///     "budget_id": "428eeaa8-f3ac-4e85-a8fb-7dc8d7aa8689"<br/>
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
        /// <param name="organizationId"></param>
        /// <param name="organizationAlias"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="objectPermission"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewOrganizationResponse> NewOrganizationOrganizationNewPostAsync(
            string organizationAlias,
            string? budgetId = default,
            double? softBudget = default,
            double? maxBudget = default,
            int? maxParallelRequests = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            object? modelMaxBudget = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<string>? allowedModels = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<object>? models = default,
            object? metadata = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelRpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelTpmLimit = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.NewOrganizationRequest
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
                OrganizationId = organizationId,
                OrganizationAlias = organizationAlias,
                Models = models,
                Metadata = metadata,
                ModelRpmLimit = modelRpmLimit,
                ModelTpmLimit = modelTpmLimit,
                ObjectPermission = objectPermission,
            };

            return await NewOrganizationOrganizationNewPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}