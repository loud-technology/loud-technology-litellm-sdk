#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Video Remix<br/>
        /// Video remix endpoint for remixing existing videos with new prompts.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/video_123/remix"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "prompt": "A new version with different colors"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VideoRemixVideosVideoIdRemixPostAsync(
            string videoId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Remix<br/>
        /// Video remix endpoint for remixing existing videos with new prompts.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos/video_123/remix"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "prompt": "A new version with different colors"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VideoRemixVideosVideoIdRemixPostAsResponseAsync(
            string videoId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}