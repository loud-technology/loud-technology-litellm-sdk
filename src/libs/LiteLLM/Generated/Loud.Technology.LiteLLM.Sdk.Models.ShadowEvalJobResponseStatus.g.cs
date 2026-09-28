
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Three recorded facts, no history-guessing: a stop is stopped_by (the migration<br/>
    /// backfills it for every job that displayed stopped when the column arrived, so the<br/>
    /// pre-column population is closed), completion is the window passing or every target<br/>
    /// spending its budget, and anything else is running. The all-targets-stamped fallback<br/>
    /// covers only stops written by pre-column pods during a rolling deploy.<br/>
    /// Included only in responses
    /// </summary>
    public enum ShadowEvalJobResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        /// a stop is stopped_by (the migration
        /// </summary>
        Stopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShadowEvalJobResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShadowEvalJobResponseStatus value)
        {
            return value switch
            {
                ShadowEvalJobResponseStatus.Completed => "completed",
                ShadowEvalJobResponseStatus.Running => "running",
                ShadowEvalJobResponseStatus.Stopped => "stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShadowEvalJobResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ShadowEvalJobResponseStatus.Completed,
                "running" => ShadowEvalJobResponseStatus.Running,
                "stopped" => ShadowEvalJobResponseStatus.Stopped,
                _ => null,
            };
        }
    }
}