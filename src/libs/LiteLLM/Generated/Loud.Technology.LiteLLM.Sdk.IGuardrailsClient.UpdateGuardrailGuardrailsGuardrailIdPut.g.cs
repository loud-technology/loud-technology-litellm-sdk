#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Update Guardrail<br/>
        /// Update an existing guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/guardrails/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail": {<br/>
        ///             "guardrail_name": "updated-bedrock-guard",<br/>
        ///             "litellm_params": {<br/>
        ///                 "guardrail": "bedrock",<br/>
        ///                 "mode": "pre_call",<br/>
        ///                 "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///                 "guardrailVersion": "1.0",<br/>
        ///                 "default_on": true<br/>
        ///             },<br/>
        ///             "guardrail_info": {<br/>
        ///                 "description": "Updated Bedrock content moderation guardrail"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "updated-bedrock-guard",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "1.0",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Updated Bedrock content moderation guardrail"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T13:45:12.345Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateGuardrailGuardrailsGuardrailIdPutAsync(
            string guardrailId,

            global::Loud.Technology.LiteLLM.Sdk.UpdateGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Guardrail<br/>
        /// Update an existing guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/guardrails/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail": {<br/>
        ///             "guardrail_name": "updated-bedrock-guard",<br/>
        ///             "litellm_params": {<br/>
        ///                 "guardrail": "bedrock",<br/>
        ///                 "mode": "pre_call",<br/>
        ///                 "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///                 "guardrailVersion": "1.0",<br/>
        ///                 "default_on": true<br/>
        ///             },<br/>
        ///             "guardrail_info": {<br/>
        ///                 "description": "Updated Bedrock content moderation guardrail"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "updated-bedrock-guard",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "1.0",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Updated Bedrock content moderation guardrail"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T13:45:12.345Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> UpdateGuardrailGuardrailsGuardrailIdPutAsResponseAsync(
            string guardrailId,

            global::Loud.Technology.LiteLLM.Sdk.UpdateGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Guardrail<br/>
        /// Update an existing guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X PUT "http://localhost:4000/guardrails/123e4567-e89b-12d3-a456-426614174000" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail": {<br/>
        ///             "guardrail_name": "updated-bedrock-guard",<br/>
        ///             "litellm_params": {<br/>
        ///                 "guardrail": "bedrock",<br/>
        ///                 "mode": "pre_call",<br/>
        ///                 "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///                 "guardrailVersion": "1.0",<br/>
        ///                 "default_on": true<br/>
        ///             },<br/>
        ///             "guardrail_info": {<br/>
        ///                 "description": "Updated Bedrock content moderation guardrail"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "updated-bedrock-guard",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "1.0",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Updated Bedrock content moderation guardrail"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T13:45:12.345Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="guardrail"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateGuardrailGuardrailsGuardrailIdPutAsync(
            string guardrailId,
            global::Loud.Technology.LiteLLM.Sdk.Guardrail guardrail,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}