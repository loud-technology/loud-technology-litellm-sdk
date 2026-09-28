
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum TeamMemberBudgetUpdateResultMaxBudgetSource2
    {
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        TeamDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamMemberBudgetUpdateResultMaxBudgetSource2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMemberBudgetUpdateResultMaxBudgetSource2 value)
        {
            return value switch
            {
                TeamMemberBudgetUpdateResultMaxBudgetSource2.Member => "member",
                TeamMemberBudgetUpdateResultMaxBudgetSource2.TeamDefault => "team_default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMemberBudgetUpdateResultMaxBudgetSource2? ToEnum(string value)
        {
            return value switch
            {
                "member" => TeamMemberBudgetUpdateResultMaxBudgetSource2.Member,
                "team_default" => TeamMemberBudgetUpdateResultMaxBudgetSource2.TeamDefault,
                _ => null,
            };
        }
    }
}