#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IRouterSettingsClient
    {
        /// <summary>
        /// Get Router Settings<br/>
        /// Get router configuration and available settings.<br/>
        /// Returns:<br/>
        /// - fields: List of all configurable router settings with their metadata (type, description, default, options)<br/>
        ///           The routing_strategy field includes available options extracted from the Router class<br/>
        /// - current_values: Current values of router settings from config
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RouterSettingsResponse> GetRouterSettingsRouterSettingsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Router Settings<br/>
        /// Get router configuration and available settings.<br/>
        /// Returns:<br/>
        /// - fields: List of all configurable router settings with their metadata (type, description, default, options)<br/>
        ///           The routing_strategy field includes available options extracted from the Router class<br/>
        /// - current_values: Current values of router settings from config
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RouterSettingsResponse>> GetRouterSettingsRouterSettingsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}