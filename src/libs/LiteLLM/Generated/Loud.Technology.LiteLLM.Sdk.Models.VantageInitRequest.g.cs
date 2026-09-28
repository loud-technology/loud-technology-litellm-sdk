
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for initializing Vantage settings
    /// </summary>
    public sealed partial class VantageInitRequest
    {
        /// <summary>
        /// Vantage API key for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Vantage API base URL (default: https://api.vantage.sh)<br/>
        /// Default Value: https://api.vantage.sh
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Vantage integration token for the cost-import endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageInitRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Vantage API key for authentication
        /// </param>
        /// <param name="integrationToken">
        /// Vantage integration token for the cost-import endpoint
        /// </param>
        /// <param name="baseUrl">
        /// Vantage API base URL (default: https://api.vantage.sh)<br/>
        /// Default Value: https://api.vantage.sh
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VantageInitRequest(
            string apiKey,
            string integrationToken,
            string? baseUrl)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.BaseUrl = baseUrl;
            this.IntegrationToken = integrationToken ?? throw new global::System.ArgumentNullException(nameof(integrationToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageInitRequest" /> class.
        /// </summary>
        public VantageInitRequest()
        {
        }

    }
}