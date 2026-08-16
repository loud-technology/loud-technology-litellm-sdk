
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Per-batch result: counts plus per-record failure detail so the caller can<br/>
    /// distinguish a transient callback error from a structurally bad payload.
    /// </summary>
    public sealed partial class CallbackLogsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Processed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failures")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CallbackLogFailure>? Failures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLogsResponse" /> class.
        /// </summary>
        /// <param name="processed"></param>
        /// <param name="failed"></param>
        /// <param name="failures"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallbackLogsResponse(
            int processed,
            int failed,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.CallbackLogFailure>? failures)
        {
            this.Processed = processed;
            this.Failed = failed;
            this.Failures = failures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackLogsResponse" /> class.
        /// </summary>
        public CallbackLogsResponse()
        {
        }

    }
}