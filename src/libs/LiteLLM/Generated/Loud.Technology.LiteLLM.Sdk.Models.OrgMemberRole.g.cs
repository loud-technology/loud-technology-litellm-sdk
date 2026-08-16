
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrgMemberRole
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
        OrgAdmin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgMemberRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgMemberRole value)
        {
            return value switch
            {
                OrgMemberRole.InternalUser => "internal_user",
                OrgMemberRole.InternalUserViewer => "internal_user_viewer",
                OrgMemberRole.OrgAdmin => "org_admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgMemberRole? ToEnum(string value)
        {
            return value switch
            {
                "internal_user" => OrgMemberRole.InternalUser,
                "internal_user_viewer" => OrgMemberRole.InternalUserViewer,
                "org_admin" => OrgMemberRole.OrgAdmin,
                _ => null,
            };
        }
    }
}