#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Add New Model<br/>
        /// Allows adding new models to the model list in the config.yaml
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AddNewModelModelNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.Deployment request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add New Model<br/>
        /// Allows adding new models to the model list in the config.yaml
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> AddNewModelModelNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.Deployment request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add New Model<br/>
        /// Allows adding new models to the model list in the config.yaml
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="litellmParams">
        /// LiteLLM Params with 'model' requirement - used for completions
        /// </param>
        /// <param name="modelInfo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AddNewModelModelNewPostAsync(
            string modelName,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMParams litellmParams,
            global::Loud.Technology.LiteLLM.Sdk.ModelInfo modelInfo,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}