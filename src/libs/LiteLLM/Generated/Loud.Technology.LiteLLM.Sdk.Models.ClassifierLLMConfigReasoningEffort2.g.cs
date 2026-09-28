
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum ClassifierLLMConfigReasoningEffort2
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierLLMConfigReasoningEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierLLMConfigReasoningEffort2 value)
        {
            return value switch
            {
                ClassifierLLMConfigReasoningEffort2.High => "high",
                ClassifierLLMConfigReasoningEffort2.Low => "low",
                ClassifierLLMConfigReasoningEffort2.Max => "max",
                ClassifierLLMConfigReasoningEffort2.Medium => "medium",
                ClassifierLLMConfigReasoningEffort2.Minimal => "minimal",
                ClassifierLLMConfigReasoningEffort2.None => "none",
                ClassifierLLMConfigReasoningEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierLLMConfigReasoningEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ClassifierLLMConfigReasoningEffort2.High,
                "low" => ClassifierLLMConfigReasoningEffort2.Low,
                "max" => ClassifierLLMConfigReasoningEffort2.Max,
                "medium" => ClassifierLLMConfigReasoningEffort2.Medium,
                "minimal" => ClassifierLLMConfigReasoningEffort2.Minimal,
                "none" => ClassifierLLMConfigReasoningEffort2.None,
                "xhigh" => ClassifierLLMConfigReasoningEffort2.Xhigh,
                _ => null,
            };
        }
    }
}