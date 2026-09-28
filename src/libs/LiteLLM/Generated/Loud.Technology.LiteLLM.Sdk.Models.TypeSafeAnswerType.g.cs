
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Kind of the question that produced this answer.
    /// </summary>
    public enum TypeSafeAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Choice,
        /// <summary>
        ///
        /// </summary>
        Noul,
        /// <summary>
        ///
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypeSafeAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeSafeAnswerType value)
        {
            return value switch
            {
                TypeSafeAnswerType.Choice => "choice",
                TypeSafeAnswerType.Noul => "noul",
                TypeSafeAnswerType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeSafeAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => TypeSafeAnswerType.Choice,
                "noul" => TypeSafeAnswerType.Noul,
                "score" => TypeSafeAnswerType.Score,
                _ => null,
            };
        }
    }
}