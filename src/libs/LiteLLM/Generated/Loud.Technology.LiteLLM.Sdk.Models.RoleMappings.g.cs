
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for mapping SSO groups to LiteLLM roles.<br/>
    /// The system will look at the group_claim field in the SSO token to determine<br/>
    /// which role to assign the user based on the roles mapping.
    /// </summary>
    public sealed partial class RoleMappings
    {
        /// <summary>
        /// SSO Provider name (e.g., 'google', 'microsoft', 'generic')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// The field name in the SSO token that contains the groups array (e.g., 'groups', 'roles')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_claim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupClaim { get; set; }

        /// <summary>
        /// Default role to assign if user's groups don't match any role mappings. Must be a valid LitellmUserRoles value (e.g., 'proxy_admin', 'internal_user', 'proxy_admin_viewer')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_role")]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmUserRoles? DefaultRole { get; set; }

        /// <summary>
        /// Mapping of LiteLLM role names to arrays of SSO group names. Example: {'proxy_admin': ['group-1', 'group-2'], 'proxy_admin_viewer': ['group-3']}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleMappings" /> class.
        /// </summary>
        /// <param name="provider">
        /// SSO Provider name (e.g., 'google', 'microsoft', 'generic')
        /// </param>
        /// <param name="groupClaim">
        /// The field name in the SSO token that contains the groups array (e.g., 'groups', 'roles')
        /// </param>
        /// <param name="defaultRole">
        /// Default role to assign if user's groups don't match any role mappings. Must be a valid LitellmUserRoles value (e.g., 'proxy_admin', 'internal_user', 'proxy_admin_viewer')
        /// </param>
        /// <param name="roles">
        /// Mapping of LiteLLM role names to arrays of SSO group names. Example: {'proxy_admin': ['group-1', 'group-2'], 'proxy_admin_viewer': ['group-3']}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoleMappings(
            string provider,
            string groupClaim,
            global::Loud.Technology.LiteLLM.Sdk.LitellmUserRoles? defaultRole,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? roles)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.GroupClaim = groupClaim ?? throw new global::System.ArgumentNullException(nameof(groupClaim));
            this.DefaultRole = defaultRole;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleMappings" /> class.
        /// </summary>
        public RoleMappings()
        {
        }

    }
}