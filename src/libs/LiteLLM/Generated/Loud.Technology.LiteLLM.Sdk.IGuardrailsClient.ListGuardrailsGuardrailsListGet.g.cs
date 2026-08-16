#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// List Guardrails<br/>
        /// List the guardrails that are available on the proxy server<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/guardrails/list" -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrails": [<br/>
        ///         {<br/>
        ///         "guardrail_name": "bedrock-pre-guard",<br/>
        ///         "guardrail_info": {<br/>
        ///             "params": [<br/>
        ///             {<br/>
        ///                 "name": "toxicity_score",<br/>
        ///                 "type": "float",<br/>
        ///                 "description": "Score between 0-1 indicating content toxicity level"<br/>
        ///             },<br/>
        ///             {<br/>
        ///                 "name": "pii_detection",<br/>
        ///                 "type": "boolean"<br/>
        ///             }<br/>
        ///             ]<br/>
        ///         }<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.ListGuardrailsResponse> ListGuardrailsGuardrailsListGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Guardrails<br/>
        /// List the guardrails that are available on the proxy server<br/>
        /// 👉 [Guardrail docs](https://docs.litellm.ai/docs/proxy/guardrails/quick_start)<br/>
        /// Example Request:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/guardrails/list" -H "Authorization: Bearer &lt;your_api_key&gt;"<br/>
        /// ```<br/>
        /// Example Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "guardrails": [<br/>
        ///         {<br/>
        ///         "guardrail_name": "bedrock-pre-guard",<br/>
        ///         "guardrail_info": {<br/>
        ///             "params": [<br/>
        ///             {<br/>
        ///                 "name": "toxicity_score",<br/>
        ///                 "type": "float",<br/>
        ///                 "description": "Score between 0-1 indicating content toxicity level"<br/>
        ///             },<br/>
        ///             {<br/>
        ///                 "name": "pii_detection",<br/>
        ///                 "type": "boolean"<br/>
        ///             }<br/>
        ///             ]<br/>
        ///         }<br/>
        ///         }<br/>
        ///     ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.ListGuardrailsResponse>> ListGuardrailsGuardrailsListGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}