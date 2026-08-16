#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGoogleGenaiEndpointsClient
    {
        /// <summary>
        /// Google Count Tokens<br/>
        /// ```json<br/>
        /// return {<br/>
        ///     "totalTokens": 31,<br/>
        ///     "totalBillableCharacters": 96,<br/>
        ///     "promptTokensDetails": [<br/>
        ///         {<br/>
        ///         "modality": "TEXT",<br/>
        ///         "tokenCount": 31<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TokenCountDetailsResponse> GoogleCountTokensModelsModelNameCountTokensPostAsync(
            string modelName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Google Count Tokens<br/>
        /// ```json<br/>
        /// return {<br/>
        ///     "totalTokens": 31,<br/>
        ///     "totalBillableCharacters": 96,<br/>
        ///     "promptTokensDetails": [<br/>
        ///         {<br/>
        ///         "modality": "TEXT",<br/>
        ///         "tokenCount": 31<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TokenCountDetailsResponse>> GoogleCountTokensModelsModelNameCountTokensPostAsResponseAsync(
            string modelName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}