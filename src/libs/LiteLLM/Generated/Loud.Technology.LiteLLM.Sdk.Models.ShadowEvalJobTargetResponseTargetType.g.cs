
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// What kind of entity this entry scopes
    /// </summary>
    public enum ShadowEvalJobTargetResponseTargetType
    {
        /// <summary>
        ///
        /// </summary>
        Key,
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShadowEvalJobTargetResponseTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShadowEvalJobTargetResponseTargetType value)
        {
            return value switch
            {
                ShadowEvalJobTargetResponseTargetType.Key => "key",
                ShadowEvalJobTargetResponseTargetType.Team => "team",
                ShadowEvalJobTargetResponseTargetType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShadowEvalJobTargetResponseTargetType? ToEnum(string value)
        {
            return value switch
            {
                "key" => ShadowEvalJobTargetResponseTargetType.Key,
                "team" => ShadowEvalJobTargetResponseTargetType.Team,
                "user" => ShadowEvalJobTargetResponseTargetType.User,
                _ => null,
            };
        }
    }
}