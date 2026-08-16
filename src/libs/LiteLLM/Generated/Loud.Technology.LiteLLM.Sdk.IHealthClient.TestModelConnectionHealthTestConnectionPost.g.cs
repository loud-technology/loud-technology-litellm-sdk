#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IHealthClient
    {
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
        global::System.Threading.Tasks.Task<string> TestModelConnectionHealthTestConnectionPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> TestModelConnectionHealthTestConnectionPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<string> TestModelConnectionHealthTestConnectionPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPostMode2? mode = default,
            object? litellmParams = default,
            object? modelInfo = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}