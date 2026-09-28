
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for viewing CloudZero settings with masked API key
    /// </summary>
    public sealed partial class CloudZeroSettingsView
    {
        /// <summary>
        /// Masked API key showing only first 4 and last 4 characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_masked")]
        public string? ApiKeyMasked { get; set; }

        /// <summary>
        /// CloudZero connection ID for data submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// Configuration status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Timezone for date handling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroSettingsView" /> class.
        /// </summary>
        /// <param name="apiKeyMasked">
        /// Masked API key showing only first 4 and last 4 characters
        /// </param>
        /// <param name="connectionId">
        /// CloudZero connection ID for data submission
        /// </param>
        /// <param name="status">
        /// Configuration status
        /// </param>
        /// <param name="timezone">
        /// Timezone for date handling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudZeroSettingsView(
            string? apiKeyMasked,
            string? connectionId,
            string? status,
            string? timezone)
        {
            this.ApiKeyMasked = apiKeyMasked;
            this.ConnectionId = connectionId;
            this.Status = status;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroSettingsView" /> class.
        /// </summary>
        public CloudZeroSettingsView()
        {
        }

    }
}