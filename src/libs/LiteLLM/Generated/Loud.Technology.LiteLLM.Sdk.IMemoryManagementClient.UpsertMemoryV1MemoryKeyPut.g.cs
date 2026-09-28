#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMemoryManagementClient
    {
        /// <summary>
        /// Upsert Memory<br/>
        /// Upsert a memory entry by key within the caller's scope.<br/>
        /// If no row exists for (key, caller.user_id, caller.team_id), create one.<br/>
        /// If one exists, update the value/metadata fields that were provided.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMemoryRow> UpsertMemoryV1MemoryKeyPutAsync(
            string key,

            global::Loud.Technology.LiteLLM.Sdk.MemoryUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Memory<br/>
        /// Upsert a memory entry by key within the caller's scope.<br/>
        /// If no row exists for (key, caller.user_id, caller.team_id), create one.<br/>
        /// If one exists, update the value/metadata fields that were provided.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMemoryRow>> UpsertMemoryV1MemoryKeyPutAsResponseAsync(
            string key,

            global::Loud.Technology.LiteLLM.Sdk.MemoryUpdateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Memory<br/>
        /// Upsert a memory entry by key within the caller's scope.<br/>
        /// If no row exists for (key, caller.user_id, caller.team_id), create one.<br/>
        /// If one exists, update the value/metadata fields that were provided.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="metadata"></param>
        /// <param name="userId"></param>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMemoryRow> UpsertMemoryV1MemoryKeyPutAsync(
            string key,
            string? value = default,
            object? metadata = default,
            string? userId = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}