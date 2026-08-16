
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMemberAddRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("member")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.OrgMember>, global::Loud.Technology.LiteLLM.Sdk.OrgMember>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.OrgMember>, global::Loud.Technology.LiteLLM.Sdk.OrgMember> Member { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget_in_organization")]
        public double? MaxBudgetInOrganization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberAddRequest" /> class.
        /// </summary>
        /// <param name="member"></param>
        /// <param name="organizationId"></param>
        /// <param name="maxBudgetInOrganization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberAddRequest(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.OrgMember>, global::Loud.Technology.LiteLLM.Sdk.OrgMember> member,
            string organizationId,
            double? maxBudgetInOrganization)
        {
            this.Member = member;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.MaxBudgetInOrganization = maxBudgetInOrganization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberAddRequest" /> class.
        /// </summary>
        public OrganizationMemberAddRequest()
        {
        }

    }
}