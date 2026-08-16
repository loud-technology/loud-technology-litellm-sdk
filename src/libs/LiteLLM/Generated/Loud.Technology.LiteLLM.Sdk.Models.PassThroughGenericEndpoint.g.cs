
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PassThroughGenericEndpoint
    {
        /// <summary>
        /// Optional unique identifier for the pass-through endpoint. If not provided, endpoints will be identified by path for backwards compatibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The route to be added to the LiteLLM Proxy Server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The URL to which requests for this path should be forwarded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Target { get; set; }

        /// <summary>
        /// Key-value pairs of headers to be forwarded with the request. You can set any key value pair here and it will be forwarded to your target endpoint<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Key-value pairs of default query parameters to be sent with every request to this endpoint. These can be overridden by client-provided query parameters. For example: {'key': 'default_value', 'api_version': '2023-01'}<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_query_params")]
        public object? DefaultQueryParams { get; set; }

        /// <summary>
        /// If True, requests to subpaths of the path will be forwarded to the target endpoint. For example, if the path is /bria and include_subpath is True, requests to /bria/v1/text-to-image/base/2.3 will be forwarded to the target endpoint.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_subpath")]
        public bool? IncludeSubpath { get; set; }

        /// <summary>
        /// The USD cost per request to the target endpoint. This is used to calculate the cost of the request to the target endpoint.<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_request")]
        public double? CostPerRequest { get; set; }

        /// <summary>
        /// Upstream request timeout in seconds for this pass-through endpoint. If unset, uses general_settings.pass_through_request_timeout (default 600).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Whether authentication is required for the pass-through endpoint. Defaults to True so a pass-through silently created without an explicit value still requires a valid LiteLLM API key — set to False only if the endpoint is meant to be a public forwarder (e.g. an unauthenticated webhook target).<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public bool? Auth { get; set; }

        /// <summary>
        /// Guardrails configuration for this passthrough endpoint. Dict keys are guardrail names, values are optional settings for field targeting. When set, all org/team/key level guardrails will also execute. Defaults to None (no guardrails execute).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrails")]
        public object? Guardrails { get; set; }

        /// <summary>
        /// True if this endpoint is defined in the config file, False if from DB. Config-defined endpoints cannot be edited via the UI.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_from_config")]
        public bool? IsFromConfig { get; set; }

        /// <summary>
        /// List of HTTP methods this endpoint handles (e.g., ['GET', 'POST']). If None or empty, all methods (GET, POST, PUT, DELETE, PATCH) are supported for backward compatibility. This allows the same path to have different targets for different HTTP methods.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("methods")]
        public global::System.Collections.Generic.IList<string>? Methods { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PassThroughGenericEndpoint" /> class.
        /// </summary>
        /// <param name="path">
        /// The route to be added to the LiteLLM Proxy Server.
        /// </param>
        /// <param name="target">
        /// The URL to which requests for this path should be forwarded.
        /// </param>
        /// <param name="id">
        /// Optional unique identifier for the pass-through endpoint. If not provided, endpoints will be identified by path for backwards compatibility.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PassThroughGenericEndpoint(
            string path,
            string target,
            string? id,
            object? headers,
            object? defaultQueryParams,
            bool? includeSubpath,
            double? costPerRequest,
            double? timeout,
            bool? auth,
            object? guardrails,
            bool? isFromConfig,
            global::System.Collections.Generic.IList<string>? methods)
        {
            this.Id = id;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
            this.Headers = headers;
            this.DefaultQueryParams = defaultQueryParams;
            this.IncludeSubpath = includeSubpath;
            this.CostPerRequest = costPerRequest;
            this.Timeout = timeout;
            this.Auth = auth;
            this.Guardrails = guardrails;
            this.IsFromConfig = isFromConfig;
            this.Methods = methods;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PassThroughGenericEndpoint" /> class.
        /// </summary>
        public PassThroughGenericEndpoint()
        {
        }

    }
}