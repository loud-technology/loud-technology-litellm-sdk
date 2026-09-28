#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Info Key Fn<br/>
        /// Retrieve information about a key.<br/>
        /// Parameters:<br/>
        /// - key: str | None (query parameter) - The key to look up. Accepts the plaintext key or its hash;<br/>
        ///   prefer the hash, since a query parameter is recorded verbatim by any HTTP access log in front<br/>
        ///   of the proxy. Defaults to the key in the Authorization header.<br/>
        /// Returns:<br/>
        /// - key: str - The key that was looked up, echoed back as it was passed in<br/>
        /// - info: dict - The key's row, minus the hashed token. Deleted keys are served from the<br/>
        ///   LiteLLM_DeletedVerificationToken archive and carry deleted_at / deleted_by<br/>
        ///     - status: "active" | "expired" | "revoked" | "deleted" - Derived from blocked, expires and<br/>
        ///       whether the row came from the archive<br/>
        ///     - key_alias: str | None - User-friendly key alias<br/>
        ///     - spend: float - Amount spent by the key. When budget_duration is set this covers only the<br/>
        ///       current budget window, not the key's lifetime<br/>
        ///     - max_budget: float | None - Max budget for the key, enforced against spend<br/>
        ///     - budget_duration: str | None - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - budget_reset_at: datetime | None - When the current budget window ends and spend is next<br/>
        ///       reset to 0, not when it was last reset. Reset times snap to standard boundaries in the<br/>
        ///       configured timezone (30d and 1mo land on the 1st of the month, 7d on Monday, 1h on the<br/>
        ///       hour), so subtracting budget_duration from it does not give the window's start<br/>
        ///     - model_max_budget: dict - Per-model budgets, e.g. {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - model_max_budget_usage: dict | None - Current-window spend per model, present only when<br/>
        ///       the key has per-model budgets<br/>
        ///     - budget_limits: list | None - Concurrent budget windows, exactly as stored<br/>
        ///     - budget_limits_usage: dict | None - Current-window spend per budget window, e.g.<br/>
        ///       {"1h": {"current_spend": 0.0009}}, present only when the key has budget windows<br/>
        ///       (read from the same cross-pod spend counter the budget enforcement uses)<br/>
        ///     - models: list - Model_name's the key is allowed to call<br/>
        ///     - tpm_limit / rpm_limit: int | None - Tokens and requests per minute limits<br/>
        ///     - metadata: dict - Metadata for the key, e.g. {"team": "core-infra"}<br/>
        ///     - blocked: bool | None - Whether the key is blocked<br/>
        ///     - expires: datetime | None - When the key stops authenticating requests<br/>
        ///     - last_active: datetime | None - When the key was last used<br/>
        ///     - object_permission: dict | None - Resolved vector store / MCP permissions when the key has<br/>
        ///       an object_permission_id<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info?key=d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Curl - if no key is passed, it will use the Key Passed in Authorization Header<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info" -H "Authorization: Bearer sk-test-example-key-123"<br/>
        /// ```
        /// </summary>
        /// <param name="key">
        /// Key to look up. Pass the key's sha256 hash so the raw key stays out of URLs and access logs. Example key='d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InfoKeyFnKeyInfoGetAsync(
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Info Key Fn<br/>
        /// Retrieve information about a key.<br/>
        /// Parameters:<br/>
        /// - key: str | None (query parameter) - The key to look up. Accepts the plaintext key or its hash;<br/>
        ///   prefer the hash, since a query parameter is recorded verbatim by any HTTP access log in front<br/>
        ///   of the proxy. Defaults to the key in the Authorization header.<br/>
        /// Returns:<br/>
        /// - key: str - The key that was looked up, echoed back as it was passed in<br/>
        /// - info: dict - The key's row, minus the hashed token. Deleted keys are served from the<br/>
        ///   LiteLLM_DeletedVerificationToken archive and carry deleted_at / deleted_by<br/>
        ///     - status: "active" | "expired" | "revoked" | "deleted" - Derived from blocked, expires and<br/>
        ///       whether the row came from the archive<br/>
        ///     - key_alias: str | None - User-friendly key alias<br/>
        ///     - spend: float - Amount spent by the key. When budget_duration is set this covers only the<br/>
        ///       current budget window, not the key's lifetime<br/>
        ///     - max_budget: float | None - Max budget for the key, enforced against spend<br/>
        ///     - budget_duration: str | None - Budget reset period ("30d", "1h", etc.)<br/>
        ///     - budget_reset_at: datetime | None - When the current budget window ends and spend is next<br/>
        ///       reset to 0, not when it was last reset. Reset times snap to standard boundaries in the<br/>
        ///       configured timezone (30d and 1mo land on the 1st of the month, 7d on Monday, 1h on the<br/>
        ///       hour), so subtracting budget_duration from it does not give the window's start<br/>
        ///     - model_max_budget: dict - Per-model budgets, e.g. {"gpt-4": {"budget_limit": 0.0005, "time_period": "30d"}}<br/>
        ///     - model_max_budget_usage: dict | None - Current-window spend per model, present only when<br/>
        ///       the key has per-model budgets<br/>
        ///     - budget_limits: list | None - Concurrent budget windows, exactly as stored<br/>
        ///     - budget_limits_usage: dict | None - Current-window spend per budget window, e.g.<br/>
        ///       {"1h": {"current_spend": 0.0009}}, present only when the key has budget windows<br/>
        ///       (read from the same cross-pod spend counter the budget enforcement uses)<br/>
        ///     - models: list - Model_name's the key is allowed to call<br/>
        ///     - tpm_limit / rpm_limit: int | None - Tokens and requests per minute limits<br/>
        ///     - metadata: dict - Metadata for the key, e.g. {"team": "core-infra"}<br/>
        ///     - blocked: bool | None - Whether the key is blocked<br/>
        ///     - expires: datetime | None - When the key stops authenticating requests<br/>
        ///     - last_active: datetime | None - When the key was last used<br/>
        ///     - object_permission: dict | None - Resolved vector store / MCP permissions when the key has<br/>
        ///       an object_permission_id<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info?key=d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa" -H "Authorization: Bearer sk-1234"<br/>
        /// ```<br/>
        /// Example Curl - if no key is passed, it will use the Key Passed in Authorization Header<br/>
        /// ```<br/>
        /// curl -X GET "http://0.0.0.0:4000/key/info" -H "Authorization: Bearer sk-test-example-key-123"<br/>
        /// ```
        /// </summary>
        /// <param name="key">
        /// Key to look up. Pass the key's sha256 hash so the raw key stays out of URLs and access logs. Example key='d5345c0ecc68ae6295c69f91926b2bd379e25481a40c34b5884d157a9f65d8fa'
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> InfoKeyFnKeyInfoGetAsResponseAsync(
            string? key = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}