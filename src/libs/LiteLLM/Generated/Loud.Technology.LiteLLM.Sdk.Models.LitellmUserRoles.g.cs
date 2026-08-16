
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Admin Roles:<br/>
    /// PROXY_ADMIN: admin over the platform<br/>
    /// PROXY_ADMIN_VIEW_ONLY: can login, view all own keys, view all spend<br/>
    /// ORG_ADMIN: admin over a specific organization, can create teams, users only within their organization<br/>
    /// Internal User Roles:<br/>
    /// INTERNAL_USER: can login, view/create/delete their own keys, view their spend<br/>
    /// INTERNAL_USER_VIEW_ONLY: can login, view their own keys, view their own spend<br/>
    /// Team Roles:<br/>
    /// TEAM: used for JWT auth<br/>
    /// Customer Roles:<br/>
    /// CUSTOMER: External users -&gt; these are customers
    /// </summary>
    public enum LitellmUserRoles
    {
        /// <summary>
        /// External users -&gt; these are customers
        /// </summary>
        Customer,
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
        OrgAdmin,
        /// <summary>
        /// 
        /// </summary>
        ProxyAdmin,
        /// <summary>
        /// 
        /// </summary>
        ProxyAdminViewer,
        /// <summary>
        /// admin over a specific organization, can create teams, users only within their organization
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LitellmUserRolesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmUserRoles value)
        {
            return value switch
            {
                LitellmUserRoles.Customer => "customer",
                LitellmUserRoles.InternalUser => "internal_user",
                LitellmUserRoles.InternalUserViewer => "internal_user_viewer",
                LitellmUserRoles.OrgAdmin => "org_admin",
                LitellmUserRoles.ProxyAdmin => "proxy_admin",
                LitellmUserRoles.ProxyAdminViewer => "proxy_admin_viewer",
                LitellmUserRoles.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmUserRoles? ToEnum(string value)
        {
            return value switch
            {
                "customer" => LitellmUserRoles.Customer,
                "internal_user" => LitellmUserRoles.InternalUser,
                "internal_user_viewer" => LitellmUserRoles.InternalUserViewer,
                "org_admin" => LitellmUserRoles.OrgAdmin,
                "proxy_admin" => LitellmUserRoles.ProxyAdmin,
                "proxy_admin_viewer" => LitellmUserRoles.ProxyAdminViewer,
                "team" => LitellmUserRoles.Team,
                _ => null,
            };
        }
    }
}