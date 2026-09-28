#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Register Guardrail<br/>
        /// Register a guardrail for onboarding (team submission).<br/>
        /// Accepts a guardrail config in the<br/>
        /// [Generic Guardrail API](https://docs.litellm.ai/docs/adding_provider/generic_guardrail_api) format.<br/>
        /// The submission is stored with status `pending_review` until an admin approves it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RegisterGuardrailResponse> RegisterGuardrailGuardrailsRegisterPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.RegisterGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register Guardrail<br/>
        /// Register a guardrail for onboarding (team submission).<br/>
        /// Accepts a guardrail config in the<br/>
        /// [Generic Guardrail API](https://docs.litellm.ai/docs/adding_provider/generic_guardrail_api) format.<br/>
        /// The submission is stored with status `pending_review` until an admin approves it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.RegisterGuardrailResponse>> RegisterGuardrailGuardrailsRegisterPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.RegisterGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Register Guardrail<br/>
        /// Register a guardrail for onboarding (team submission).<br/>
        /// Accepts a guardrail config in the<br/>
        /// [Generic Guardrail API](https://docs.litellm.ai/docs/adding_provider/generic_guardrail_api) format.<br/>
        /// The submission is stored with status `pending_review` until an admin approves it.
        /// </summary>
        /// <param name="guardrailInfo"></param>
        /// <param name="guardrailName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.RegisterGuardrailResponse> RegisterGuardrailGuardrailsRegisterPostAsync(
            string guardrailName,
            object litellmParams,
            object? guardrailInfo = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}