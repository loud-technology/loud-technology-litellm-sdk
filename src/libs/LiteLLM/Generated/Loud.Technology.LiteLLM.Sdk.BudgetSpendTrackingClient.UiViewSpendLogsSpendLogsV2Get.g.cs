
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class BudgetSpendTrackingClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_UiViewSpendLogsSpendLogsV2GetSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_UiViewSpendLogsSpendLogsV2GetSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_UiViewSpendLogsSpendLogsV2GetSecurityRequirement0,
            };
        partial void PrepareUiViewSpendLogsSpendLogsV2GetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? apiKey,
            ref string? userId,
            ref string? requestId,
            ref string? sessionId,
            ref string? teamId,
            double? minSpend,
            double? maxSpend,
            ref string? startDate,
            ref string? endDate,
            ref int? page,
            ref int? pageSize,
            ref string? statusFilter,
            ref string? model,
            ref string? modelId,
            ref string? modelGroup,
            ref string? keyAlias,
            ref string? endUser,
            ref string? errorCode,
            ref string? errorMessage,
            ref string? sortBy,
            ref string? sortOrder);
        partial void PrepareUiViewSpendLogsSpendLogsV2GetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? apiKey,
            string? userId,
            string? requestId,
            string? sessionId,
            string? teamId,
            double? minSpend,
            double? maxSpend,
            string? startDate,
            string? endDate,
            int? page,
            int? pageSize,
            string? statusFilter,
            string? model,
            string? modelId,
            string? modelGroup,
            string? keyAlias,
            string? endUser,
            string? errorCode,
            string? errorMessage,
            string? sortBy,
            string? sortOrder);
        partial void ProcessUiViewSpendLogsSpendLogsV2GetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUiViewSpendLogsSpendLogsV2GetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Ui View Spend Logs<br/>
        /// View spend logs with pagination support.<br/>
        /// Available at both `/spend/logs/v2` (public API) and `/spend/logs/ui` (internal UI).<br/>
        /// Returns paginated response with data, total, page, page_size, and total_pages.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs/v2?start_date=2025-11-25%2000:00:00&amp;end_date=2025-11-26%2023:59:59&amp;page=1&amp;page_size=50" -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="apiKey">
        /// Get spend logs based on api key
        /// </param>
        /// <param name="userId">
        /// Get spend logs based on user_id
        /// </param>
        /// <param name="requestId">
        /// request_id to get spend logs for specific request_id
        /// </param>
        /// <param name="sessionId">
        /// Filter spend logs by session_id (partial string match)
        /// </param>
        /// <param name="teamId">
        /// Filter spend logs by team_id
        /// </param>
        /// <param name="minSpend">
        /// Filter logs with spend greater than or equal to this value
        /// </param>
        /// <param name="maxSpend">
        /// Filter logs with spend less than or equal to this value
        /// </param>
        /// <param name="startDate">
        /// Time from which to start viewing key spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view key spend
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="statusFilter">
        /// Filter logs by status (e.g., success, failure)
        /// </param>
        /// <param name="model">
        /// Filter logs by model
        /// </param>
        /// <param name="modelId">
        /// Filter logs by model ID (litellm model deployment id)
        /// </param>
        /// <param name="modelGroup">
        /// Filter logs by model group
        /// </param>
        /// <param name="keyAlias">
        /// Filter logs by key alias
        /// </param>
        /// <param name="endUser">
        /// Filter logs by end user
        /// </param>
        /// <param name="errorCode">
        /// Filter logs by error code (e.g., '404', '500')
        /// </param>
        /// <param name="errorMessage">
        /// Filter logs by error message (partial string match)
        /// </param>
        /// <param name="sortBy">
        /// Sort logs by field: spend, total_tokens, startTime, endTime, request_duration_ms, model, or ttft_ms<br/>
        /// Default Value: startTime
        /// </param>
        /// <param name="sortOrder">
        /// Sort order: asc or desc<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> UiViewSpendLogsSpendLogsV2GetAsync(
            string? apiKey = default,
            string? userId = default,
            string? requestId = default,
            string? sessionId = default,
            string? teamId = default,
            double? minSpend = default,
            double? maxSpend = default,
            string? startDate = default,
            string? endDate = default,
            int? page = default,
            int? pageSize = default,
            string? statusFilter = default,
            string? model = default,
            string? modelId = default,
            string? modelGroup = default,
            string? keyAlias = default,
            string? endUser = default,
            string? errorCode = default,
            string? errorMessage = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UiViewSpendLogsSpendLogsV2GetAsResponseAsync(
                apiKey: apiKey,
                userId: userId,
                requestId: requestId,
                sessionId: sessionId,
                teamId: teamId,
                minSpend: minSpend,
                maxSpend: maxSpend,
                startDate: startDate,
                endDate: endDate,
                page: page,
                pageSize: pageSize,
                statusFilter: statusFilter,
                model: model,
                modelId: modelId,
                modelGroup: modelGroup,
                keyAlias: keyAlias,
                endUser: endUser,
                errorCode: errorCode,
                errorMessage: errorMessage,
                sortBy: sortBy,
                sortOrder: sortOrder,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Ui View Spend Logs<br/>
        /// View spend logs with pagination support.<br/>
        /// Available at both `/spend/logs/v2` (public API) and `/spend/logs/ui` (internal UI).<br/>
        /// Returns paginated response with data, total, page, page_size, and total_pages.<br/>
        /// Example:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:8000/spend/logs/v2?start_date=2025-11-25%2000:00:00&amp;end_date=2025-11-26%2023:59:59&amp;page=1&amp;page_size=50" -H "Authorization: Bearer sk-1234"<br/>
        /// ```
        /// </summary>
        /// <param name="apiKey">
        /// Get spend logs based on api key
        /// </param>
        /// <param name="userId">
        /// Get spend logs based on user_id
        /// </param>
        /// <param name="requestId">
        /// request_id to get spend logs for specific request_id
        /// </param>
        /// <param name="sessionId">
        /// Filter spend logs by session_id (partial string match)
        /// </param>
        /// <param name="teamId">
        /// Filter spend logs by team_id
        /// </param>
        /// <param name="minSpend">
        /// Filter logs with spend greater than or equal to this value
        /// </param>
        /// <param name="maxSpend">
        /// Filter logs with spend less than or equal to this value
        /// </param>
        /// <param name="startDate">
        /// Time from which to start viewing key spend
        /// </param>
        /// <param name="endDate">
        /// Time till which to view key spend
        /// </param>
        /// <param name="page">
        /// Page number for pagination<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pageSize">
        /// Number of items per page<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="statusFilter">
        /// Filter logs by status (e.g., success, failure)
        /// </param>
        /// <param name="model">
        /// Filter logs by model
        /// </param>
        /// <param name="modelId">
        /// Filter logs by model ID (litellm model deployment id)
        /// </param>
        /// <param name="modelGroup">
        /// Filter logs by model group
        /// </param>
        /// <param name="keyAlias">
        /// Filter logs by key alias
        /// </param>
        /// <param name="endUser">
        /// Filter logs by end user
        /// </param>
        /// <param name="errorCode">
        /// Filter logs by error code (e.g., '404', '500')
        /// </param>
        /// <param name="errorMessage">
        /// Filter logs by error message (partial string match)
        /// </param>
        /// <param name="sortBy">
        /// Sort logs by field: spend, total_tokens, startTime, endTime, request_duration_ms, model, or ttft_ms<br/>
        /// Default Value: startTime
        /// </param>
        /// <param name="sortOrder">
        /// Sort order: asc or desc<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UiViewSpendLogsSpendLogsV2GetAsResponseAsync(
            string? apiKey = default,
            string? userId = default,
            string? requestId = default,
            string? sessionId = default,
            string? teamId = default,
            double? minSpend = default,
            double? maxSpend = default,
            string? startDate = default,
            string? endDate = default,
            int? page = default,
            int? pageSize = default,
            string? statusFilter = default,
            string? model = default,
            string? modelId = default,
            string? modelGroup = default,
            string? keyAlias = default,
            string? endUser = default,
            string? errorCode = default,
            string? errorMessage = default,
            string? sortBy = default,
            string? sortOrder = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUiViewSpendLogsSpendLogsV2GetArguments(
                httpClient: HttpClient,
                apiKey: ref apiKey,
                userId: ref userId,
                requestId: ref requestId,
                sessionId: ref sessionId,
                teamId: ref teamId,
                minSpend: minSpend,
                maxSpend: maxSpend,
                startDate: ref startDate,
                endDate: ref endDate,
                page: ref page,
                pageSize: ref pageSize,
                statusFilter: ref statusFilter,
                model: ref model,
                modelId: ref modelId,
                modelGroup: ref modelGroup,
                keyAlias: ref keyAlias,
                endUser: ref endUser,
                errorCode: ref errorCode,
                errorMessage: ref errorMessage,
                sortBy: ref sortBy,
                sortOrder: ref sortOrder);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UiViewSpendLogsSpendLogsV2GetSecurityRequirements,
                operationName: "UiViewSpendLogsSpendLogsV2GetAsync");

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
                                path: "/spend/logs/v2",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("api_key", apiKey)
                                .AddOptionalParameter("user_id", userId)
                                .AddOptionalParameter("request_id", requestId)
                                .AddOptionalParameter("session_id", sessionId)
                                .AddOptionalParameter("team_id", teamId)
                                .AddOptionalParameter("min_spend", minSpend?.ToString())
                                .AddOptionalParameter("max_spend", maxSpend?.ToString())
                                .AddOptionalParameter("start_date", startDate)
                                .AddOptionalParameter("end_date", endDate)
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("status_filter", statusFilter)
                                .AddOptionalParameter("model", model)
                                .AddOptionalParameter("model_id", modelId)
                                .AddOptionalParameter("model_group", modelGroup)
                                .AddOptionalParameter("key_alias", keyAlias)
                                .AddOptionalParameter("end_user", endUser)
                                .AddOptionalParameter("error_code", errorCode)
                                .AddOptionalParameter("error_message", errorMessage)
                                .AddOptionalParameter("sort_by", sortBy)
                                .AddOptionalParameter("sort_order", sortOrder)
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
                PrepareUiViewSpendLogsSpendLogsV2GetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    apiKey: apiKey,
                    userId: userId,
                    requestId: requestId,
                    sessionId: sessionId,
                    teamId: teamId,
                    minSpend: minSpend,
                    maxSpend: maxSpend,
                    startDate: startDate,
                    endDate: endDate,
                    page: page,
                    pageSize: pageSize,
                    statusFilter: statusFilter,
                    model: model,
                    modelId: modelId,
                    modelGroup: modelGroup,
                    keyAlias: keyAlias,
                    endUser: endUser,
                    errorCode: errorCode,
                    errorMessage: errorMessage,
                    sortBy: sortBy,
                    sortOrder: sortOrder);

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
                                operationId: "UiViewSpendLogsSpendLogsV2Get",
                                methodName: "UiViewSpendLogsSpendLogsV2GetAsync",
                                pathTemplate: "\"/spend/logs/v2\"",
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
                                operationId: "UiViewSpendLogsSpendLogsV2Get",
                                methodName: "UiViewSpendLogsSpendLogsV2GetAsync",
                                pathTemplate: "\"/spend/logs/v2\"",
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
                                operationId: "UiViewSpendLogsSpendLogsV2Get",
                                methodName: "UiViewSpendLogsSpendLogsV2GetAsync",
                                pathTemplate: "\"/spend/logs/v2\"",
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
                ProcessUiViewSpendLogsSpendLogsV2GetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UiViewSpendLogsSpendLogsV2Get",
                                methodName: "UiViewSpendLogsSpendLogsV2GetAsync",
                                pathTemplate: "\"/spend/logs/v2\"",
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
                                operationId: "UiViewSpendLogsSpendLogsV2Get",
                                methodName: "UiViewSpendLogsSpendLogsV2GetAsync",
                                pathTemplate: "\"/spend/logs/v2\"",
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
                                ProcessUiViewSpendLogsSpendLogsV2GetResponseContent(
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