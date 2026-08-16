
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoggingCallbackStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbacks")]
        public global::System.Collections.Generic.IList<string>? Callbacks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.LoggingCallbackStatusStatusJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.LoggingCallbackStatusStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingCallbackStatus" /> class.
        /// </summary>
        /// <param name="callbacks"></param>
        /// <param name="status"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoggingCallbackStatus(
            global::System.Collections.Generic.IList<string>? callbacks,
            global::Loud.Technology.LiteLLM.Sdk.LoggingCallbackStatusStatus? status,
            string? details)
        {
            this.Callbacks = callbacks;
            this.Status = status;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingCallbackStatus" /> class.
        /// </summary>
        public LoggingCallbackStatus()
        {
        }

    }
}