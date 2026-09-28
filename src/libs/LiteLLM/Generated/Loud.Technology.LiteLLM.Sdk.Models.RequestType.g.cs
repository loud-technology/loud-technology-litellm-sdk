
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Fixed v0 taxonomy. User-extensible types come in v1.
    /// </summary>
    public enum RequestType
    {
        /// <summary>
        ///
        /// </summary>
        AnalyticalReasoning,
        /// <summary>
        ///
        /// </summary>
        CodeGeneration,
        /// <summary>
        ///
        /// </summary>
        CodeUnderstanding,
        /// <summary>
        ///
        /// </summary>
        FactualLookup,
        /// <summary>
        ///
        /// </summary>
        General,
        /// <summary>
        ///
        /// </summary>
        TechnicalDesign,
        /// <summary>
        ///
        /// </summary>
        Writing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestType value)
        {
            return value switch
            {
                RequestType.AnalyticalReasoning => "analytical_reasoning",
                RequestType.CodeGeneration => "code_generation",
                RequestType.CodeUnderstanding => "code_understanding",
                RequestType.FactualLookup => "factual_lookup",
                RequestType.General => "general",
                RequestType.TechnicalDesign => "technical_design",
                RequestType.Writing => "writing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestType? ToEnum(string value)
        {
            return value switch
            {
                "analytical_reasoning" => RequestType.AnalyticalReasoning,
                "code_generation" => RequestType.CodeGeneration,
                "code_understanding" => RequestType.CodeUnderstanding,
                "factual_lookup" => RequestType.FactualLookup,
                "general" => RequestType.General,
                "technical_design" => RequestType.TechnicalDesign,
                "writing" => RequestType.Writing,
                _ => null,
            };
        }
    }
}