#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IScimClient
    {
        /// <summary>
        /// Patch Group<br/>
        /// Patch a group according to SCIM v2 protocol
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="feature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SCIMGroup> PatchGroupScimV2GroupsGroupIdPatchAsync(
            string groupId,

            global::Loud.Technology.LiteLLM.Sdk.SCIMPatchOp request,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Group<br/>
        /// Patch a group according to SCIM v2 protocol
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="feature"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.SCIMGroup>> PatchGroupScimV2GroupsGroupIdPatchAsResponseAsync(
            string groupId,

            global::Loud.Technology.LiteLLM.Sdk.SCIMPatchOp request,
            string? feature = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Group<br/>
        /// Patch a group according to SCIM v2 protocol
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="feature"></param>
        /// <param name="operations"></param>
        /// <param name="schemas">
        /// Default Value: [urn:ietf:params:scim:api:messages:2.0:PatchOp]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.SCIMGroup> PatchGroupScimV2GroupsGroupIdPatchAsync(
            string groupId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMPatchOperation> operations,
            string? feature = default,
            global::System.Collections.Generic.IList<string>? schemas = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}