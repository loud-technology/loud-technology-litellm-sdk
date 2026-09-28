#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Image Edit Api<br/>
        /// Follows the OpenAI Images API spec: https://platform.openai.com/docs/api-reference/images/create<br/>
        /// ```bash<br/>
        /// curl -s -D &gt;(grep -i x-request-id &gt;&amp;2)     -o &gt;(jq -r '.data[0].b64_json' | base64 --decode &gt; gift-basket.png)     -X POST "http://localhost:4000/v1/images/edits"     -H "Authorization: Bearer sk-1234"         -F "model=gpt-image-1"         -F "image[]=@soap.png"         -F 'prompt=Create a studio ghibli image of this'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ImageEditApiImagesEditsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyImageEditApiImagesEditsPost request,
            string? model = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Edit Api<br/>
        /// Follows the OpenAI Images API spec: https://platform.openai.com/docs/api-reference/images/create<br/>
        /// ```bash<br/>
        /// curl -s -D &gt;(grep -i x-request-id &gt;&amp;2)     -o &gt;(jq -r '.data[0].b64_json' | base64 --decode &gt; gift-basket.png)     -X POST "http://localhost:4000/v1/images/edits"     -H "Authorization: Bearer sk-1234"         -F "model=gpt-image-1"         -F "image[]=@soap.png"         -F 'prompt=Create a studio ghibli image of this'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ImageEditApiImagesEditsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyImageEditApiImagesEditsPost request,
            string? model = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Image Edit Api<br/>
        /// Follows the OpenAI Images API spec: https://platform.openai.com/docs/api-reference/images/create<br/>
        /// ```bash<br/>
        /// curl -s -D &gt;(grep -i x-request-id &gt;&amp;2)     -o &gt;(jq -r '.data[0].b64_json' | base64 --decode &gt; gift-basket.png)     -X POST "http://localhost:4000/v1/images/edits"     -H "Authorization: Bearer sk-1234"         -F "model=gpt-image-1"         -F "image[]=@soap.png"         -F 'prompt=Create a studio ghibli image of this'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="image"></param>
        /// <param name="image2"></param>
        /// <param name="mask"></param>
        /// <param name="mask2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ImageEditApiImagesEditsPostAsync(
            string? model = default,
            global::System.Collections.Generic.IList<byte[]>? image = default,
            global::System.Collections.Generic.IList<byte[]>? image2 = default,
            global::System.Collections.Generic.IList<byte[]>? mask = default,
            global::System.Collections.Generic.IList<byte[]>? mask2 = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}