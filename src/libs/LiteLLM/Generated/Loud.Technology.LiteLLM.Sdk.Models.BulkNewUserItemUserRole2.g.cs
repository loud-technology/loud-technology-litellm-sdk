
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum BulkNewUserItemUserRole2
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
    public static class BulkNewUserItemUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkNewUserItemUserRole2 value)
        {
            return value switch
            {
                BulkNewUserItemUserRole2.InternalUser => "internal_user",
                BulkNewUserItemUserRole2.InternalUserViewer => "internal_user_viewer",
                BulkNewUserItemUserRole2.ProxyAdmin => "proxy_admin",
                BulkNewUserItemUserRole2.ProxyAdminViewer => "proxy_admin_viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkNewUserItemUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "internal_user" => BulkNewUserItemUserRole2.InternalUser,
                "internal_user_viewer" => BulkNewUserItemUserRole2.InternalUserViewer,
                "proxy_admin" => BulkNewUserItemUserRole2.ProxyAdmin,
                "proxy_admin_viewer" => BulkNewUserItemUserRole2.ProxyAdminViewer,
                _ => null,
            };
        }
    }
}