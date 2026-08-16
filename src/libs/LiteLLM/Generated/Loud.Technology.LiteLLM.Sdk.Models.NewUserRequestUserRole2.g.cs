
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewUserRequestUserRole2
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
    public static class NewUserRequestUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewUserRequestUserRole2 value)
        {
            return value switch
            {
                NewUserRequestUserRole2.InternalUser => "internal_user",
                NewUserRequestUserRole2.InternalUserViewer => "internal_user_viewer",
                NewUserRequestUserRole2.ProxyAdmin => "proxy_admin",
                NewUserRequestUserRole2.ProxyAdminViewer => "proxy_admin_viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewUserRequestUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "internal_user" => NewUserRequestUserRole2.InternalUser,
                "internal_user_viewer" => NewUserRequestUserRole2.InternalUserViewer,
                "proxy_admin" => NewUserRequestUserRole2.ProxyAdmin,
                "proxy_admin_viewer" => NewUserRequestUserRole2.ProxyAdminViewer,
                _ => null,
            };
        }
    }
}