
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2
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
    public static class RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2 value)
        {
            return value switch
            {
                RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2.Azure => "azure",
                RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2? ToEnum(string value)
        {
            return value switch
            {
                "azure" => RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2.Azure,
                "openai" => RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2.Openai,
                _ => null,
            };
        }
    }
}