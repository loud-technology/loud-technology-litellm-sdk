#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IOcrClient
    {
        /// <summary>
        /// Ocr<br/>
        /// OCR endpoint for extracting text from documents and images.<br/>
        /// Supports two input modes:<br/>
        /// **1. JSON body** (Mistral OCR API compatible):<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/ocr"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "model": "mistral-ocr",<br/>
        ///         "document": {<br/>
        ///             "type": "document_url",<br/>
        ///             "document_url": "https://arxiv.org/pdf/2201.04234"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// **2. Multipart form file upload**:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/ocr"         -H "Authorization: Bearer sk-1234"         -F "model=mistral-ocr"         -F "file=@document.pdf"<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OcrV1OcrPostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Ocr<br/>
        /// OCR endpoint for extracting text from documents and images.<br/>
        /// Supports two input modes:<br/>
        /// **1. JSON body** (Mistral OCR API compatible):<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/ocr"         -H "Authorization: Bearer sk-1234"         -H "Content-Type: application/json"         -d '{<br/>
        ///         "model": "mistral-ocr",<br/>
        ///         "document": {<br/>
        ///             "type": "document_url",<br/>
        ///             "document_url": "https://arxiv.org/pdf/2201.04234"<br/>
        ///         }<br/>
        ///     }'<br/>
        /// ```<br/>
        /// **2. Multipart form file upload**:<br/>
        /// ```bash<br/>
        /// curl -X POST "http://localhost:4000/v1/ocr"         -H "Authorization: Bearer sk-1234"         -F "model=mistral-ocr"         -F "file=@document.pdf"<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> OcrV1OcrPostAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}