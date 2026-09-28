#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ILiteLLMClient
    {
        /// <summary>
        /// Update Pass Through Endpoints<br/>
        /// Update a pass-through endpoint by ID.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePassThroughEndpointsConfigPassThroughEndpointEndpointIdPostAsync(
            string endpointId,

            global::Loud.Technology.LiteLLM.Sdk.PassThroughGenericEndpoint request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pass Through Endpoints<br/>
        /// Update a pass-through endpoint by ID.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdatePassThroughEndpointsConfigPassThroughEndpointEndpointIdPostAsResponseAsync(
            string endpointId,

            global::Loud.Technology.LiteLLM.Sdk.PassThroughGenericEndpoint request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Pass Through Endpoints<br/>
        /// Update a pass-through endpoint by ID.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="id">
        /// Optional unique identifier for the pass-through endpoint. If not provided, endpoints will be identified by path for backwards compatibility.
        /// </param>
        /// <param name="path">
        /// The route to be added to the LiteLLM Proxy Server.
        /// </param>
        /// <param name="target">
        /// The URL to which requests for this path should be forwarded.
        /// </param>
        /// <param name="headers">
        /// Key-value pairs of headers to be forwarded with the request. You can set any key value pair here and it will be forwarded to your target endpoint<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="defaultQueryParams">
        /// Key-value pairs of default query parameters to be sent with every request to this endpoint. These can be overridden by client-provided query parameters. For example: {'key': 'default_value', 'api_version': '2023-01'}<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="includeSubpath">
        /// If True, requests to subpaths of the path will be forwarded to the target endpoint. For example, if the path is /bria and include_subpath is True, requests to /bria/v1/text-to-image/base/2.3 will be forwarded to the target endpoint.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="costPerRequest">
        /// The USD cost per request to the target endpoint. This is used to calculate the cost of the request to the target endpoint.<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="timeout">
        /// Upstream request timeout in seconds for this pass-through endpoint. If unset, uses general_settings.pass_through_request_timeout (default 600).
        /// </param>
        /// <param name="auth">
        /// Whether authentication is required for the pass-through endpoint. Defaults to True so a pass-through silently created without an explicit value still requires a valid LiteLLM API key — set to False only if the endpoint is meant to be a public forwarder (e.g. an unauthenticated webhook target).<br/>
        /// Default Value: true
        /// </param>
        /// <param name="guardrails">
        /// Guardrails configuration for this passthrough endpoint. Dict keys are guardrail names, values are optional settings for field targeting. When set, all org/team/key level guardrails will also execute. Defaults to None (no guardrails execute).
        /// </param>
        /// <param name="isFromConfig">
        /// True if this endpoint is defined in the config file, False if from DB. Config-defined endpoints cannot be edited via the UI.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="methods">
        /// List of HTTP methods this endpoint handles (e.g., ['GET', 'POST']). If None or empty, all methods (GET, POST, PUT, DELETE, PATCH) are supported for backward compatibility. This allows the same path to have different targets for different HTTP methods.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdatePassThroughEndpointsConfigPassThroughEndpointEndpointIdPostAsync(
            string endpointId,
            string path,
            string target,
            string? id = default,
            object? headers = default,
            object? defaultQueryParams = default,
            bool? includeSubpath = default,
            double? costPerRequest = default,
            double? timeout = default,
            bool? auth = default,
            object? guardrails = default,
            bool? isFromConfig = default,
            global::System.Collections.Generic.IList<string>? methods = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}