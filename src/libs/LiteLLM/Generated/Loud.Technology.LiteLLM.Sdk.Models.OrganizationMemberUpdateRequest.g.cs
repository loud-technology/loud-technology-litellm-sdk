
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMemberUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Loud.Technology.LiteLLM.Sdk.LitellmUserRoles? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberUpdateRequest" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="maxBudgetInOrganization"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberUpdateRequest(
            string organizationId,
            string? userId,
            string? userEmail,
            double? maxBudgetInOrganization,
            global::Loud.Technology.LiteLLM.Sdk.LitellmUserRoles? role)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.MaxBudgetInOrganization = maxBudgetInOrganization;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberUpdateRequest" /> class.
        /// </summary>
        public OrganizationMemberUpdateRequest()
        {
        }

    }
}