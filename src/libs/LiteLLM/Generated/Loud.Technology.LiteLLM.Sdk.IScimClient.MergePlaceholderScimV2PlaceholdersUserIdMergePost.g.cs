#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Merge Placeholder<br/>
        /// Fold a placeholder user into the one account its id names by SSO identity or email.<br/>
        /// The account is added to every team the placeholder is on, then the placeholder is<br/>
        /// deleted the way ``DELETE /scim/v2/Users/{id}`` deletes a user, so the next group<br/>
        /// push resolves the member value to the real account. Refused with 409 when the row<br/>
        /// has an SSO identity of its own, owns virtual keys, or names no account or several.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SCIMPlaceholderMergeResult> MergePlaceholderScimV2PlaceholdersUserIdMergePostAsync(
            string userId,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge Placeholder<br/>
        /// Fold a placeholder user into the one account its id names by SSO identity or email.<br/>
        /// The account is added to every team the placeholder is on, then the placeholder is<br/>
        /// deleted the way ``DELETE /scim/v2/Users/{id}`` deletes a user, so the next group<br/>
        /// push resolves the member value to the real account. Refused with 409 when the row<br/>
        /// has an SSO identity of its own, owns virtual keys, or names no account or several.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SCIMPlaceholderMergeResult>> MergePlaceholderScimV2PlaceholdersUserIdMergePostAsResponseAsync(
            string userId,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}