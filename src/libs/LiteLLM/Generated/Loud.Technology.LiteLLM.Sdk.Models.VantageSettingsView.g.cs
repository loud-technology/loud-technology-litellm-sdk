
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for viewing Vantage settings with masked API key
    /// </summary>
    public sealed partial class VantageSettingsView
    {
        /// <summary>
        /// Masked API key showing only first 4 and last 4 characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_masked")]
        public string? ApiKeyMasked { get; set; }

        /// <summary>
        /// Vantage API base URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Masked integration token showing only first 4 and last 4 characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_token_masked")]
        public string? IntegrationTokenMasked { get; set; }

        /// <summary>
        /// Configuration status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageSettingsView" /> class.
        /// </summary>
        /// <param name="apiKeyMasked">
        /// Masked API key showing only first 4 and last 4 characters
        /// </param>
        /// <param name="baseUrl">
        /// Vantage API base URL
        /// </param>
        /// <param name="integrationTokenMasked">
        /// Masked integration token showing only first 4 and last 4 characters
        /// </param>
        /// <param name="status">
        /// Configuration status
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VantageSettingsView(
            string? apiKeyMasked,
            string? baseUrl,
            string? integrationTokenMasked,
            string? status)
        {
            this.ApiKeyMasked = apiKeyMasked;
            this.BaseUrl = baseUrl;
            this.IntegrationTokenMasked = integrationTokenMasked;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageSettingsView" /> class.
        /// </summary>
        public VantageSettingsView()
        {
        }

    }
}