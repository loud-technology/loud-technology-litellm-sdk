#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IAutoRouterClient
    {
        /// <summary>
        /// List Shadow Eval Jobs<br/>
        /// List shadow eval jobs, newest first, each target with its attempt count so status<br/>
        /// is accurate. Judged counts, spend, and results ride the detail endpoint only.
        /// </summary>
        /// <param name="targetType">
        /// Kind of target to filter on; requires target_id
        /// </param>
        /// <param name="targetId">
        /// Filter to jobs that shadow this target, alone or alongside others
        /// </param>
        /// <param name="limit">
        /// Newest jobs to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse>> ListShadowEvalJobsAutoRouterShadowEvalGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2? targetType = default,
            string? targetId = default,
            int? limit = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Shadow Eval Jobs<br/>
        /// List shadow eval jobs, newest first, each target with its attempt count so status<br/>
        /// is accurate. Judged counts, spend, and results ride the detail endpoint only.
        /// </summary>
        /// <param name="targetType">
        /// Kind of target to filter on; requires target_id
        /// </param>
        /// <param name="targetId">
        /// Filter to jobs that shadow this target, alone or alongside others
        /// </param>
        /// <param name="limit">
        /// Newest jobs to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponse>>> ListShadowEvalJobsAutoRouterShadowEvalGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.ListShadowEvalJobsAutoRouterShadowEvalGetTargetType2? targetType = default,
            string? targetId = default,
            int? limit = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}