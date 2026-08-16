#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IMemoryManagementClient
    {
        /// <summary>
        /// Create Memory<br/>
        /// Create a new memory entry for the caller (or, for admins, any scope).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMemoryRow> CreateMemoryV1MemoryPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.MemoryCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Memory<br/>
        /// Create a new memory entry for the caller (or, for admins, any scope).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMemoryRow>> CreateMemoryV1MemoryPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.MemoryCreateRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Memory<br/>
        /// Create a new memory entry for the caller (or, for admins, any scope).
        /// </summary>
        /// <param name="key">
        /// Memory key (acts as the namespace in the URL).
        /// </param>
        /// <param name="value">
        /// Memory content. Typically markdown/text for LLM context.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON metadata (tags, structured fields).
        /// </param>
        /// <param name="userId">
        /// Scope to this user. Defaults to the caller's user_id.
        /// </param>
        /// <param name="teamId">
        /// Scope to this team. Defaults to the caller's team_id.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMemoryRow> CreateMemoryV1MemoryPostAsync(
            string key,
            string value,
            object? metadata = default,
            string? userId = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}