#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILlmUtilsClient
    {
        /// <summary>
        /// Model Info Lookup<br/>
        /// Returns the model cost map entry (token limits, pricing, supports_* capabilities) for any model<br/>
        /// in the cost map, whether or not it is registered on this proxy. `model_info` carries every<br/>
        /// field of the raw cost map entry plus the typed fields `litellm.get_model_info` derives from it<br/>
        /// (`key`, `supported_openai_params`).<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X GET --location 'http://localhost:4000/utils/model_info?model=gpt-4o&amp;custom_llm_provider=openai'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="customLlmProvider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ModelInfoLookupUtilsModelInfoGetAsync(
            string model,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Model Info Lookup<br/>
        /// Returns the model cost map entry (token limits, pricing, supports_* capabilities) for any model<br/>
        /// in the cost map, whether or not it is registered on this proxy. `model_info` carries every<br/>
        /// field of the raw cost map entry plus the typed fields `litellm.get_model_info` derives from it<br/>
        /// (`key`, `supported_openai_params`).<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl -X GET --location 'http://localhost:4000/utils/model_info?model=gpt-4o&amp;custom_llm_provider=openai'         --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="customLlmProvider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ModelInfoLookupUtilsModelInfoGetAsResponseAsync(
            string model,
            string? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}