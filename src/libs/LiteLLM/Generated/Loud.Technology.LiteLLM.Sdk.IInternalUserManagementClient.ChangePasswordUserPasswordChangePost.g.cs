#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IInternalUserManagementClient
    {
        /// <summary>
        /// Change Password<br/>
        /// Change the calling user's own password.<br/>
        /// Only callable with the dashboard session issued by a username/password<br/>
        /// login; SSO sessions and virtual keys are rejected with 403. Requires the<br/>
        /// current password. The new password must differ from the<br/>
        /// current one and satisfy the configured password policy<br/>
        /// (`general_settings.password_policy_*`: minimum length, character classes,<br/>
        /// and, when enabled, breached-password screening via haveibeenpwned.com).<br/>
        /// A successful change lifts any pending forced password reset<br/>
        /// (`password_reset_required`) on the account.<br/>
        /// Parameters:<br/>
        /// - current_password: str - The user's current password.<br/>
        /// - new_password: str - The password to change to.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ChangePasswordResponse> ChangePasswordUserPasswordChangePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.ChangePasswordRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change Password<br/>
        /// Change the calling user's own password.<br/>
        /// Only callable with the dashboard session issued by a username/password<br/>
        /// login; SSO sessions and virtual keys are rejected with 403. Requires the<br/>
        /// current password. The new password must differ from the<br/>
        /// current one and satisfy the configured password policy<br/>
        /// (`general_settings.password_policy_*`: minimum length, character classes,<br/>
        /// and, when enabled, breached-password screening via haveibeenpwned.com).<br/>
        /// A successful change lifts any pending forced password reset<br/>
        /// (`password_reset_required`) on the account.<br/>
        /// Parameters:<br/>
        /// - current_password: str - The user's current password.<br/>
        /// - new_password: str - The password to change to.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ChangePasswordResponse>> ChangePasswordUserPasswordChangePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.ChangePasswordRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Change Password<br/>
        /// Change the calling user's own password.<br/>
        /// Only callable with the dashboard session issued by a username/password<br/>
        /// login; SSO sessions and virtual keys are rejected with 403. Requires the<br/>
        /// current password. The new password must differ from the<br/>
        /// current one and satisfy the configured password policy<br/>
        /// (`general_settings.password_policy_*`: minimum length, character classes,<br/>
        /// and, when enabled, breached-password screening via haveibeenpwned.com).<br/>
        /// A successful change lifts any pending forced password reset<br/>
        /// (`password_reset_required`) on the account.<br/>
        /// Parameters:<br/>
        /// - current_password: str - The user's current password.<br/>
        /// - new_password: str - The password to change to.
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <param name="newPassword"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ChangePasswordResponse> ChangePasswordUserPasswordChangePostAsync(
            string currentPassword,
            string newPassword,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}