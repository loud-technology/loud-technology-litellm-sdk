#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Validate Blocked Words File<br/>
        /// Validate a blocked_words YAML file content.<br/>
        /// Args:<br/>
        ///     request: Dictionary with 'file_content' key containing the YAML string<br/>
        /// Returns:<br/>
        ///     Dictionary with 'valid' boolean and either 'message'/'errors' depending on result<br/>
        /// Example Request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "file_content": "blocked_words:\n  - keyword: \"test\"\n    action: \"BLOCK\""<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "valid": true,<br/>
        ///     "message": "Valid YAML file with 2 blocked words"<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Error Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "valid": false,<br/>
        ///     "errors": ["Entry 0: missing 'action' field"]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ValidateBlockedWordsFileGuardrailsValidateBlockedWordsFilePostAsync(

            global::System.Collections.Generic.Dictionary<string, string> request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Blocked Words File<br/>
        /// Validate a blocked_words YAML file content.<br/>
        /// Args:<br/>
        ///     request: Dictionary with 'file_content' key containing the YAML string<br/>
        /// Returns:<br/>
        ///     Dictionary with 'valid' boolean and either 'message'/'errors' depending on result<br/>
        /// Example Request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "file_content": "blocked_words:\n  - keyword: \"test\"\n    action: \"BLOCK\""<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "valid": true,<br/>
        ///     "message": "Valid YAML file with 2 blocked words"<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Error Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "valid": false,<br/>
        ///     "errors": ["Entry 0: missing 'action' field"]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> ValidateBlockedWordsFileGuardrailsValidateBlockedWordsFilePostAsResponseAsync(

            global::System.Collections.Generic.Dictionary<string, string> request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Blocked Words File<br/>
        /// Validate a blocked_words YAML file content.<br/>
        /// Args:<br/>
        ///     request: Dictionary with 'file_content' key containing the YAML string<br/>
        /// Returns:<br/>
        ///     Dictionary with 'valid' boolean and either 'message'/'errors' depending on result<br/>
        /// Example Request:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "file_content": "blocked_words:\n  - keyword: \"test\"\n    action: \"BLOCK\""<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Success Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "valid": true,<br/>
        ///     "message": "Valid YAML file with 2 blocked words"<br/>
        /// }<br/>
        /// ```<br/>
        /// Example Error Response:<br/>
        /// ```json<br/>
        /// {<br/>
        ///     "valid": false,<br/>
        ///     "errors": ["Entry 0: missing 'action' field"]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ValidateBlockedWordsFileGuardrailsValidateBlockedWordsFilePostAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}