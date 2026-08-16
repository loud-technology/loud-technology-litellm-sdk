
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListFineTuningJobsV1FineTuningJobsGetCustomLlmProvider2
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
    public static class ListFineTuningJobsV1FineTuningJobsGetCustomLlmProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFineTuningJobsV1FineTuningJobsGetCustomLlmProvider2 value)
        {
            return value switch
            {
                ListFineTuningJobsV1FineTuningJobsGetCustomLlmProvider2.Azure => "azure",
                ListFineTuningJobsV1FineTuningJobsGetCustomLlmProvider2.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFineTuningJobsV1FineTuningJobsGetCustomLlmProvider2? ToEnum(string value)
        {
            return value switch
            {
                "azure" => ListFineTuningJobsV1FineTuningJobsGetCustomLlmProvider2.Azure,
                "openai" => ListFineTuningJobsV1FineTuningJobsGetCustomLlmProvider2.Openai,
                _ => null,
            };
        }
    }
}