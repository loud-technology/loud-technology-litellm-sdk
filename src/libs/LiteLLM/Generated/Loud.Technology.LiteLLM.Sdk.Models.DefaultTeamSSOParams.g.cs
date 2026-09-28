
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default parameters applied to every /team/new call for fields not explicitly provided in the request.<br/>
    /// `models` is the exception: it only applies to teams automatically created by LiteLLM via SSO Groups.
    /// </summary>
    public sealed partial class DefaultTeamSSOParams
    {
        /// <summary>
        /// Default list of models for teams automatically created via SSO Groups<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Default maximum budget (in USD) for new teams, when not explicitly provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// Default budget duration for new teams, when not explicitly provided (e.g. '24h', '7d', '30d')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// Default tpm limit for new teams, when not explicitly provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit")]
        public int? TpmLimit { get; set; }

        /// <summary>
        /// Default rpm limit for new teams, when not explicitly provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit")]
        public int? RpmLimit { get; set; }

        /// <summary>
        /// Default permissions granted to members of newly created teams (e.g. /key/generate, /key/update, /key/delete). /key/info and /key/health are always included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_permissions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeyManagementRoutes>? TeamMemberPermissions { get; set; }

        /// <summary>
        /// Default organization for new teams created without an explicit organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public string? OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTeamSSOParams" /> class.
        /// </summary>
        /// <param name="models">
        /// Default list of models for teams automatically created via SSO Groups<br/>
        /// Default Value: []
        /// </param>
        /// <param name="maxBudget">
        /// Default maximum budget (in USD) for new teams, when not explicitly provided
        /// </param>
        /// <param name="budgetDuration">
        /// Default budget duration for new teams, when not explicitly provided (e.g. '24h', '7d', '30d')
        /// </param>
        /// <param name="tpmLimit">
        /// Default tpm limit for new teams, when not explicitly provided
        /// </param>
        /// <param name="rpmLimit">
        /// Default rpm limit for new teams, when not explicitly provided
        /// </param>
        /// <param name="teamMemberPermissions">
        /// Default permissions granted to members of newly created teams (e.g. /key/generate, /key/update, /key/delete). /key/info and /key/health are always included.
        /// </param>
        /// <param name="organizationId">
        /// Default organization for new teams created without an explicit organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultTeamSSOParams(
            global::System.Collections.Generic.IList<string>? models,
            double? maxBudget,
            string? budgetDuration,
            int? tpmLimit,
            int? rpmLimit,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeyManagementRoutes>? teamMemberPermissions,
            string? organizationId)
        {
            this.Models = models;
            this.MaxBudget = maxBudget;
            this.BudgetDuration = budgetDuration;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.TeamMemberPermissions = teamMemberPermissions;
            this.OrganizationId = organizationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTeamSSOParams" /> class.
        /// </summary>
        public DefaultTeamSSOParams()
        {
        }

    }
}