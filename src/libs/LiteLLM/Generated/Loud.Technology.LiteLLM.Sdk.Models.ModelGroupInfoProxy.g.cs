
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelGroupInfoProxy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Providers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_input_tokens")]
        public double? MaxInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public double? MaxOutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token")]
        public double? InputCostPerToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token")]
        public double? OutputCostPerToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_pixel")]
        public double? InputCostPerPixel { get; set; }

        /// <summary>
        /// Default Value: chat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::Loud.Technology.LiteLLM.Sdk.ModelGroupInfoProxyMode?, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::Loud.Technology.LiteLLM.Sdk.ModelGroupInfoProxyMode?, object>? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm")]
        public int? Tpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm")]
        public int? Rpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itpm")]
        public int? Itpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpm")]
        public int? Otpm { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_parallel_function_calling")]
        public bool? SupportsParallelFunctionCalling { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_vision")]
        public bool? SupportsVision { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_web_search")]
        public bool? SupportsWebSearch { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_url_context")]
        public bool? SupportsUrlContext { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_reasoning")]
        public bool? SupportsReasoning { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_function_calling")]
        public bool? SupportsFunctionCalling { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_openai_params")]
        public global::System.Collections.Generic.IList<string>? SupportedOpenaiParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurable_clientside_auth_params")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::Loud.Technology.LiteLLM.Sdk.ConfigurableClientsideParamsCustomAuthOutput>>? ConfigurableClientsideAuthParams { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public_model_group")]
        public bool? IsPublicModelGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_status")]
        public string? HealthStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_response_time")]
        public double? HealthResponseTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_checked_at")]
        public string? HealthCheckedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelGroupInfoProxy" /> class.
        /// </summary>
        /// <param name="modelGroup"></param>
        /// <param name="providers"></param>
        /// <param name="maxInputTokens"></param>
        /// <param name="maxOutputTokens"></param>
        /// <param name="inputCostPerToken"></param>
        /// <param name="outputCostPerToken"></param>
        /// <param name="inputCostPerPixel"></param>
        /// <param name="mode">
        /// Default Value: chat
        /// </param>
        /// <param name="tpm"></param>
        /// <param name="rpm"></param>
        /// <param name="itpm"></param>
        /// <param name="otpm"></param>
        /// <param name="supportsParallelFunctionCalling">
        /// Default Value: false
        /// </param>
        /// <param name="supportsVision">
        /// Default Value: false
        /// </param>
        /// <param name="supportsWebSearch">
        /// Default Value: false
        /// </param>
        /// <param name="supportsUrlContext">
        /// Default Value: false
        /// </param>
        /// <param name="supportsReasoning">
        /// Default Value: false
        /// </param>
        /// <param name="supportsFunctionCalling">
        /// Default Value: false
        /// </param>
        /// <param name="supportedOpenaiParams">
        /// Default Value: []
        /// </param>
        /// <param name="configurableClientsideAuthParams"></param>
        /// <param name="isPublicModelGroup">
        /// Default Value: false
        /// </param>
        /// <param name="healthStatus"></param>
        /// <param name="healthResponseTime"></param>
        /// <param name="healthCheckedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelGroupInfoProxy(
            string modelGroup,
            global::System.Collections.Generic.IList<string> providers,
            double? maxInputTokens,
            double? maxOutputTokens,
            double? inputCostPerToken,
            double? outputCostPerToken,
            double? inputCostPerPixel,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::Loud.Technology.LiteLLM.Sdk.ModelGroupInfoProxyMode?, object>? mode,
            int? tpm,
            int? rpm,
            int? itpm,
            int? otpm,
            bool? supportsParallelFunctionCalling,
            bool? supportsVision,
            bool? supportsWebSearch,
            bool? supportsUrlContext,
            bool? supportsReasoning,
            bool? supportsFunctionCalling,
            global::System.Collections.Generic.IList<string>? supportedOpenaiParams,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::Loud.Technology.LiteLLM.Sdk.ConfigurableClientsideParamsCustomAuthOutput>>? configurableClientsideAuthParams,
            bool? isPublicModelGroup,
            string? healthStatus,
            double? healthResponseTime,
            string? healthCheckedAt)
        {
            this.ModelGroup = modelGroup ?? throw new global::System.ArgumentNullException(nameof(modelGroup));
            this.Providers = providers ?? throw new global::System.ArgumentNullException(nameof(providers));
            this.MaxInputTokens = maxInputTokens;
            this.MaxOutputTokens = maxOutputTokens;
            this.InputCostPerToken = inputCostPerToken;
            this.OutputCostPerToken = outputCostPerToken;
            this.InputCostPerPixel = inputCostPerPixel;
            this.Mode = mode;
            this.Tpm = tpm;
            this.Rpm = rpm;
            this.Itpm = itpm;
            this.Otpm = otpm;
            this.SupportsParallelFunctionCalling = supportsParallelFunctionCalling;
            this.SupportsVision = supportsVision;
            this.SupportsWebSearch = supportsWebSearch;
            this.SupportsUrlContext = supportsUrlContext;
            this.SupportsReasoning = supportsReasoning;
            this.SupportsFunctionCalling = supportsFunctionCalling;
            this.SupportedOpenaiParams = supportedOpenaiParams;
            this.ConfigurableClientsideAuthParams = configurableClientsideAuthParams;
            this.IsPublicModelGroup = isPublicModelGroup;
            this.HealthStatus = healthStatus;
            this.HealthResponseTime = healthResponseTime;
            this.HealthCheckedAt = healthCheckedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelGroupInfoProxy" /> class.
        /// </summary>
        public ModelGroupInfoProxy()
        {
        }

    }
}