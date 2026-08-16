#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IBudgetSpendTrackingClient
    {
        /// <summary>
        /// Global Spend Reset<br/>
        /// ADMIN ONLY / MASTER KEY Only Endpoint<br/>
        /// Globally reset spend for All API Keys and Teams, maintain LiteLLM_SpendLogs<br/>
        /// 1. LiteLLM_SpendLogs will maintain the logs on spend, no data gets deleted from there<br/>
        /// 2. LiteLLM_VerificationTokens spend will be set = 0<br/>
        /// 3. LiteLLM_TeamTable spend will be set = 0
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GlobalSpendResetGlobalSpendResetPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Global Spend Reset<br/>
        /// ADMIN ONLY / MASTER KEY Only Endpoint<br/>
        /// Globally reset spend for All API Keys and Teams, maintain LiteLLM_SpendLogs<br/>
        /// 1. LiteLLM_SpendLogs will maintain the logs on spend, no data gets deleted from there<br/>
        /// 2. LiteLLM_VerificationTokens spend will be set = 0<br/>
        /// 3. LiteLLM_TeamTable spend will be set = 0
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GlobalSpendResetGlobalSpendResetPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}