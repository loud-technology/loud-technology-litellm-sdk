
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for updating CloudZero settings
    /// </summary>
    public sealed partial class CloudZeroSettingsUpdate
    {
        /// <summary>
        /// New CloudZero API key for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// New CloudZero connection ID for data submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        public string? ConnectionId { get; set; }

        /// <summary>
        /// New timezone for date handling
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroSettingsUpdate" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// New CloudZero API key for authentication
        /// </param>
        /// <param name="connectionId">
        /// New CloudZero connection ID for data submission
        /// </param>
        /// <param name="timezone">
        /// New timezone for date handling
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudZeroSettingsUpdate(
            string? apiKey,
            string? connectionId,
            string? timezone)
        {
            this.ApiKey = apiKey;
            this.ConnectionId = connectionId;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroSettingsUpdate" /> class.
        /// </summary>
        public CloudZeroSettingsUpdate()
        {
        }

    }
}