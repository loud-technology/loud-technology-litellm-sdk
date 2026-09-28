
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JevClassifierConfig
    {
        /// <summary>
        /// Default Value: jev-latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// TypeSafe API key, falling back to TYPESAFE_API_KEY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// TypeSafe API base, falling back to TYPESAFE_API_BASE and then https://api.typesafe.ai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_base")]
        public string? ApiBase { get; set; }

        /// <summary>
        /// Default Value: 3000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// Replaces the built-in Jev question instructions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("circuit_breaker_enabled")]
        public bool? CircuitBreakerEnabled { get; set; }

        /// <summary>
        /// Default Value: 30F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("circuit_breaker_cooldown_seconds")]
        public double? CircuitBreakerCooldownSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JevClassifierConfig" /> class.
        /// </summary>
        /// <param name="model">
        /// Default Value: jev-latest
        /// </param>
        /// <param name="apiKey">
        /// TypeSafe API key, falling back to TYPESAFE_API_KEY
        /// </param>
        /// <param name="apiBase">
        /// TypeSafe API base, falling back to TYPESAFE_API_BASE and then https://api.typesafe.ai
        /// </param>
        /// <param name="timeoutMs">
        /// Default Value: 3000
        /// </param>
        /// <param name="instructions">
        /// Replaces the built-in Jev question instructions
        /// </param>
        /// <param name="circuitBreakerEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="circuitBreakerCooldownSeconds">
        /// Default Value: 30F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JevClassifierConfig(
            string? model,
            string? apiKey,
            string? apiBase,
            int? timeoutMs,
            string? instructions,
            bool? circuitBreakerEnabled,
            double? circuitBreakerCooldownSeconds)
        {
            this.Model = model;
            this.ApiKey = apiKey;
            this.ApiBase = apiBase;
            this.TimeoutMs = timeoutMs;
            this.Instructions = instructions;
            this.CircuitBreakerEnabled = circuitBreakerEnabled;
            this.CircuitBreakerCooldownSeconds = circuitBreakerCooldownSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JevClassifierConfig" /> class.
        /// </summary>
        public JevClassifierConfig()
        {
        }

    }
}