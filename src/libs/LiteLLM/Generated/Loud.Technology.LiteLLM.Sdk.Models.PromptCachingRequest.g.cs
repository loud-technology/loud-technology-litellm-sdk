
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptCachingRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gateway_injected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool GatewayInjected { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheReadTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheCreationTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Spend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_savings")]
        public double? NetSavings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingRequest" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="startTime"></param>
        /// <param name="model"></param>
        /// <param name="gatewayInjected"></param>
        /// <param name="cacheReadTokens"></param>
        /// <param name="cacheCreationTokens"></param>
        /// <param name="spend"></param>
        /// <param name="netSavings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCachingRequest(
            string requestId,
            global::System.DateTime startTime,
            string model,
            bool gatewayInjected,
            int cacheReadTokens,
            int cacheCreationTokens,
            double spend,
            double? netSavings)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.StartTime = startTime;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.GatewayInjected = gatewayInjected;
            this.CacheReadTokens = cacheReadTokens;
            this.CacheCreationTokens = cacheCreationTokens;
            this.Spend = spend;
            this.NetSavings = netSavings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingRequest" /> class.
        /// </summary>
        public PromptCachingRequest()
        {
        }

    }
}