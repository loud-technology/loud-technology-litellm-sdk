
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum DefaultInternalUserParamsUserRole2
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
    public static class DefaultInternalUserParamsUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DefaultInternalUserParamsUserRole2 value)
        {
            return value switch
            {
                DefaultInternalUserParamsUserRole2.InternalUser => "internal_user",
                DefaultInternalUserParamsUserRole2.InternalUserViewer => "internal_user_viewer",
                DefaultInternalUserParamsUserRole2.ProxyAdmin => "proxy_admin",
                DefaultInternalUserParamsUserRole2.ProxyAdminViewer => "proxy_admin_viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DefaultInternalUserParamsUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "internal_user" => DefaultInternalUserParamsUserRole2.InternalUser,
                "internal_user_viewer" => DefaultInternalUserParamsUserRole2.InternalUserViewer,
                "proxy_admin" => DefaultInternalUserParamsUserRole2.ProxyAdmin,
                "proxy_admin_viewer" => DefaultInternalUserParamsUserRole2.ProxyAdminViewer,
                _ => null,
            };
        }
    }
}