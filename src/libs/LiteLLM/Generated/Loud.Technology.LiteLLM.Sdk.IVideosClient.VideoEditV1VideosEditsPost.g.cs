#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Video Edit<br/>
        /// Create a video edit job.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos/create-edit<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/edits"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{"prompt": "Make it brighter", "video": {"id": "video_123"}}'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VideoEditV1VideosEditsPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Edit<br/>
        /// Create a video edit job.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos/create-edit<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/edits"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{"prompt": "Make it brighter", "video": {"id": "video_123"}}'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VideoEditV1VideosEditsPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}