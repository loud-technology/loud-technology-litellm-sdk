
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamMemberResetBudgetResponseBudgetSource
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        TeamDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamMemberResetBudgetResponseBudgetSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMemberResetBudgetResponseBudgetSource value)
        {
            return value switch
            {
                TeamMemberResetBudgetResponseBudgetSource.Custom => "custom",
                TeamMemberResetBudgetResponseBudgetSource.None => "none",
                TeamMemberResetBudgetResponseBudgetSource.TeamDefault => "team_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMemberResetBudgetResponseBudgetSource? ToEnum(string value)
        {
            return value switch
            {
                "custom" => TeamMemberResetBudgetResponseBudgetSource.Custom,
                "none" => TeamMemberResetBudgetResponseBudgetSource.None,
                "team_default" => TeamMemberResetBudgetResponseBudgetSource.TeamDefault,
                _ => null,
            };
        }
    }
}