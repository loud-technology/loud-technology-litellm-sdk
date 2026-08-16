#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Regenerate Key Fn<br/>
        /// Regenerate an existing API key while optionally updating its parameters.<br/>
        /// Parameters:<br/>
        /// - key: str (path parameter) - The key to regenerate<br/>
        /// - data: Optional[RegenerateKeyRequest] - Request body containing optional parameters to update<br/>
        ///     - key: Optional[str] - The key to regenerate.<br/>
        ///     - new_master_key: Optional[str] - The new master key to use, if key is the master key.<br/>
        ///     - new_key: Optional[str] - The new key to use, if key is not the master key. Must start with 'sk-' and be at least 16 characters long. If both set, new_master_key will be used.<br/>
        ///     - key_alias: Optional[str] - User-friendly key alias<br/>
        ///     - user_id: Optional[str] - User ID associated with key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        ///     - spend: Optional[float] - Amount spent by key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - soft_budget: Optional[float] - Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        ///     - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        ///     - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        ///     - rpm_limit: Optional[int] - Requests per minute limit<br/>
        ///     - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        ///     - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        ///     - duration: Optional[str] - Key validity duration ("30d", "1h", etc.)<br/>
        ///     - permissions: Optional[dict] - Key-specific permissions<br/>
        ///     - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        ///     - blocked: Optional[bool] - Whether the key is blocked<br/>
        ///     - grace_period: Optional[str] - Duration to keep old key valid after rotation (e.g. "24h", "2d"). Omitted = immediate revoke. Env: LITELLM_KEY_ROTATION_GRACE_PERIOD<br/>
        /// Returns:<br/>
        /// - GenerateKeyResponse containing the new key and its updated parameters<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request POST 'http://localhost:4000/key/sk-1234/regenerate'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"team": "core-infra"},<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an Enterprise feature. It requires a premium license to use.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse> RegenerateKeyFnKeyRegeneratePostAsync(

            global::Loud.Technology.LiteLLM.Sdk.RegenerateKeyRequest request,
            string? key = default,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate Key Fn<br/>
        /// Regenerate an existing API key while optionally updating its parameters.<br/>
        /// Parameters:<br/>
        /// - key: str (path parameter) - The key to regenerate<br/>
        /// - data: Optional[RegenerateKeyRequest] - Request body containing optional parameters to update<br/>
        ///     - key: Optional[str] - The key to regenerate.<br/>
        ///     - new_master_key: Optional[str] - The new master key to use, if key is the master key.<br/>
        ///     - new_key: Optional[str] - The new key to use, if key is not the master key. Must start with 'sk-' and be at least 16 characters long. If both set, new_master_key will be used.<br/>
        ///     - key_alias: Optional[str] - User-friendly key alias<br/>
        ///     - user_id: Optional[str] - User ID associated with key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        ///     - spend: Optional[float] - Amount spent by key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - soft_budget: Optional[float] - Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        ///     - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        ///     - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        ///     - rpm_limit: Optional[int] - Requests per minute limit<br/>
        ///     - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        ///     - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        ///     - duration: Optional[str] - Key validity duration ("30d", "1h", etc.)<br/>
        ///     - permissions: Optional[dict] - Key-specific permissions<br/>
        ///     - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        ///     - blocked: Optional[bool] - Whether the key is blocked<br/>
        ///     - grace_period: Optional[str] - Duration to keep old key valid after rotation (e.g. "24h", "2d"). Omitted = immediate revoke. Env: LITELLM_KEY_ROTATION_GRACE_PERIOD<br/>
        /// Returns:<br/>
        /// - GenerateKeyResponse containing the new key and its updated parameters<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request POST 'http://localhost:4000/key/sk-1234/regenerate'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"team": "core-infra"},<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an Enterprise feature. It requires a premium license to use.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse>> RegenerateKeyFnKeyRegeneratePostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.RegenerateKeyRequest request,
            string? key = default,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Regenerate Key Fn<br/>
        /// Regenerate an existing API key while optionally updating its parameters.<br/>
        /// Parameters:<br/>
        /// - key: str (path parameter) - The key to regenerate<br/>
        /// - data: Optional[RegenerateKeyRequest] - Request body containing optional parameters to update<br/>
        ///     - key: Optional[str] - The key to regenerate.<br/>
        ///     - new_master_key: Optional[str] - The new master key to use, if key is the master key.<br/>
        ///     - new_key: Optional[str] - The new key to use, if key is not the master key. Must start with 'sk-' and be at least 16 characters long. If both set, new_master_key will be used.<br/>
        ///     - key_alias: Optional[str] - User-friendly key alias<br/>
        ///     - user_id: Optional[str] - User ID associated with key<br/>
        ///     - team_id: Optional[str] - Team ID associated with key<br/>
        ///     - models: Optional[list] - Model_name's a user is allowed to call<br/>
        ///     - tags: Optional[List[str]] - Tags for organizing keys (Enterprise only)<br/>
        ///     - spend: Optional[float] - Amount spent by key<br/>
        ///     - max_budget: Optional[float] - Max budget for key<br/>
        ///     - model_max_budget: Optional[Dict[str, BudgetConfig]] - Model-specific budgets {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - budget_fallbacks: Optional[Dict[str, List[str]]] - Per-model fallback chain tried in order when that model's own `model_max_budget` is exceeded, e.g. {"gpt-4o": ["gpt-4o-mini"]}.<br/>
        ///     - budget_duration: Optional[str] - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - soft_budget: Optional[float] - Soft budget limit (warning vs. hard stop). Will trigger a slack alert when this soft budget is reached.<br/>
        ///     - max_parallel_requests: Optional[int] - Rate limit for parallel requests<br/>
        ///     - metadata: Optional[dict] - Metadata for key. Example {"team": "core-infra", "app": "app2"}<br/>
        ///     - tpm_limit: Optional[int] - Tokens per minute limit<br/>
        ///     - rpm_limit: Optional[int] - Requests per minute limit<br/>
        ///     - model_rpm_limit: Optional[dict] - Model-specific RPM limits {"gpt-4": 100, "claude-v1": 200}<br/>
        ///     - model_tpm_limit: Optional[dict] - Model-specific TPM limits {"gpt-4": 100000, "claude-v1": 200000}<br/>
        ///     - allowed_cache_controls: Optional[list] - List of allowed cache control values<br/>
        ///     - duration: Optional[str] - Key validity duration ("30d", "1h", etc.)<br/>
        ///     - permissions: Optional[dict] - Key-specific permissions<br/>
        ///     - guardrails: Optional[List[str]] - List of active guardrails for the key<br/>
        ///     - blocked: Optional[bool] - Whether the key is blocked<br/>
        ///     - grace_period: Optional[str] - Duration to keep old key valid after rotation (e.g. "24h", "2d"). Omitted = immediate revoke. Env: LITELLM_KEY_ROTATION_GRACE_PERIOD<br/>
        /// Returns:<br/>
        /// - GenerateKeyResponse containing the new key and its updated parameters<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location --request POST 'http://localhost:4000/key/sk-1234/regenerate'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data-raw '{<br/>
        ///     "max_budget": 100,<br/>
        ///     "metadata": {"team": "core-infra"},<br/>
        ///     "models": ["gpt-4", "gpt-3.5-turbo"]<br/>
        /// }'<br/>
        /// ```<br/>
        /// Note: This is an Enterprise feature. It requires a premium license to use.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.GenerateKeyResponse> RegenerateKeyFnKeyRegeneratePostAsync(
            string? key = default,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}