#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Update Websearch Interception Settings<br/>
        /// Update web search interception settings in database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateWebsearchInterceptionSettingsUpdateWebsearchInterceptionSettingsPatchAsync(

            global::Loud.Technology.LiteLLM.Sdk.WebSearchInterceptionSettings request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Websearch Interception Settings<br/>
        /// Update web search interception settings in database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateWebsearchInterceptionSettingsUpdateWebsearchInterceptionSettingsPatchAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.WebSearchInterceptionSettings request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Websearch Interception Settings<br/>
        /// Update web search interception settings in database.<br/>
        /// Settings will be picked up by all pods within approximately 10 seconds via background polling.
        /// </summary>
        /// <param name="enabled">
        /// Serve web search tool calls from a configured search tool instead of passing them upstream<br/>
        /// Default Value: false
        /// </param>
        /// <param name="enabledProviders">
        /// LLM providers to intercept for (e.g. 'bedrock', 'vertex_ai'). Empty intercepts Bedrock only.
        /// </param>
        /// <param name="searchToolName">
        /// Name of the configured search tool to run searches through. Empty uses the first one available.
        /// </param>
        /// <param name="maxAgenticLoops">
        /// How many follow-up model calls one intercepted request may chain. Empty applies the default of 3.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateWebsearchInterceptionSettingsUpdateWebsearchInterceptionSettingsPatchAsync(
            bool? enabled = default,
            global::System.Collections.Generic.IList<string>? enabledProviders = default,
            string? searchToolName = default,
            int? maxAgenticLoops = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}