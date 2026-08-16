
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRunUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Loud.Technology.LiteLLM.Sdk.WorkflowRunUpdateRequestStatus2? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUpdateRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="output"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRunUpdateRequest(
            global::Loud.Technology.LiteLLM.Sdk.WorkflowRunUpdateRequestStatus2? status,
            object? output,
            object? metadata)
        {
            this.Status = status;
            this.Output = output;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunUpdateRequest" /> class.
        /// </summary>
        public WorkflowRunUpdateRequest()
        {
        }

    }
}