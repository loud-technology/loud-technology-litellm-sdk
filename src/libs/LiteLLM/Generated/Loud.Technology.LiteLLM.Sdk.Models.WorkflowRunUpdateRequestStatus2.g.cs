
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowRunUpdateRequestStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowRunUpdateRequestStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowRunUpdateRequestStatus2 value)
        {
            return value switch
            {
                WorkflowRunUpdateRequestStatus2.Completed => "completed",
                WorkflowRunUpdateRequestStatus2.Failed => "failed",
                WorkflowRunUpdateRequestStatus2.Paused => "paused",
                WorkflowRunUpdateRequestStatus2.Pending => "pending",
                WorkflowRunUpdateRequestStatus2.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowRunUpdateRequestStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WorkflowRunUpdateRequestStatus2.Completed,
                "failed" => WorkflowRunUpdateRequestStatus2.Failed,
                "paused" => WorkflowRunUpdateRequestStatus2.Paused,
                "pending" => WorkflowRunUpdateRequestStatus2.Pending,
                "running" => WorkflowRunUpdateRequestStatus2.Running,
                _ => null,
            };
        }
    }
}