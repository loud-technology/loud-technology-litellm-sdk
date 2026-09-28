#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Patch Model<br/>
        /// PATCH Endpoint for partial model updates.<br/>
        /// Only updates the fields specified in the request while preserving other existing values.<br/>
        /// Follows proper PATCH semantics by only modifying provided fields.<br/>
        /// Args:<br/>
        ///     model_id: The ID of the model to update<br/>
        ///     patch_data: The fields to update and their new values<br/>
        ///     user_api_key_dict: User authentication information<br/>
        /// Returns:<br/>
        ///     Updated model information<br/>
        /// Raises:<br/>
        ///     ProxyException: For various error conditions including authentication and database errors
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PatchModelModelModelIdUpdatePatchAsync(
            string modelId,

            global::Loud.Technology.LiteLLM.Sdk.UpdateDeployment request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Model<br/>
        /// PATCH Endpoint for partial model updates.<br/>
        /// Only updates the fields specified in the request while preserving other existing values.<br/>
        /// Follows proper PATCH semantics by only modifying provided fields.<br/>
        /// Args:<br/>
        ///     model_id: The ID of the model to update<br/>
        ///     patch_data: The fields to update and their new values<br/>
        ///     user_api_key_dict: User authentication information<br/>
        /// Returns:<br/>
        ///     Updated model information<br/>
        /// Raises:<br/>
        ///     ProxyException: For various error conditions including authentication and database errors
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> PatchModelModelModelIdUpdatePatchAsResponseAsync(
            string modelId,

            global::Loud.Technology.LiteLLM.Sdk.UpdateDeployment request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Model<br/>
        /// PATCH Endpoint for partial model updates.<br/>
        /// Only updates the fields specified in the request while preserving other existing values.<br/>
        /// Follows proper PATCH semantics by only modifying provided fields.<br/>
        /// Args:<br/>
        ///     model_id: The ID of the model to update<br/>
        ///     patch_data: The fields to update and their new values<br/>
        ///     user_api_key_dict: User authentication information<br/>
        /// Returns:<br/>
        ///     Updated model information<br/>
        /// Raises:<br/>
        ///     ProxyException: For various error conditions including authentication and database errors
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="modelName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="modelInfo"></param>
        /// <param name="blocked"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PatchModelModelModelIdUpdatePatchAsync(
            string modelId,
            string? modelName = default,
            global::Loud.Technology.LiteLLM.Sdk.UpdateLiteLLMParams? litellmParams = default,
            global::Loud.Technology.LiteLLM.Sdk.ModelInfo? modelInfo = default,
            bool? blocked = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}