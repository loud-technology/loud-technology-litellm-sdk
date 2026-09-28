
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default role to assign if user's groups don't match any role mappings. Must be a valid LitellmUserRoles value (e.g., 'proxy_admin', 'internal_user', 'proxy_admin_viewer')
    /// </summary>
    public sealed partial class RoleMappingsDefaultRole
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}