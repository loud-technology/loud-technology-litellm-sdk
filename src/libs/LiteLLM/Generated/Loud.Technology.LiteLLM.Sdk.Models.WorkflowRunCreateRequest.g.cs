
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRunCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowRunCreateRequest" /> class.
        /// </summary>
        /// <param name="workflowType"></param>
        /// <param name="input"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRunCreateRequest(
            string workflowType,
            object? input,
            object? metadata)
        {
            this.WorkflowType = workflowType ?? throw new global::System.ArgumentNullException(nameof(workflowType));
            this.Input = input;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunCreateRequest" /> class.
        /// </summary>
        public WorkflowRunCreateRequest()
        {
        }

    }
}