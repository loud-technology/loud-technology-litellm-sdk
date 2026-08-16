
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyHealthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.KeyHealthResponseKeyJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.KeyHealthResponseKey? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logging_callbacks")]
        public global::Loud.Technology.LiteLLM.Sdk.LoggingCallbackStatus? LoggingCallbacks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyHealthResponse" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="loggingCallbacks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyHealthResponse(
            global::Loud.Technology.LiteLLM.Sdk.KeyHealthResponseKey? key,
            global::Loud.Technology.LiteLLM.Sdk.LoggingCallbackStatus? loggingCallbacks)
        {
            this.Key = key;
            this.LoggingCallbacks = loggingCallbacks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyHealthResponse" /> class.
        /// </summary>
        public KeyHealthResponse()
        {
        }

    }
}