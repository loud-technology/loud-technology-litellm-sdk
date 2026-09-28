#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// Convert Prompt File To Json<br/>
        /// Convert a .prompt file to JSON format.<br/>
        /// This endpoint accepts a .prompt file upload and returns the equivalent JSON representation<br/>
        /// that can be stored in a database or used programmatically.<br/>
        /// Returns the JSON structure with 'content' and 'metadata' fields.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConvertPromptFileToJsonUtilsDotpromptJsonConverterPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyConvertPromptFileToJsonUtilsDotpromptJsonConverterPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Prompt File To Json<br/>
        /// Convert a .prompt file to JSON format.<br/>
        /// This endpoint accepts a .prompt file upload and returns the equivalent JSON representation<br/>
        /// that can be stored in a database or used programmatically.<br/>
        /// Returns the JSON structure with 'content' and 'metadata' fields.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ConvertPromptFileToJsonUtilsDotpromptJsonConverterPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.BodyConvertPromptFileToJsonUtilsDotpromptJsonConverterPost request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Prompt File To Json<br/>
        /// Convert a .prompt file to JSON format.<br/>
        /// This endpoint accepts a .prompt file upload and returns the equivalent JSON representation<br/>
        /// that can be stored in a database or used programmatically.<br/>
        /// Returns the JSON structure with 'content' and 'metadata' fields.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConvertPromptFileToJsonUtilsDotpromptJsonConverterPostAsync(
            byte[] file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Convert Prompt File To Json<br/>
        /// Convert a .prompt file to JSON format.<br/>
        /// This endpoint accepts a .prompt file upload and returns the equivalent JSON representation<br/>
        /// that can be stored in a database or used programmatically.<br/>
        /// Returns the JSON structure with 'content' and 'metadata' fields.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConvertPromptFileToJsonUtilsDotpromptJsonConverterPostAsync(
            global::System.IO.Stream file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert Prompt File To Json<br/>
        /// Convert a .prompt file to JSON format.<br/>
        /// This endpoint accepts a .prompt file upload and returns the equivalent JSON representation<br/>
        /// that can be stored in a database or used programmatically.<br/>
        /// Returns the JSON structure with 'content' and 'metadata' fields.
        /// </summary>
        /// <param name="file">
        /// The stream to send as the multipart 'file' file part.
        /// </param>
        /// <param name="filename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ConvertPromptFileToJsonUtilsDotpromptJsonConverterPostAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}