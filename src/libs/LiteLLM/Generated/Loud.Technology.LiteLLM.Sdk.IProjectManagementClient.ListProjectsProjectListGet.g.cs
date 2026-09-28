#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IProjectManagementClient
    {
        /// <summary>
        /// List Projects<br/>
        /// List all projects that the user has access to<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/list' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable>> ListProjectsProjectListGetAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Projects<br/>
        /// List all projects that the user has access to<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl --location 'http://0.0.0.0:4000/project/list' \<br/>
        /// --header 'Authorization: Bearer sk-1234'<br/>
        /// ```
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMProjectTable>>> ListProjectsProjectListGetAsResponseAsync(
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}