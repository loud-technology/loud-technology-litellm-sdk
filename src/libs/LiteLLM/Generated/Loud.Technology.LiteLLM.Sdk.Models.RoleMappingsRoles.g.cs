
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Mapping of LiteLLM role names to arrays of SSO group names. Example: {'proxy_admin': ['group-1', 'group-2'], 'proxy_admin_viewer': ['group-3']}
    /// </summary>
    public sealed partial class RoleMappingsRoles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}