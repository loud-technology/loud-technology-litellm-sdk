#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Apply Guardrail<br/>
        /// Apply a guardrail to text input and return the processed result.<br/>
        /// This endpoint allows testing guardrails by applying them to custom text inputs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ApplyGuardrailResponse> ApplyGuardrailGuardrailsApplyGuardrailPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.ApplyGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply Guardrail<br/>
        /// Apply a guardrail to text input and return the processed result.<br/>
        /// This endpoint allows testing guardrails by applying them to custom text inputs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ApplyGuardrailResponse>> ApplyGuardrailGuardrailsApplyGuardrailPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.ApplyGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Apply Guardrail<br/>
        /// Apply a guardrail to text input and return the processed result.<br/>
        /// This endpoint allows testing guardrails by applying them to custom text inputs.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="guardrailName"></param>
        /// <param name="inputType">
        /// Default Value: request
        /// </param>
        /// <param name="language"></param>
        /// <param name="messages"></param>
        /// <param name="metadata"></param>
        /// <param name="text"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ApplyGuardrailResponse> ApplyGuardrailGuardrailsApplyGuardrailPostAsync(
            string guardrailName,
            string text,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PiiEntityType>? entities = default,
            string? inputType = default,
            string? language = default,
            global::System.Collections.Generic.IList<object>? messages = default,
            object? metadata = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}