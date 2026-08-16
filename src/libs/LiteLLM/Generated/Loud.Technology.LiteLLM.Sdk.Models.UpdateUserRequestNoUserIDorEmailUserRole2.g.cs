
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateUserRequestNoUserIDorEmailUserRole2
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
    public static class UpdateUserRequestNoUserIDorEmailUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateUserRequestNoUserIDorEmailUserRole2 value)
        {
            return value switch
            {
                UpdateUserRequestNoUserIDorEmailUserRole2.InternalUser => "internal_user",
                UpdateUserRequestNoUserIDorEmailUserRole2.InternalUserViewer => "internal_user_viewer",
                UpdateUserRequestNoUserIDorEmailUserRole2.ProxyAdmin => "proxy_admin",
                UpdateUserRequestNoUserIDorEmailUserRole2.ProxyAdminViewer => "proxy_admin_viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateUserRequestNoUserIDorEmailUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "internal_user" => UpdateUserRequestNoUserIDorEmailUserRole2.InternalUser,
                "internal_user_viewer" => UpdateUserRequestNoUserIDorEmailUserRole2.InternalUserViewer,
                "proxy_admin" => UpdateUserRequestNoUserIDorEmailUserRole2.ProxyAdmin,
                "proxy_admin_viewer" => UpdateUserRequestNoUserIDorEmailUserRole2.ProxyAdminViewer,
                _ => null,
            };
        }
    }
}