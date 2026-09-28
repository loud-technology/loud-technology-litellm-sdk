#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICacheSettingsClient
    {
        /// <summary>
        /// Update Cache Settings<br/>
        /// Save cache settings to database and initialize cache.<br/>
        /// This endpoint:<br/>
        /// 1. Encrypts sensitive fields (passwords, etc.)<br/>
        /// 2. Saves to LiteLLM_CacheConfig table<br/>
        /// 3. Reinitializes cache with new settings
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCacheSettingsCacheSettingsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CacheSettingsUpdateRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cache Settings<br/>
        /// Save cache settings to database and initialize cache.<br/>
        /// This endpoint:<br/>
        /// 1. Encrypts sensitive fields (passwords, etc.)<br/>
        /// 2. Saves to LiteLLM_CacheConfig table<br/>
        /// 3. Reinitializes cache with new settings
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateCacheSettingsCacheSettingsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CacheSettingsUpdateRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Cache Settings<br/>
        /// Save cache settings to database and initialize cache.<br/>
        /// This endpoint:<br/>
        /// 1. Encrypts sensitive fields (passwords, etc.)<br/>
        /// 2. Saves to LiteLLM_CacheConfig table<br/>
        /// 3. Reinitializes cache with new settings
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="cacheSettings">
        /// Cache settings to save
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCacheSettingsCacheSettingsPostAsync(
            object cacheSettings,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}