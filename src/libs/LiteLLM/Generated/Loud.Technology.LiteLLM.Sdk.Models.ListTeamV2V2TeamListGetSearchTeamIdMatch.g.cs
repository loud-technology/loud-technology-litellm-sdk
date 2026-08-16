
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// How 'search' matches 'team_id': 'exact' (default) or 'prefix' for a case-sensitive prefix match.<br/>
    /// Default Value: exact
    /// </summary>
    public enum ListTeamV2V2TeamListGetSearchTeamIdMatch
    {
        /// <summary>
        /// 'exact' (default) or 'prefix' for a case-sensitive prefix match.
        /// </summary>
        Exact,
        /// <summary>
        /// 'exact' (default) or 'prefix' for a case-sensitive prefix match.
        /// </summary>
        Prefix,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListTeamV2V2TeamListGetSearchTeamIdMatchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListTeamV2V2TeamListGetSearchTeamIdMatch value)
        {
            return value switch
            {
                ListTeamV2V2TeamListGetSearchTeamIdMatch.Exact => "exact",
                ListTeamV2V2TeamListGetSearchTeamIdMatch.Prefix => "prefix",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListTeamV2V2TeamListGetSearchTeamIdMatch? ToEnum(string value)
        {
            return value switch
            {
                "exact" => ListTeamV2V2TeamListGetSearchTeamIdMatch.Exact,
                "prefix" => ListTeamV2V2TeamListGetSearchTeamIdMatch.Prefix,
                _ => null,
            };
        }
    }
}