#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Create Guardrail<br/>
        /// Create a new guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/guardrails" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail": {<br/>
        ///             "guardrail_name": "my-bedrock-guard",<br/>
        ///             "litellm_params": {<br/>
        ///                 "guardrail": "bedrock",<br/>
        ///                 "mode": "pre_call",<br/>
        ///                 "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///                 "guardrailVersion": "DRAFT",<br/>
        ///                 "default_on": true<br/>
        ///             },<br/>
        ///             "guardrail_info": {<br/>
        ///                 "description": "Bedrock content moderation guardrail"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "my-bedrock-guard",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "DRAFT",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Bedrock content moderation guardrail"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGuardrailGuardrailsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.CreateGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Guardrail<br/>
        /// Create a new guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/guardrails" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail": {<br/>
        ///             "guardrail_name": "my-bedrock-guard",<br/>
        ///             "litellm_params": {<br/>
        ///                 "guardrail": "bedrock",<br/>
        ///                 "mode": "pre_call",<br/>
        ///                 "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///                 "guardrailVersion": "DRAFT",<br/>
        ///                 "default_on": true<br/>
        ///             },<br/>
        ///             "guardrail_info": {<br/>
        ///                 "description": "Bedrock content moderation guardrail"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "my-bedrock-guard",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "DRAFT",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Bedrock content moderation guardrail"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateGuardrailGuardrailsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.CreateGuardrailRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Guardrail<br/>
        /// Create a new guardrail<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/guardrails" \<br/>
        ///     -H "Authorization: Bearer &lt;your_api_key&gt;" \<br/>
        ///     -H "Content-Type: application/json" \<br/>
        ///     -d '{<br/>
        ///         "guardrail": {<br/>
        ///             "guardrail_name": "my-bedrock-guard",<br/>
        ///             "litellm_params": {<br/>
        ///                 "guardrail": "bedrock",<br/>
        ///                 "mode": "pre_call",<br/>
        ///                 "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///                 "guardrailVersion": "DRAFT",<br/>
        ///                 "default_on": true<br/>
        ///             },<br/>
        ///             "guardrail_info": {<br/>
        ///                 "description": "Bedrock content moderation guardrail"<br/>
        ///             }<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrail_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
        ///     "guardrail_name": "my-bedrock-guard",<br/>
        ///     "litellm_params": {<br/>
        ///         "guardrail": "bedrock",<br/>
        ///         "mode": "pre_call",<br/>
        ///         "guardrailIdentifier": "ff6ujrregl1q",<br/>
        ///         "guardrailVersion": "DRAFT",<br/>
        ///         "default_on": true<br/>
        ///     },<br/>
        ///     "guardrail_info": {<br/>
        ///         "description": "Bedrock content moderation guardrail"<br/>
        ///     },<br/>
        ///     "created_at": "2023-11-09T12:34:56.789Z",<br/>
        ///     "updated_at": "2023-11-09T12:34:56.789Z"<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="guardrail"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateGuardrailGuardrailsPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.Guardrail guardrail,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}