#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ISsoSettingsClient
    {
        /// <summary>
        /// Update Default Team Settings<br/>
        /// Update the default team parameters (litellm_settings.default_team_params).<br/>
        /// Applied to every new team for fields not explicitly provided in the create request;<br/>
        /// `models` only applies to teams automatically created via SSO Groups.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateDefaultTeamSettingsUpdateDefaultTeamSettingsPatchAsync(

            global::Loud.Technology.LiteLLM.Sdk.DefaultTeamSSOParams request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Default Team Settings<br/>
        /// Update the default team parameters (litellm_settings.default_team_params).<br/>
        /// Applied to every new team for fields not explicitly provided in the create request;<br/>
        /// `models` only applies to teams automatically created via SSO Groups.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateDefaultTeamSettingsUpdateDefaultTeamSettingsPatchAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.DefaultTeamSSOParams request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Default Team Settings<br/>
        /// Update the default team parameters (litellm_settings.default_team_params).<br/>
        /// Applied to every new team for fields not explicitly provided in the create request;<br/>
        /// `models` only applies to teams automatically created via SSO Groups.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateDefaultTeamSettingsUpdateDefaultTeamSettingsPatchAsync(
            global::System.Collections.Generic.IList<string>? models = default,
            double? maxBudget = default,
            string? budgetDuration = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.KeyManagementRoutes>? teamMemberPermissions = default,
            string? organizationId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}