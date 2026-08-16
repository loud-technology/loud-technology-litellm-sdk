
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2
    {
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2 value)
        {
            return value switch
            {
                ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2.Azure => "azure",
                ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2? ToEnum(string value)
        {
            return value switch
            {
                "azure" => ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2.Azure,
                "openai" => ListFineTuningJobsFineTuningJobsGetCustomLlmProvider2.Openai,
                _ => null,
            };
        }
    }
}