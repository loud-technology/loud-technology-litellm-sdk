
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Set of params that you can modify via `router.update_settings()`.
    /// </summary>
    public sealed partial class UpdateRouterConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_strategy_args")]
        public object? RoutingStrategyArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_strategy")]
        public string? RoutingStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("routing_groups")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.RoutingGroup>? RoutingGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_policy")]
        public global::Loud.Technology.LiteLLM.Sdk.RetryPolicy? RetryPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_group_retry_policy")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.RetryPolicy>? ModelGroupRetryPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_group_affinity_config")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? ModelGroupAffinityConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_fails")]
        public int? AllowedFails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cooldown_time")]
        public double? CooldownTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_retries")]
        public int? NumRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_after")]
        public double? RetryAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbacks")]
        public global::System.Collections.Generic.IList<object>? Fallbacks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window_fallbacks")]
        public global::System.Collections.Generic.IList<object>? ContextWindowFallbacks { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_group_alias")]
        public object? ModelGroupAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_tag_filtering")]
        public bool? EnableTagFiltering { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouterConfig" /> class.
        /// </summary>
        /// <param name="routingStrategyArgs"></param>
        /// <param name="routingStrategy"></param>
        /// <param name="routingGroups"></param>
        /// <param name="retryPolicy"></param>
        /// <param name="modelGroupRetryPolicy"></param>
        /// <param name="modelGroupAffinityConfig"></param>
        /// <param name="allowedFails"></param>
        /// <param name="cooldownTime"></param>
        /// <param name="numRetries"></param>
        /// <param name="timeout"></param>
        /// <param name="maxRetries"></param>
        /// <param name="retryAfter"></param>
        /// <param name="fallbacks"></param>
        /// <param name="contextWindowFallbacks"></param>
        /// <param name="modelGroupAlias">
        /// Default Value: {}
        /// </param>
        /// <param name="enableTagFiltering"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouterConfig(
            object? routingStrategyArgs,
            string? routingStrategy,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.RoutingGroup>? routingGroups,
            global::Loud.Technology.LiteLLM.Sdk.RetryPolicy? retryPolicy,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.RetryPolicy>? modelGroupRetryPolicy,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? modelGroupAffinityConfig,
            int? allowedFails,
            double? cooldownTime,
            int? numRetries,
            double? timeout,
            int? maxRetries,
            double? retryAfter,
            global::System.Collections.Generic.IList<object>? fallbacks,
            global::System.Collections.Generic.IList<object>? contextWindowFallbacks,
            object? modelGroupAlias,
            bool? enableTagFiltering)
        {
            this.RoutingStrategyArgs = routingStrategyArgs;
            this.RoutingStrategy = routingStrategy;
            this.RoutingGroups = routingGroups;
            this.RetryPolicy = retryPolicy;
            this.ModelGroupRetryPolicy = modelGroupRetryPolicy;
            this.ModelGroupAffinityConfig = modelGroupAffinityConfig;
            this.AllowedFails = allowedFails;
            this.CooldownTime = cooldownTime;
            this.NumRetries = numRetries;
            this.Timeout = timeout;
            this.MaxRetries = maxRetries;
            this.RetryAfter = retryAfter;
            this.Fallbacks = fallbacks;
            this.ContextWindowFallbacks = contextWindowFallbacks;
            this.ModelGroupAlias = modelGroupAlias;
            this.EnableTagFiltering = enableTagFiltering;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouterConfig" /> class.
        /// </summary>
        public UpdateRouterConfig()
        {
        }

    }
}