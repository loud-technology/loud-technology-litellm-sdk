#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IGuardrailsClient
    {
        /// <summary>
        /// Get Category Yaml<br/>
        /// Get the YAML or JSON content for a specific content filter category.<br/>
        /// Args:<br/>
        ///     category_name: The name of the category (e.g., "bias_gender", "harmful_self_harm")<br/>
        /// Returns:<br/>
        ///     The raw YAML or JSON content of the category file with file type indicator
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetCategoryYamlGuardrailsUiCategoryYamlCategoryNameGetAsync(
            string categoryName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Category Yaml<br/>
        /// Get the YAML or JSON content for a specific content filter category.<br/>
        /// Args:<br/>
        ///     category_name: The name of the category (e.g., "bias_gender", "harmful_self_harm")<br/>
        /// Returns:<br/>
        ///     The raw YAML or JSON content of the category file with file type indicator
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> GetCategoryYamlGuardrailsUiCategoryYamlCategoryNameGetAsResponseAsync(
            string categoryName,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}