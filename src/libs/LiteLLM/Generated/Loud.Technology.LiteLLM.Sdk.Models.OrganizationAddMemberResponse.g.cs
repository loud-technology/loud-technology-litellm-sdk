
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationAddMemberResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMUserTable> UpdatedUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_organization_memberships")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable> UpdatedOrganizationMemberships { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationAddMemberResponse" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="updatedUsers"></param>
        /// <param name="updatedOrganizationMemberships"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationAddMemberResponse(
            string organizationId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMUserTable> updatedUsers,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMOrganizationMembershipTable> updatedOrganizationMemberships)
        {
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.UpdatedUsers = updatedUsers ?? throw new global::System.ArgumentNullException(nameof(updatedUsers));
            this.UpdatedOrganizationMemberships = updatedOrganizationMemberships ?? throw new global::System.ArgumentNullException(nameof(updatedOrganizationMemberships));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationAddMemberResponse" /> class.
        /// </summary>
        public OrganizationAddMemberResponse()
        {
        }

    }
}