
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Model for Controlling UI Access Mode via SSO Groups
    /// </summary>
    public sealed partial class AccessControlUiAccessMode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"restricted_sso_group"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "restricted_sso_group";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restricted_sso_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RestrictedSsoGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso_group_jwt_field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SsoGroupJwtField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlUiAccessMode" /> class.
        /// </summary>
        /// <param name="restrictedSsoGroup"></param>
        /// <param name="ssoGroupJwtField"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessControlUiAccessMode(
            string restrictedSsoGroup,
            string ssoGroupJwtField,
            string type = "restricted_sso_group")
        {
            this.Type = type;
            this.RestrictedSsoGroup = restrictedSsoGroup ?? throw new global::System.ArgumentNullException(nameof(restrictedSsoGroup));
            this.SsoGroupJwtField = ssoGroupJwtField ?? throw new global::System.ArgumentNullException(nameof(ssoGroupJwtField));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessControlUiAccessMode" /> class.
        /// </summary>
        public AccessControlUiAccessMode()
        {
        }

    }
}