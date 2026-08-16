
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial class ModelManagementClient
    {


        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement s_ModelGroupInfoModelGroupInfoGetSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[] s_ModelGroupInfoModelGroupInfoGetSecurityRequirements =
            new global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityRequirement[]
            {                s_ModelGroupInfoModelGroupInfoGetSecurityRequirement0,
            };
        partial void PrepareModelGroupInfoModelGroupInfoGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? modelGroup);
        partial void PrepareModelGroupInfoModelGroupInfoGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? modelGroup);
        partial void ProcessModelGroupInfoModelGroupInfoGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModelGroupInfoModelGroupInfoGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Model Group Info<br/>
        /// Get information about all the deployments on litellm proxy, including config.yaml descriptions (except api key and api base)<br/>
        /// - /model_group/info returns all model groups. End users of proxy should use /model_group/info since those models will be used for /chat/completions, /embeddings, etc.<br/>
        /// - /model_group/info?model_group=rerank-english-v3.0 returns all model groups for a specific model group (`model_name` in config.yaml)<br/>
        /// Example Request (All Models):<br/>
        /// ```shell<br/>
        /// curl -X 'GET'     'http://localhost:4000/model_group/info'     -H 'accept: application/json'     -H 'x-api-key: sk-1234'<br/>
        /// ```<br/>
        /// Example Request (Specific Model Group):<br/>
        /// ```shell<br/>
        /// curl -X 'GET'     'http://localhost:4000/model_group/info?model_group=rerank-english-v3.0'     -H 'accept: application/json'     -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Example Request (Specific Wildcard Model Group): (e.g. `model_name: openai/*` on config.yaml)<br/>
        /// ```shell<br/>
        /// curl -X 'GET'     'http://localhost:4000/model_group/info?model_group=openai/tts-1'<br/>
        /// -H 'accept: application/json'     -H 'Authorization: Bearersk-1234'<br/>
        /// ```<br/>
        /// Learn how to use and set wildcard models [here](https://docs.litellm.ai/docs/wildcard_routing)<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        ///     {<br/>
        ///         "data": [<br/>
        ///             {<br/>
        ///             "model_group": "rerank-english-v3.0",<br/>
        ///             "providers": [<br/>
        ///                 "cohere"<br/>
        ///             ],<br/>
        ///             "max_input_tokens": null,<br/>
        ///             "max_output_tokens": null,<br/>
        ///             "input_cost_per_token": 0.0,<br/>
        ///             "output_cost_per_token": 0.0,<br/>
        ///             "mode": null,<br/>
        ///             "tpm": null,<br/>
        ///             "rpm": null,<br/>
        ///             "supports_parallel_function_calling": false,<br/>
        ///             "supports_vision": false,<br/>
        ///             "supports_function_calling": false,<br/>
        ///             "supported_openai_params": [<br/>
        ///                 "stream",<br/>
        ///                 "temperature",<br/>
        ///                 "max_tokens",<br/>
        ///                 "logit_bias",<br/>
        ///                 "top_p",<br/>
        ///                 "frequency_penalty",<br/>
        ///                 "presence_penalty",<br/>
        ///                 "stop",<br/>
        ///                 "n",<br/>
        ///                 "extra_headers"<br/>
        ///             ]<br/>
        ///             },<br/>
        ///             {<br/>
        ///             "model_group": "gpt-3.5-turbo",<br/>
        ///             "providers": [<br/>
        ///                 "openai"<br/>
        ///             ],<br/>
        ///             "max_input_tokens": 16385.0,<br/>
        ///             "max_output_tokens": 4096.0,<br/>
        ///             "input_cost_per_token": 1.5e-06,<br/>
        ///             "output_cost_per_token": 2e-06,<br/>
        ///             "mode": "chat",<br/>
        ///             "tpm": null,<br/>
        ///             "rpm": null,<br/>
        ///             "supports_parallel_function_calling": false,<br/>
        ///             "supports_vision": false,<br/>
        ///             "supports_function_calling": true,<br/>
        ///             "supported_openai_params": [<br/>
        ///                 "frequency_penalty",<br/>
        ///                 "logit_bias",<br/>
        ///                 "logprobs",<br/>
        ///                 "top_logprobs",<br/>
        ///                 "max_tokens",<br/>
        ///                 "max_completion_tokens",<br/>
        ///                 "n",<br/>
        ///                 "presence_penalty",<br/>
        ///                 "seed",<br/>
        ///                 "stop",<br/>
        ///                 "stream",<br/>
        ///                 "stream_options",<br/>
        ///                 "temperature",<br/>
        ///                 "top_p",<br/>
        ///                 "tools",<br/>
        ///                 "tool_choice",<br/>
        ///                 "function_call",<br/>
        ///                 "functions",<br/>
        ///                 "max_retries",<br/>
        ///                 "extra_headers",<br/>
        ///                 "parallel_tool_calls",<br/>
        ///                 "response_format"<br/>
        ///             ]<br/>
        ///             },<br/>
        ///             {<br/>
        ///             "model_group": "llava-hf",<br/>
        ///             "providers": [<br/>
        ///                 "openai"<br/>
        ///             ],<br/>
        ///             "max_input_tokens": null,<br/>
        ///             "max_output_tokens": null,<br/>
        ///             "input_cost_per_token": 0.0,<br/>
        ///             "output_cost_per_token": 0.0,<br/>
        ///             "mode": null,<br/>
        ///             "tpm": null,<br/>
        ///             "rpm": null,<br/>
        ///             "supports_parallel_function_calling": false,<br/>
        ///             "supports_vision": true,<br/>
        ///             "supports_function_calling": false,<br/>
        ///             "supported_openai_params": [<br/>
        ///                 "frequency_penalty",<br/>
        ///                 "logit_bias",<br/>
        ///                 "logprobs",<br/>
        ///                 "top_logprobs",<br/>
        ///                 "max_tokens",<br/>
        ///                 "max_completion_tokens",<br/>
        ///                 "n",<br/>
        ///                 "presence_penalty",<br/>
        ///                 "seed",<br/>
        ///                 "stop",<br/>
        ///                 "stream",<br/>
        ///                 "stream_options",<br/>
        ///                 "temperature",<br/>
        ///                 "top_p",<br/>
        ///                 "tools",<br/>
        ///                 "tool_choice",<br/>
        ///                 "function_call",<br/>
        ///                 "functions",<br/>
        ///                 "max_retries",<br/>
        ///                 "extra_headers",<br/>
        ///                 "parallel_tool_calls",<br/>
        ///                 "response_format"<br/>
        ///             ]<br/>
        ///             }<br/>
        ///         ]<br/>
        ///         }<br/>
        /// ```
        /// </summary>
        /// <param name="modelGroup"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> ModelGroupInfoModelGroupInfoGetAsync(
            string? modelGroup = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ModelGroupInfoModelGroupInfoGetAsResponseAsync(
                modelGroup: modelGroup,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Model Group Info<br/>
        /// Get information about all the deployments on litellm proxy, including config.yaml descriptions (except api key and api base)<br/>
        /// - /model_group/info returns all model groups. End users of proxy should use /model_group/info since those models will be used for /chat/completions, /embeddings, etc.<br/>
        /// - /model_group/info?model_group=rerank-english-v3.0 returns all model groups for a specific model group (`model_name` in config.yaml)<br/>
        /// Example Request (All Models):<br/>
        /// ```shell<br/>
        /// curl -X 'GET'     'http://localhost:4000/model_group/info'     -H 'accept: application/json'     -H 'x-api-key: sk-1234'<br/>
        /// ```<br/>
        /// Example Request (Specific Model Group):<br/>
        /// ```shell<br/>
        /// curl -X 'GET'     'http://localhost:4000/model_group/info?model_group=rerank-english-v3.0'     -H 'accept: application/json'     -H 'Authorization: Bearer sk-1234'<br/>
        /// ```<br/>
        /// Example Request (Specific Wildcard Model Group): (e.g. `model_name: openai/*` on config.yaml)<br/>
        /// ```shell<br/>
        /// curl -X 'GET'     'http://localhost:4000/model_group/info?model_group=openai/tts-1'<br/>
        /// -H 'accept: application/json'     -H 'Authorization: Bearersk-1234'<br/>
        /// ```<br/>
        /// Learn how to use and set wildcard models [here](https://docs.litellm.ai/docs/wildcard_routing)<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        ///     {<br/>
        ///         "data": [<br/>
        ///             {<br/>
        ///             "model_group": "rerank-english-v3.0",<br/>
        ///             "providers": [<br/>
        ///                 "cohere"<br/>
        ///             ],<br/>
        ///             "max_input_tokens": null,<br/>
        ///             "max_output_tokens": null,<br/>
        ///             "input_cost_per_token": 0.0,<br/>
        ///             "output_cost_per_token": 0.0,<br/>
        ///             "mode": null,<br/>
        ///             "tpm": null,<br/>
        ///             "rpm": null,<br/>
        ///             "supports_parallel_function_calling": false,<br/>
        ///             "supports_vision": false,<br/>
        ///             "supports_function_calling": false,<br/>
        ///             "supported_openai_params": [<br/>
        ///                 "stream",<br/>
        ///                 "temperature",<br/>
        ///                 "max_tokens",<br/>
        ///                 "logit_bias",<br/>
        ///                 "top_p",<br/>
        ///                 "frequency_penalty",<br/>
        ///                 "presence_penalty",<br/>
        ///                 "stop",<br/>
        ///                 "n",<br/>
        ///                 "extra_headers"<br/>
        ///             ]<br/>
        ///             },<br/>
        ///             {<br/>
        ///             "model_group": "gpt-3.5-turbo",<br/>
        ///             "providers": [<br/>
        ///                 "openai"<br/>
        ///             ],<br/>
        ///             "max_input_tokens": 16385.0,<br/>
        ///             "max_output_tokens": 4096.0,<br/>
        ///             "input_cost_per_token": 1.5e-06,<br/>
        ///             "output_cost_per_token": 2e-06,<br/>
        ///             "mode": "chat",<br/>
        ///             "tpm": null,<br/>
        ///             "rpm": null,<br/>
        ///             "supports_parallel_function_calling": false,<br/>
        ///             "supports_vision": false,<br/>
        ///             "supports_function_calling": true,<br/>
        ///             "supported_openai_params": [<br/>
        ///                 "frequency_penalty",<br/>
        ///                 "logit_bias",<br/>
        ///                 "logprobs",<br/>
        ///                 "top_logprobs",<br/>
        ///                 "max_tokens",<br/>
        ///                 "max_completion_tokens",<br/>
        ///                 "n",<br/>
        ///                 "presence_penalty",<br/>
        ///                 "seed",<br/>
        ///                 "stop",<br/>
        ///                 "stream",<br/>
        ///                 "stream_options",<br/>
        ///                 "temperature",<br/>
        ///                 "top_p",<br/>
        ///                 "tools",<br/>
        ///                 "tool_choice",<br/>
        ///                 "function_call",<br/>
        ///                 "functions",<br/>
        ///                 "max_retries",<br/>
        ///                 "extra_headers",<br/>
        ///                 "parallel_tool_calls",<br/>
        ///                 "response_format"<br/>
        ///             ]<br/>
        ///             },<br/>
        ///             {<br/>
        ///             "model_group": "llava-hf",<br/>
        ///             "providers": [<br/>
        ///                 "openai"<br/>
        ///             ],<br/>
        ///             "max_input_tokens": null,<br/>
        ///             "max_output_tokens": null,<br/>
        ///             "input_cost_per_token": 0.0,<br/>
        ///             "output_cost_per_token": 0.0,<br/>
        ///             "mode": null,<br/>
        ///             "tpm": null,<br/>
        ///             "rpm": null,<br/>
        ///             "supports_parallel_function_calling": false,<br/>
        ///             "supports_vision": true,<br/>
        ///             "supports_function_calling": false,<br/>
        ///             "supported_openai_params": [<br/>
        ///                 "frequency_penalty",<br/>
        ///                 "logit_bias",<br/>
        ///                 "logprobs",<br/>
        ///                 "top_logprobs",<br/>
        ///                 "max_tokens",<br/>
        ///                 "max_completion_tokens",<br/>
        ///                 "n",<br/>
        ///                 "presence_penalty",<br/>
        ///                 "seed",<br/>
        ///                 "stop",<br/>
        ///                 "stream",<br/>
        ///                 "stream_options",<br/>
        ///                 "temperature",<br/>
        ///                 "top_p",<br/>
        ///                 "tools",<br/>
        ///                 "tool_choice",<br/>
        ///                 "function_call",<br/>
        ///                 "functions",<br/>
        ///                 "max_retries",<br/>
        ///                 "extra_headers",<br/>
        ///                 "parallel_tool_calls",<br/>
        ///                 "response_format"<br/>
        ///             ]<br/>
        ///             }<br/>
        ///         ]<br/>
        ///         }<br/>
        /// ```
        /// </summary>
        /// <param name="modelGroup"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ModelGroupInfoModelGroupInfoGetAsResponseAsync(
            string? modelGroup = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareModelGroupInfoModelGroupInfoGetArguments(
                httpClient: HttpClient,
                modelGroup: ref modelGroup);


            var __authorizations = global::Loud.Technology.LiteLLM.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ModelGroupInfoModelGroupInfoGetSecurityRequirements,
                operationName: "ModelGroupInfoModelGroupInfoGetAsync");

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
                                path: "/model_group/info",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("model_group", modelGroup)
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
                PrepareModelGroupInfoModelGroupInfoGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    modelGroup: modelGroup);

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
                                operationId: "ModelGroupInfoModelGroupInfoGet",
                                methodName: "ModelGroupInfoModelGroupInfoGetAsync",
                                pathTemplate: "\"/model_group/info\"",
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
                                operationId: "ModelGroupInfoModelGroupInfoGet",
                                methodName: "ModelGroupInfoModelGroupInfoGetAsync",
                                pathTemplate: "\"/model_group/info\"",
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
                                operationId: "ModelGroupInfoModelGroupInfoGet",
                                methodName: "ModelGroupInfoModelGroupInfoGetAsync",
                                pathTemplate: "\"/model_group/info\"",
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
                ProcessModelGroupInfoModelGroupInfoGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ModelGroupInfoModelGroupInfoGet",
                                methodName: "ModelGroupInfoModelGroupInfoGetAsync",
                                pathTemplate: "\"/model_group/info\"",
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
                                operationId: "ModelGroupInfoModelGroupInfoGet",
                                methodName: "ModelGroupInfoModelGroupInfoGetAsync",
                                pathTemplate: "\"/model_group/info\"",
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
                                ProcessModelGroupInfoModelGroupInfoGetResponseContent(
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