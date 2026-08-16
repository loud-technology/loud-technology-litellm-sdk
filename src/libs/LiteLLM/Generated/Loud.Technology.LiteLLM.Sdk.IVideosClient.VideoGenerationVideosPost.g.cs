#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Video Generation<br/>
        /// Video generation endpoint for creating videos from text prompts.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "model": "sora-2",<br/>
        ///         "prompt": "A beautiful sunset over the ocean"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> VideoGenerationVideosPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyVideoGenerationVideosPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Generation<br/>
        /// Video generation endpoint for creating videos from text prompts.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "model": "sora-2",<br/>
        ///         "prompt": "A beautiful sunset over the ocean"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> VideoGenerationVideosPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyVideoGenerationVideosPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Video Generation<br/>
        /// Video generation endpoint for creating videos from text prompts.<br/>
        /// Follows the OpenAI Videos API spec:<br/>
        /// https://platform.openai.com/docs/api-reference/videos<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/videos"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "model": "sora-2",<br/>
        ///         "prompt": "A beautiful sunset over the ocean"<br/>
        ///     }'<br/>
        /// ```
        /// </summary>
        /// <param name="inputReference"></param>
        /// <param name="inputReferencename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> VideoGenerationVideosPostAsync(
            byte[]? inputReference = default,
            string? inputReferencename = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}