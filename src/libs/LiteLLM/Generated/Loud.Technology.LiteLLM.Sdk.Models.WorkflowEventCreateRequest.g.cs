
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowEventCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEventCreateRequest" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="stepName"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowEventCreateRequest(
            string eventType,
            string stepName,
            object? data)
        {
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.StepName = stepName ?? throw new global::System.ArgumentNullException(nameof(stepName));
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowEventCreateRequest" /> class.
        /// </summary>
        public WorkflowEventCreateRequest()
        {
        }

    }
}