
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateUserRequestUserRole2
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
    public static class UpdateUserRequestUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateUserRequestUserRole2 value)
        {
            return value switch
            {
                UpdateUserRequestUserRole2.InternalUser => "internal_user",
                UpdateUserRequestUserRole2.InternalUserViewer => "internal_user_viewer",
                UpdateUserRequestUserRole2.ProxyAdmin => "proxy_admin",
                UpdateUserRequestUserRole2.ProxyAdminViewer => "proxy_admin_viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateUserRequestUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "internal_user" => UpdateUserRequestUserRole2.InternalUser,
                "internal_user_viewer" => UpdateUserRequestUserRole2.InternalUserViewer,
                "proxy_admin" => UpdateUserRequestUserRole2.ProxyAdmin,
                "proxy_admin_viewer" => UpdateUserRequestUserRole2.ProxyAdminViewer,
                _ => null,
            };
        }
    }
}