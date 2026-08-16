
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The role of the user within the team. 'admin' users can manage team settings and members, 'user' is a regular team member
    /// </summary>
    public enum MemberRole
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
    public static class MemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemberRole value)
        {
            return value switch
            {
                MemberRole.Admin => "admin",
                MemberRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemberRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => MemberRole.Admin,
                "user" => MemberRole.User,
                _ => null,
            };
        }
    }
}