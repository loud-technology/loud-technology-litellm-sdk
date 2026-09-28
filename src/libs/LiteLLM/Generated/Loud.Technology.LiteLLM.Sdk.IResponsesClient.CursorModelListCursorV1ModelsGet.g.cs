#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Cursor Model List<br/>
        /// OpenAI-compatible model listing for the Cursor BYOK base URL.<br/>
        /// Clients pointed at `&lt;proxy&gt;/cursor` as an OpenAI-compatible base URL resolve and<br/>
        /// verify models via `GET {base}/models` (the OpenAI SDK contract). Without this<br/>
        /// route those requests fall through to the Cursor Cloud Agents passthrough, which<br/>
        /// demands a Cursor API key and 401s, so key verification silently fails before any<br/>
        /// chat request is ever sent. Delegates to the standard `/v1/models` handler.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CursorModelListCursorV1ModelsGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cursor Model List<br/>
        /// OpenAI-compatible model listing for the Cursor BYOK base URL.<br/>
        /// Clients pointed at `&lt;proxy&gt;/cursor` as an OpenAI-compatible base URL resolve and<br/>
        /// verify models via `GET {base}/models` (the OpenAI SDK contract). Without this<br/>
        /// route those requests fall through to the Cursor Cloud Agents passthrough, which<br/>
        /// demands a Cursor API key and 401s, so key verification silently fails before any<br/>
        /// chat request is ever sent. Delegates to the standard `/v1/models` handler.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CursorModelListCursorV1ModelsGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}