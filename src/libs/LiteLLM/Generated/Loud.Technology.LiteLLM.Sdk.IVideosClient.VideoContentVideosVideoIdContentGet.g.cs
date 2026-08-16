#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Video Content<br/>
        /// Video content endpoint for downloading video content.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v1/videos/{video_id}/content"         -H "Authorization: Bearer sk-1234"         --output video.mp4<br/>
        /// ```
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task VideoContentVideosVideoIdContentGetAsync(
            string videoId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Content<br/>
        /// Video content endpoint for downloading video content.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X GET "http://localhost:4000/v1/videos/{video_id}/content"         -H "Authorization: Bearer sk-1234"         --output video.mp4<br/>
        /// ```
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse> VideoContentVideosVideoIdContentGetAsResponseAsync(
            string videoId,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}