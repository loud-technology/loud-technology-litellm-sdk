
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default parameters to apply when a new team is automatically created by LiteLLM via SSO Groups
    /// </summary>
    public sealed partial class DefaultTeamSSOParams
    {
        /// <summary>
        /// Default list of models that new automatically created teams can access<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Default maximum budget (in USD) for new automatically created teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        /// Default budget duration for new automatically created teams (e.g. 'daily', 'weekly', 'monthly')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        /// Default tpm limit for new automatically created teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm_limit")]
        public int? TpmLimit { get; set; }

        /// <summary>
        /// Default rpm limit for new automatically created teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm_limit")]
        public int? RpmLimit { get; set; }

        /// <summary>
        /// Default permissions granted to members of newly created teams (e.g. /key/generate, /key/update, /key/delete). /key/info and /key/health are always included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_member_permissions")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeyManagementRoutes>? TeamMemberPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTeamSSOParams" /> class.
        /// </summary>
        /// <param name="models">
        /// Default list of models that new automatically created teams can access<br/>
        /// Default Value: []
        /// </param>
        /// <param name="maxBudget">
        /// Default maximum budget (in USD) for new automatically created teams
        /// </param>
        /// <param name="budgetDuration">
        /// Default budget duration for new automatically created teams (e.g. 'daily', 'weekly', 'monthly')
        /// </param>
        /// <param name="tpmLimit">
        /// Default tpm limit for new automatically created teams
        /// </param>
        /// <param name="rpmLimit">
        /// Default rpm limit for new automatically created teams
        /// </param>
        /// <param name="teamMemberPermissions">
        /// Default permissions granted to members of newly created teams (e.g. /key/generate, /key/update, /key/delete). /key/info and /key/health are always included.
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
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeyManagementRoutes>? teamMemberPermissions)
        {
            this.Models = models;
            this.MaxBudget = maxBudget;
            this.BudgetDuration = budgetDuration;
            this.TpmLimit = tpmLimit;
            this.RpmLimit = rpmLimit;
            this.TeamMemberPermissions = teamMemberPermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTeamSSOParams" /> class.
        /// </summary>
        public DefaultTeamSSOParams()
        {
        }

    }
}