
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SCIMUserInput
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserEmail>? Emails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entitlements")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMMultiValuedAttribute>? Entitlements { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserGroup>? Groups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMUserName? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMMultiValuedAttribute>? Roles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemas { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urn:ietf:params:scim:schemas:extension:enterprise:2.0:User")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMEnterpriseUser? Urn_ietf_params_scim_schemas_extension_enterprise_20_User { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMUserInput" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="emails"></param>
        /// <param name="entitlements"></param>
        /// <param name="externalId"></param>
        /// <param name="groups"></param>
        /// <param name="id"></param>
        /// <param name="meta"></param>
        /// <param name="name"></param>
        /// <param name="roles"></param>
        /// <param name="urn_ietf_params_scim_schemas_extension_enterprise_20_User"></param>
        /// <param name="userName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMUserInput(
            global::System.Collections.Generic.IList<string> schemas,
            bool? active,
            string? displayName,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserEmail>? emails,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMMultiValuedAttribute>? entitlements,
            string? externalId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserGroup>? groups,
            string? id,
            object? meta,
            global::Loud.Technology.LiteLLM.Sdk.SCIMUserName? name,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMMultiValuedAttribute>? roles,
            global::Loud.Technology.LiteLLM.Sdk.SCIMEnterpriseUser? urn_ietf_params_scim_schemas_extension_enterprise_20_User,
            string? userName)
        {
            this.Active = active;
            this.DisplayName = displayName;
            this.Emails = emails;
            this.Entitlements = entitlements;
            this.ExternalId = externalId;
            this.Groups = groups;
            this.Id = id;
            this.Meta = meta;
            this.Name = name;
            this.Roles = roles;
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.Urn_ietf_params_scim_schemas_extension_enterprise_20_User = urn_ietf_params_scim_schemas_extension_enterprise_20_User;
            this.UserName = userName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMUserInput" /> class.
        /// </summary>
        public SCIMUserInput()
        {
        }

    }
}