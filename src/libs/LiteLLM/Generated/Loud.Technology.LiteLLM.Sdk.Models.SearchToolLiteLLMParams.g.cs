
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// LiteLLM params for search tools configuration.
    /// </summary>
    public sealed partial class SearchToolLiteLLMParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_base")]
        public string? ApiBase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SearchProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchToolLiteLLMParams" /> class.
        /// </summary>
        /// <param name="searchProvider"></param>
        /// <param name="apiBase"></param>
        /// <param name="apiKey"></param>
        /// <param name="maxRetries"></param>
        /// <param name="timeout"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchToolLiteLLMParams(
            string searchProvider,
            string? apiBase,
            string? apiKey,
            int? maxRetries,
            double? timeout)
        {
            this.ApiBase = apiBase;
            this.ApiKey = apiKey;
            this.MaxRetries = maxRetries;
            this.SearchProvider = searchProvider ?? throw new global::System.ArgumentNullException(nameof(searchProvider));
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchToolLiteLLMParams" /> class.
        /// </summary>
        public SearchToolLiteLLMParams()
        {
        }

    }
}