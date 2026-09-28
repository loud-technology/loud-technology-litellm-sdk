#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICoordinationRedisSettingsClient
    {
        /// <summary>
        /// Update Coordination Redis Settings<br/>
        /// Save coordination Redis settings under `general_settings.coordination_redis`.<br/>
        /// Parameters:<br/>
        /// - settings: dict - Redis connection params (host, port, username, password, url, ssl, startup_nodes, sentinel_nodes, sentinel_password, service_name). Values may be `os.environ/VAR` references, which are stored as written and resolved at startup<br/>
        /// The settings are written to the `general_settings` row of LiteLLM_Config,<br/>
        /// which startup merges over the yaml config; the proxy picks them up on its<br/>
        /// next restart.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCoordinationRedisSettingsCoordinationRedisSettingsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Coordination Redis Settings<br/>
        /// Save coordination Redis settings under `general_settings.coordination_redis`.<br/>
        /// Parameters:<br/>
        /// - settings: dict - Redis connection params (host, port, username, password, url, ssl, startup_nodes, sentinel_nodes, sentinel_password, service_name). Values may be `os.environ/VAR` references, which are stored as written and resolved at startup<br/>
        /// The settings are written to the `general_settings` row of LiteLLM_Config,<br/>
        /// which startup merges over the yaml config; the proxy picks them up on its<br/>
        /// next restart.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateCoordinationRedisSettingsCoordinationRedisSettingsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CoordinationRedisSettingsRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Coordination Redis Settings<br/>
        /// Save coordination Redis settings under `general_settings.coordination_redis`.<br/>
        /// Parameters:<br/>
        /// - settings: dict - Redis connection params (host, port, username, password, url, ssl, startup_nodes, sentinel_nodes, sentinel_password, service_name). Values may be `os.environ/VAR` references, which are stored as written and resolved at startup<br/>
        /// The settings are written to the `general_settings` row of LiteLLM_Config,<br/>
        /// which startup merges over the yaml config; the proxy picks them up on its<br/>
        /// next restart.
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="settings">
        /// Coordination Redis connection params
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateCoordinationRedisSettingsCoordinationRedisSettingsPostAsync(
            object settings,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}