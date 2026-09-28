
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 'binary' scores 1 when any matcher hits. 'match_count' scores 0.5 when one distinct matcher hits and 1 when two or more do; repeated occurrences of one matcher never raise it. Keywords are distinct case-insensitively, patterns by source, and a keyword and a pattern are always distinct from each other.<br/>
    /// Default Value: binary
    /// </summary>
    public enum CustomDimensionScoringMode
    {
        /// <summary>
        ///
        /// </summary>
        Binary,
        /// <summary>
        ///
        /// </summary>
        MatchCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomDimensionScoringModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomDimensionScoringMode value)
        {
            return value switch
            {
                CustomDimensionScoringMode.Binary => "binary",
                CustomDimensionScoringMode.MatchCount => "match_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomDimensionScoringMode? ToEnum(string value)
        {
            return value switch
            {
                "binary" => CustomDimensionScoringMode.Binary,
                "match_count" => CustomDimensionScoringMode.MatchCount,
                _ => null,
            };
        }
    }
}