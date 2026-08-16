#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IRouterSettingsClient
    {
        /// <summary>
        /// Get Router Fields<br/>
        /// Get router settings field definitions without values.<br/>
        /// Returns only the field metadata (type, description, default, options) without<br/>
        /// populating field_value. This is useful for UI components that need to know<br/>
        /// what fields to render, but will get the actual values from a different endpoint.<br/>
        /// Returns:<br/>
        /// - fields: List of all configurable router settings with their metadata (type, description, default, options)<br/>
        ///           The routing_strategy field includes available options extracted from the Router class<br/>
        ///           Note: field_value will be None for all fields<br/>
        /// - routing_strategy_descriptions: Descriptions for each routing strategy option
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RouterFieldsResponse> GetRouterFieldsRouterFieldsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Router Fields<br/>
        /// Get router settings field definitions without values.<br/>
        /// Returns only the field metadata (type, description, default, options) without<br/>
        /// populating field_value. This is useful for UI components that need to know<br/>
        /// what fields to render, but will get the actual values from a different endpoint.<br/>
        /// Returns:<br/>
        /// - fields: List of all configurable router settings with their metadata (type, description, default, options)<br/>
        ///           The routing_strategy field includes available options extracted from the Router class<br/>
        ///           Note: field_value will be None for all fields<br/>
        /// - routing_strategy_descriptions: Descriptions for each routing strategy option
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RouterFieldsResponse>> GetRouterFieldsRouterFieldsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}