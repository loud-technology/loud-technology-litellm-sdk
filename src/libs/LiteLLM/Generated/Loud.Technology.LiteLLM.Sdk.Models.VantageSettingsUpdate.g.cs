
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for updating Vantage settings
    /// </summary>
    public sealed partial class VantageSettingsUpdate
    {
        /// <summary>
        /// New Vantage API key for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// New Vantage API base URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// New Vantage integration token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_token")]
        public string? IntegrationToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageSettingsUpdate" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// New Vantage API key for authentication
        /// </param>
        /// <param name="baseUrl">
        /// New Vantage API base URL
        /// </param>
        /// <param name="integrationToken">
        /// New Vantage integration token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VantageSettingsUpdate(
            string? apiKey,
            string? baseUrl,
            string? integrationToken)
        {
            this.ApiKey = apiKey;
            this.BaseUrl = baseUrl;
            this.IntegrationToken = integrationToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageSettingsUpdate" /> class.
        /// </summary>
        public VantageSettingsUpdate()
        {
        }

    }
}