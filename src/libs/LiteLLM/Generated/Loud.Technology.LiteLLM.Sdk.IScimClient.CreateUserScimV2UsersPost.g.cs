#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Create User<br/>
        /// Create a user according to SCIM v2 protocol
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SCIMUserOutput> CreateUserScimV2UsersPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.SCIMUserInput request,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create User<br/>
        /// Create a user according to SCIM v2 protocol
        /// </summary>
        /// <param name="feature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SCIMUserOutput>> CreateUserScimV2UsersPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.SCIMUserInput request,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create User<br/>
        /// Create a user according to SCIM v2 protocol
        /// </summary>
        /// <param name="feature"></param>
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
        /// <param name="schemas"></param>
        /// <param name="urn_ietf_params_scim_schemas_extension_enterprise_20_User"></param>
        /// <param name="userName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SCIMUserOutput> CreateUserScimV2UsersPostAsync(
            global::System.Collections.Generic.IList<string> schemas,
            string? feature = default,
            bool? active = default,
            string? displayName = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserEmail>? emails = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMMultiValuedAttribute>? entitlements = default,
            string? externalId = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserGroup>? groups = default,
            string? id = default,
            object? meta = default,
            global::Loud.Technology.LiteLLM.Sdk.SCIMUserName? name = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMMultiValuedAttribute>? roles = default,
            global::Loud.Technology.LiteLLM.Sdk.SCIMEnterpriseUser? urn_ietf_params_scim_schemas_extension_enterprise_20_User = default,
            string? userName = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}