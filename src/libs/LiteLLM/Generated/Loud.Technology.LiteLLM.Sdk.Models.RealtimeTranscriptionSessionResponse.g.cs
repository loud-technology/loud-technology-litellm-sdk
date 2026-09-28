
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response from POST /v1/realtime/transcription_sessions.<br/>
    /// `client_secret.value` contains the encrypted token instead of the raw<br/>
    /// ephemeral key. Unknown fields pass through unchanged.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public object? ClientSecret { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionResponse" /> class.
        /// </summary>
        /// <param name="clientSecret"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionResponse(
            object? clientSecret)
        {
            this.ClientSecret = clientSecret;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionResponse" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionResponse()
        {
        }

    }
}