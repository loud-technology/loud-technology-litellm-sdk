
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for initializing CloudZero settings
    /// </summary>
    public sealed partial class CloudZeroInitRequest
    {
        /// <summary>
        /// CloudZero API key for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// CloudZero connection ID for data submission
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionId { get; set; }

        /// <summary>
        /// Timezone for date handling (default: UTC)<br/>
        /// Default Value: UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroInitRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// CloudZero API key for authentication
        /// </param>
        /// <param name="connectionId">
        /// CloudZero connection ID for data submission
        /// </param>
        /// <param name="timezone">
        /// Timezone for date handling (default: UTC)<br/>
        /// Default Value: UTC
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudZeroInitRequest(
            string apiKey,
            string connectionId,
            string? timezone)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.ConnectionId = connectionId ?? throw new global::System.ArgumentNullException(nameof(connectionId));
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudZeroInitRequest" /> class.
        /// </summary>
        public CloudZeroInitRequest()
        {
        }

    }
}