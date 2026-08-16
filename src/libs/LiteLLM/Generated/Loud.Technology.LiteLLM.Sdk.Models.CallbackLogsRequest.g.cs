
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A batch of logging events posted by an external producer.
    /// </summary>
    public sealed partial class CallbackLogsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("records")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CallbackLogRecord> Records { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLogsRequest" /> class.
        /// </summary>
        /// <param name="records"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbackLogsRequest(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CallbackLogRecord> records)
        {
            this.Records = records ?? throw new global::System.ArgumentNullException(nameof(records));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLogsRequest" /> class.
        /// </summary>
        public CallbackLogsRequest()
        {
        }

    }
}