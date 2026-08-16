
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A single finished logging event to replay through the callbacks.
    /// </summary>
    public sealed partial class CallbackLogRecord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.CallbackLogRecordStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.CallbackLogRecordStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("standard_logging_payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object StandardLoggingPayload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLogRecord" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="standardLoggingPayload"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbackLogRecord(
            global::Loud.Technology.LiteLLM.Sdk.CallbackLogRecordStatus status,
            object standardLoggingPayload,
            string? error)
        {
            this.Status = status;
            this.StandardLoggingPayload = standardLoggingPayload ?? throw new global::System.ArgumentNullException(nameof(standardLoggingPayload));
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLogRecord" /> class.
        /// </summary>
        public CallbackLogRecord()
        {
        }

    }
}