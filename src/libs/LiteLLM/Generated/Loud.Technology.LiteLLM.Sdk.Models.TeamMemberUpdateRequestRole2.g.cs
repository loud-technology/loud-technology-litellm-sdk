
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum TeamMemberUpdateRequestRole2
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamMemberUpdateRequestRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamMemberUpdateRequestRole2 value)
        {
            return value switch
            {
                TeamMemberUpdateRequestRole2.Admin => "admin",
                TeamMemberUpdateRequestRole2.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamMemberUpdateRequestRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => TeamMemberUpdateRequestRole2.Admin,
                "user" => TeamMemberUpdateRequestRole2.User,
                _ => null,
            };
        }
    }
}