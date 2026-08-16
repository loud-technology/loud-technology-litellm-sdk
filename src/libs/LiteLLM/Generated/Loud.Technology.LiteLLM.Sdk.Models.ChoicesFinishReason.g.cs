
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChoicesFinishReason
    {
        /// <summary>
        /// 
        /// </summary>
        ContentFilter,
        /// <summary>
        /// 
        /// </summary>
        Eos,
        /// <summary>
        /// 
        /// </summary>
        FinishReasonUnspecified,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        GuardrailIntervened,
        /// <summary>
        /// 
        /// </summary>
        Length,
        /// <summary>
        /// 
        /// </summary>
        MalformedFunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        ToolCalls,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChoicesFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChoicesFinishReason value)
        {
            return value switch
            {
                ChoicesFinishReason.ContentFilter => "content_filter",
                ChoicesFinishReason.Eos => "eos",
                ChoicesFinishReason.FinishReasonUnspecified => "finish_reason_unspecified",
                ChoicesFinishReason.FunctionCall => "function_call",
                ChoicesFinishReason.GuardrailIntervened => "guardrail_intervened",
                ChoicesFinishReason.Length => "length",
                ChoicesFinishReason.MalformedFunctionCall => "malformed_function_call",
                ChoicesFinishReason.Stop => "stop",
                ChoicesFinishReason.ToolCalls => "tool_calls",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChoicesFinishReason? ToEnum(string value)
        {
            return value switch
            {
                "content_filter" => ChoicesFinishReason.ContentFilter,
                "eos" => ChoicesFinishReason.Eos,
                "finish_reason_unspecified" => ChoicesFinishReason.FinishReasonUnspecified,
                "function_call" => ChoicesFinishReason.FunctionCall,
                "guardrail_intervened" => ChoicesFinishReason.GuardrailIntervened,
                "length" => ChoicesFinishReason.Length,
                "malformed_function_call" => ChoicesFinishReason.MalformedFunctionCall,
                "stop" => ChoicesFinishReason.Stop,
                "tool_calls" => ChoicesFinishReason.ToolCalls,
                _ => null,
            };
        }
    }
}