#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// List Placeholders<br/>
        /// List user rows whose id is another account's SSO identity or email.<br/>
        /// An earlier release provisioned a group member it could not match as a user keyed<br/>
        /// by the raw member value, and that row now shadows the account the value really<br/>
        /// names, so every push of that member is refused. This lists those rows so an<br/>
        /// operator can fold each one into the account it shadows with<br/>
        /// ``POST /scim/v2/placeholders/{user_id}/merge``. A row that has an SSO identity of<br/>
        /// its own or owns virtual keys is left out: someone uses that account.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMPlaceholder>> ListPlaceholdersScimV2PlaceholdersGetAsync(
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Placeholders<br/>
        /// List user rows whose id is another account's SSO identity or email.<br/>
        /// An earlier release provisioned a group member it could not match as a user keyed<br/>
        /// by the raw member value, and that row now shadows the account the value really<br/>
        /// names, so every push of that member is refused. This lists those rows so an<br/>
        /// operator can fold each one into the account it shadows with<br/>
        /// ``POST /scim/v2/placeholders/{user_id}/merge``. A row that has an SSO identity of<br/>
        /// its own or owns virtual keys is left out: someone uses that account.
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMPlaceholder>>> ListPlaceholdersScimV2PlaceholdersGetAsResponseAsync(
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}