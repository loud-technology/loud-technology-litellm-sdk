
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class TeamManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_AddTeamCallbacksTeamTeamIdCallbackPostSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_AddTeamCallbacksTeamTeamIdCallbackPostSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_AddTeamCallbacksTeamTeamIdCallbackPostSecurityRequirement0,
            };
        partial void PrepareAddTeamCallbacksTeamTeamIdCallbackPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string teamId,
            ref string? litellmChangedBy,
            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallback request);
        partial void PrepareAddTeamCallbacksTeamTeamIdCallbackPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string teamId,
            string? litellmChangedBy,
            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallback request);
        partial void ProcessAddTeamCallbacksTeamTeamIdCallbackPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddTeamCallbacksTeamTeamIdCallbackPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Team Callbacks<br/>
        /// Add a success/failure callback to a team<br/>
        /// Use this if if you want different teams to have different success/failure callbacks<br/>
        /// Parameters:<br/>
        /// - callback_name (Literal["langfuse", "langsmith", "gcs"], required): The name of the callback to add<br/>
        /// - callback_type (Literal["success", "failure", "success_and_failure"], required): The type of callback to add. One of:<br/>
        ///     - "success": Callback for successful LLM calls<br/>
        ///     - "failure": Callback for failed LLM calls<br/>
        ///     - "success_and_failure": Callback for both successful and failed LLM calls<br/>
        /// - callback_vars (StandardCallbackDynamicParams, required): A dictionary of variables to pass to the callback<br/>
        ///     - langfuse_public_key: The public key for the Langfuse callback<br/>
        ///     - langfuse_secret_key: The secret key for the Langfuse callback<br/>
        ///     - langfuse_secret: The secret for the Langfuse callback<br/>
        ///     - langfuse_host: The host for the Langfuse callback<br/>
        ///     - gcs_bucket_name: The name of the GCS bucket<br/>
        ///     - gcs_path_service_account: The path to the GCS service account<br/>
        ///     - langsmith_api_key: The API key for the Langsmith callback<br/>
        ///     - langsmith_project: The project for the Langsmith callback<br/>
        ///     - langsmith_base_url: The base URL for the Langsmith callback<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST 'http:/localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///     "callback_name": "langfuse",<br/>
        ///     "callback_type": "success",<br/>
        ///     "callback_vars": {"langfuse_public_key": "pk-lf-xxxx1", "langfuse_secret_key": "sk-xxxxx"}<br/>
        ///     <br/>
        /// }'<br/>
        /// ```<br/>
        /// This means for the team where team_id = dbe2f686-a686-4896-864a-4c3924458709, all LLM calls will be logged to langfuse using the public key pk-lf-xxxx1 and the secret key sk-xxxxx
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> AddTeamCallbacksTeamTeamIdCallbackPostAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallback request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await AddTeamCallbacksTeamTeamIdCallbackPostAsResponseAsync(
                teamId: teamId,

                request: request,
                litellmChangedBy: litellmChangedBy,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Add Team Callbacks<br/>
        /// Add a success/failure callback to a team<br/>
        /// Use this if if you want different teams to have different success/failure callbacks<br/>
        /// Parameters:<br/>
        /// - callback_name (Literal["langfuse", "langsmith", "gcs"], required): The name of the callback to add<br/>
        /// - callback_type (Literal["success", "failure", "success_and_failure"], required): The type of callback to add. One of:<br/>
        ///     - "success": Callback for successful LLM calls<br/>
        ///     - "failure": Callback for failed LLM calls<br/>
        ///     - "success_and_failure": Callback for both successful and failed LLM calls<br/>
        /// - callback_vars (StandardCallbackDynamicParams, required): A dictionary of variables to pass to the callback<br/>
        ///     - langfuse_public_key: The public key for the Langfuse callback<br/>
        ///     - langfuse_secret_key: The secret key for the Langfuse callback<br/>
        ///     - langfuse_secret: The secret for the Langfuse callback<br/>
        ///     - langfuse_host: The host for the Langfuse callback<br/>
        ///     - gcs_bucket_name: The name of the GCS bucket<br/>
        ///     - gcs_path_service_account: The path to the GCS service account<br/>
        ///     - langsmith_api_key: The API key for the Langsmith callback<br/>
        ///     - langsmith_project: The project for the Langsmith callback<br/>
        ///     - langsmith_base_url: The base URL for the Langsmith callback<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST 'http:/localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///     "callback_name": "langfuse",<br/>
        ///     "callback_type": "success",<br/>
        ///     "callback_vars": {"langfuse_public_key": "pk-lf-xxxx1", "langfuse_secret_key": "sk-xxxxx"}<br/>
        ///     <br/>
        /// }'<br/>
        /// ```<br/>
        /// This means for the team where team_id = dbe2f686-a686-4896-864a-4c3924458709, all LLM calls will be logged to langfuse using the public key pk-lf-xxxx1 and the secret key sk-xxxxx
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AddTeamCallbacksTeamTeamIdCallbackPostAsResponseAsync(
            string teamId,

            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallback request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAddTeamCallbacksTeamTeamIdCallbackPostArguments(
                httpClient: HttpClient,
                teamId: ref teamId,
                litellmChangedBy: ref litellmChangedBy,
                request: request);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AddTeamCallbacksTeamTeamIdCallbackPostSecurityRequirements,
                operationName: "AddTeamCallbacksTeamTeamIdCallbackPostAsync");

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
                                path: $"/team/{teamId}/callback",
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
                PrepareAddTeamCallbacksTeamTeamIdCallbackPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    teamId: teamId!,
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
                                operationId: "AddTeamCallbacksTeamTeamIdCallbackPost",
                                methodName: "AddTeamCallbacksTeamTeamIdCallbackPostAsync",
                                pathTemplate: "$\"/team/{teamId}/callback\"",
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
                                operationId: "AddTeamCallbacksTeamTeamIdCallbackPost",
                                methodName: "AddTeamCallbacksTeamTeamIdCallbackPostAsync",
                                pathTemplate: "$\"/team/{teamId}/callback\"",
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
                                operationId: "AddTeamCallbacksTeamTeamIdCallbackPost",
                                methodName: "AddTeamCallbacksTeamTeamIdCallbackPostAsync",
                                pathTemplate: "$\"/team/{teamId}/callback\"",
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
                ProcessAddTeamCallbacksTeamTeamIdCallbackPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AddTeamCallbacksTeamTeamIdCallbackPost",
                                methodName: "AddTeamCallbacksTeamTeamIdCallbackPostAsync",
                                pathTemplate: "$\"/team/{teamId}/callback\"",
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
                                operationId: "AddTeamCallbacksTeamTeamIdCallbackPost",
                                methodName: "AddTeamCallbacksTeamTeamIdCallbackPostAsync",
                                pathTemplate: "$\"/team/{teamId}/callback\"",
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
                                ProcessAddTeamCallbacksTeamTeamIdCallbackPostResponseContent(
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
        /// Add Team Callbacks<br/>
        /// Add a success/failure callback to a team<br/>
        /// Use this if if you want different teams to have different success/failure callbacks<br/>
        /// Parameters:<br/>
        /// - callback_name (Literal["langfuse", "langsmith", "gcs"], required): The name of the callback to add<br/>
        /// - callback_type (Literal["success", "failure", "success_and_failure"], required): The type of callback to add. One of:<br/>
        ///     - "success": Callback for successful LLM calls<br/>
        ///     - "failure": Callback for failed LLM calls<br/>
        ///     - "success_and_failure": Callback for both successful and failed LLM calls<br/>
        /// - callback_vars (StandardCallbackDynamicParams, required): A dictionary of variables to pass to the callback<br/>
        ///     - langfuse_public_key: The public key for the Langfuse callback<br/>
        ///     - langfuse_secret_key: The secret key for the Langfuse callback<br/>
        ///     - langfuse_secret: The secret for the Langfuse callback<br/>
        ///     - langfuse_host: The host for the Langfuse callback<br/>
        ///     - gcs_bucket_name: The name of the GCS bucket<br/>
        ///     - gcs_path_service_account: The path to the GCS service account<br/>
        ///     - langsmith_api_key: The API key for the Langsmith callback<br/>
        ///     - langsmith_project: The project for the Langsmith callback<br/>
        ///     - langsmith_base_url: The base URL for the Langsmith callback<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X POST 'http:/localhost:4000/team/dbe2f686-a686-4896-864a-4c3924458709/callback'         -H 'Content-Type: application/json'         -H 'Authorization: Bearer sk-1234'         -d '{<br/>
        ///     "callback_name": "langfuse",<br/>
        ///     "callback_type": "success",<br/>
        ///     "callback_vars": {"langfuse_public_key": "pk-lf-xxxx1", "langfuse_secret_key": "sk-xxxxx"}<br/>
        ///     <br/>
        /// }'<br/>
        /// ```<br/>
        /// This means for the team where team_id = dbe2f686-a686-4896-864a-4c3924458709, all LLM calls will be logged to langfuse using the public key pk-lf-xxxx1 and the secret key sk-xxxxx
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="callbackName"></param>
        /// <param name="callbackType">
        /// Default Value: success_and_failure
        /// </param>
        /// <param name="callbackVars"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> AddTeamCallbacksTeamTeamIdCallbackPostAsync(
            string teamId,
            string callbackName,
            global::System.Collections.Generic.Dictionary<string, string> callbackVars,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallbackCallbackType2? callbackType = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.LiteLLM.Sdk.AddTeamCallback
            {
                CallbackName = callbackName,
                CallbackType = callbackType,
                CallbackVars = callbackVars,
            };

            return await AddTeamCallbacksTeamTeamIdCallbackPostAsync(
                teamId: teamId,
                litellmChangedBy: litellmChangedBy,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}