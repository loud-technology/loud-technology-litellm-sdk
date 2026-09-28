
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2
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
    public static class ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2 value)
        {
            return value switch
            {
                ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2.Key => "key",
                ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2.Team => "team",
                ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2? ToEnum(string value)
        {
            return value switch
            {
                "key" => ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2.Key,
                "team" => ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2.Team,
                "user" => ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2.User,
                _ => null,
            };
        }
    }
}