#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
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
        global::System.Threading.Tasks.Task<string> ModelGroupInfoModelGroupInfoGetAsync(
            string? modelGroup = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ModelGroupInfoModelGroupInfoGetAsResponseAsync(
            string? modelGroup = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}