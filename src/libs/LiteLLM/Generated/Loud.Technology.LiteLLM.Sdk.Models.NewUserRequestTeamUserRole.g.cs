
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: user
    /// </summary>
    public enum NewUserRequestTeamUserRole
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
    public static class NewUserRequestTeamUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewUserRequestTeamUserRole value)
        {
            return value switch
            {
                NewUserRequestTeamUserRole.Admin => "admin",
                NewUserRequestTeamUserRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewUserRequestTeamUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => NewUserRequestTeamUserRole.Admin,
                "user" => NewUserRequestTeamUserRole.User,
                _ => null,
            };
        }
    }
}