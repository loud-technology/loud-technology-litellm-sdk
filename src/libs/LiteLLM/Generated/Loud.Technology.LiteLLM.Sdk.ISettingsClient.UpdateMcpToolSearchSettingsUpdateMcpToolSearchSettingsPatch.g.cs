#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Update Mcp Tool Search Settings<br/>
        /// Update `litellm_settings.mcp_tool_search` in the database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateMcpToolSearchSettingsUpdateMcpToolSearchSettingsPatchAsync(

            global::Loud.Technology.LiteLLM.Sdk.MCPToolSearchSettings request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Tool Search Settings<br/>
        /// Update `litellm_settings.mcp_tool_search` in the database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateMcpToolSearchSettingsUpdateMcpToolSearchSettingsPatchAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.MCPToolSearchSettings request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Tool Search Settings<br/>
        /// Update `litellm_settings.mcp_tool_search` in the database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="embeddingModel">
        /// Embedding model from model_list used to rank tools by meaning. Unset keeps keyword matching.
        /// </param>
        /// <param name="topK">
        /// Most ranked tools a search returns. A smaller top_k in the tool call wins. Core tools do not count.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="similarityThreshold">
        /// Lowest cosine similarity a tool needs to appear in semantic results (0.0 = no cutoff).<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="coreTools">
        /// Tool names always returned first when the caller can access them, e.g. `my_server-get_rates`.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateMcpToolSearchSettingsUpdateMcpToolSearchSettingsPatchAsync(
            string? embeddingModel = default,
            int? topK = default,
            double? similarityThreshold = default,
            global::System.Collections.Generic.IList<string>? coreTools = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}