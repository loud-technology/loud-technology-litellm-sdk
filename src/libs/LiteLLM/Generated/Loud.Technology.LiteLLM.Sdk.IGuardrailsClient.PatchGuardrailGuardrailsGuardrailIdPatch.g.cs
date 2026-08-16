#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Patch Guardrail<br/>
        /// Partially update an existing guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// This endpoint allows updating specific fields of a guardrail without sending the entire object.<br/>
        /// Only the following fields can be updated:<br/>
        /// - guardrail_name: The name of the guardrail<br/>
        /// - default_on: Whether the guardrail is enabled by default<br/>
        /// - guardrail_info: Additional information about the guardrail<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PATCH "http://localhost:4000/guardrails/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail_name": "updated-name",<br/>
        ///         "default_on": true,<br/>
        ///         "guardrail_info": {<br/>
        ///             "description": "Updated description"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "updated-name",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "DRAFT",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Updated description"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T14:22:33.456Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PatchGuardrailGuardrailsGuardrailIdPatchAsync(
            string guardrailId,

            global::Loud.Technology.LiteLLM.Sdk.PatchGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Guardrail<br/>
        /// Partially update an existing guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// This endpoint allows updating specific fields of a guardrail without sending the entire object.<br/>
        /// Only the following fields can be updated:<br/>
        /// - guardrail_name: The name of the guardrail<br/>
        /// - default_on: Whether the guardrail is enabled by default<br/>
        /// - guardrail_info: Additional information about the guardrail<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PATCH "http://localhost:4000/guardrails/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail_name": "updated-name",<br/>
        ///         "default_on": true,<br/>
        ///         "guardrail_info": {<br/>
        ///             "description": "Updated description"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "updated-name",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "DRAFT",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Updated description"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T14:22:33.456Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> PatchGuardrailGuardrailsGuardrailIdPatchAsResponseAsync(
            string guardrailId,

            global::Loud.Technology.LiteLLM.Sdk.PatchGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Guardrail<br/>
        /// Partially update an existing guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// This endpoint allows updating specific fields of a guardrail without sending the entire object.<br/>
        /// Only the following fields can be updated:<br/>
        /// - guardrail_name: The name of the guardrail<br/>
        /// - default_on: Whether the guardrail is enabled by default<br/>
        /// - guardrail_info: Additional information about the guardrail<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PATCH "http://localhost:4000/guardrails/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail_name": "updated-name",<br/>
        ///         "default_on": true,<br/>
        ///         "guardrail_info": {<br/>
        ///             "description": "Updated description"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "updated-name",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "DRAFT",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Updated description"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T14:22:33.456Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="guardrailInfo"></param>
        /// <param name="guardrailName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PatchGuardrailGuardrailsGuardrailIdPatchAsync(
            string guardrailId,
            object? guardrailInfo = default,
            string? guardrailName = default,
            global::Loud.Technology.LiteLLM.Sdk.BaseLitellmParamsInput? litellmParams = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}