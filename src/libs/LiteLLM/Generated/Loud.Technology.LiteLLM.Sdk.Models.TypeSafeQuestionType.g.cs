
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Question kind: `choice`, `score`, or `noul` (yes/no).
    /// </summary>
    public enum TypeSafeQuestionType
    {
        /// <summary>
        /// `choice`, `score`, or `noul` (yes/no).
        /// </summary>
        Choice,
        /// <summary>
        /// `choice`, `score`, or `noul` (yes/no).
        /// </summary>
        Noul,
        /// <summary>
        /// `choice`, `score`, or `noul` (yes/no).
        /// </summary>
        Score,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TypeSafeQuestionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeSafeQuestionType value)
        {
            return value switch
            {
                TypeSafeQuestionType.Choice => "choice",
                TypeSafeQuestionType.Noul => "noul",
                TypeSafeQuestionType.Score => "score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeSafeQuestionType? ToEnum(string value)
        {
            return value switch
            {
                "choice" => TypeSafeQuestionType.Choice,
                "noul" => TypeSafeQuestionType.Noul,
                "score" => TypeSafeQuestionType.Score,
                _ => null,
            };
        }
    }
}