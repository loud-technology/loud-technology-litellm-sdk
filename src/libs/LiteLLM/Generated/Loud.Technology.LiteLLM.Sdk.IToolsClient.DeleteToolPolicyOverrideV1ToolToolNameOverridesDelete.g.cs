#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Delete Tool Policy Override<br/>
        /// Remove a policy override for a tool. Specify the override by team_id or key_hash<br/>
        /// (exactly one required).
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="teamId">
        /// Team ID of the override to remove
        /// </param>
        /// <param name="keyHash">
        /// Key hash of the override to remove
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteToolPolicyOverrideV1ToolToolNameOverridesDeleteAsync(
            string toolName,
            string? teamId = default,
            string? keyHash = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Tool Policy Override<br/>
        /// Remove a policy override for a tool. Specify the override by team_id or key_hash<br/>
        /// (exactly one required).
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="teamId">
        /// Team ID of the override to remove
        /// </param>
        /// <param name="keyHash">
        /// Key hash of the override to remove
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> DeleteToolPolicyOverrideV1ToolToolNameOverridesDeleteAsResponseAsync(
            string toolName,
            string? teamId = default,
            string? keyHash = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}