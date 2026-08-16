
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewUserResponseUserRole2
    {
        /// <summary>
        /// 
        /// </summary>
        InternalUser,
        /// <summary>
        /// 
        /// </summary>
        InternalUserViewer,
        /// <summary>
        /// 
        /// </summary>
        ProxyAdmin,
        /// <summary>
        /// 
        /// </summary>
        ProxyAdminViewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewUserResponseUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewUserResponseUserRole2 value)
        {
            return value switch
            {
                NewUserResponseUserRole2.InternalUser => "internal_user",
                NewUserResponseUserRole2.InternalUserViewer => "internal_user_viewer",
                NewUserResponseUserRole2.ProxyAdmin => "proxy_admin",
                NewUserResponseUserRole2.ProxyAdminViewer => "proxy_admin_viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewUserResponseUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "internal_user" => NewUserResponseUserRole2.InternalUser,
                "internal_user_viewer" => NewUserResponseUserRole2.InternalUserViewer,
                "proxy_admin" => NewUserResponseUserRole2.ProxyAdmin,
                "proxy_admin_viewer" => NewUserResponseUserRole2.ProxyAdminViewer,
                _ => null,
            };
        }
    }
}