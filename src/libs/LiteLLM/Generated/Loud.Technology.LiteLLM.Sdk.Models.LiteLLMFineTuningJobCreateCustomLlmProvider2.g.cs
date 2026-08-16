
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum LiteLLMFineTuningJobCreateCustomLlmProvider2
    {
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        VertexAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiteLLMFineTuningJobCreateCustomLlmProvider2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteLLMFineTuningJobCreateCustomLlmProvider2 value)
        {
            return value switch
            {
                LiteLLMFineTuningJobCreateCustomLlmProvider2.Azure => "azure",
                LiteLLMFineTuningJobCreateCustomLlmProvider2.Openai => "openai",
                LiteLLMFineTuningJobCreateCustomLlmProvider2.VertexAi => "vertex_ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteLLMFineTuningJobCreateCustomLlmProvider2? ToEnum(string value)
        {
            return value switch
            {
                "azure" => LiteLLMFineTuningJobCreateCustomLlmProvider2.Azure,
                "openai" => LiteLLMFineTuningJobCreateCustomLlmProvider2.Openai,
                "vertex_ai" => LiteLLMFineTuningJobCreateCustomLlmProvider2.VertexAi,
                _ => null,
            };
        }
    }
}