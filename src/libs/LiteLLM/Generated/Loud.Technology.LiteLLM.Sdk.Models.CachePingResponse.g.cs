
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CachePingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CacheType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ping_response")]
        public bool? PingResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_cache_response")]
        public string? SetCacheResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_cache_params")]
        public string? LitellmCacheParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("health_check_cache_params")]
        public object? HealthCheckCacheParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CachePingResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="cacheType"></param>
        /// <param name="pingResponse"></param>
        /// <param name="setCacheResponse"></param>
        /// <param name="litellmCacheParams"></param>
        /// <param name="healthCheckCacheParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CachePingResponse(
            string status,
            string cacheType,
            bool? pingResponse,
            string? setCacheResponse,
            string? litellmCacheParams,
            object? healthCheckCacheParams)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CacheType = cacheType ?? throw new global::System.ArgumentNullException(nameof(cacheType));
            this.PingResponse = pingResponse;
            this.SetCacheResponse = setCacheResponse;
            this.LitellmCacheParams = litellmCacheParams;
            this.HealthCheckCacheParams = healthCheckCacheParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CachePingResponse" /> class.
        /// </summary>
        public CachePingResponse()
        {
        }

    }
}