#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IKeyManagementClient
    {
        /// <summary>
        /// Key Aliases<br/>
        /// Lists key aliases with pagination and optional search.<br/>
        /// Non-admin users only see aliases for keys they own or keys belonging to<br/>
        /// their teams.<br/>
        /// Returns:<br/>
        ///     {<br/>
        ///         "aliases": List[str],<br/>
        ///         "total_count": int,<br/>
        ///         "current_page": int,<br/>
        ///         "total_pages": int,<br/>
        ///         "size": int,<br/>
        ///     }
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Search key aliases (case-insensitive partial match)
        /// </param>
        /// <param name="teamId">
        /// Filter aliases to keys belonging to this team
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> KeyAliasesKeyAliasesGetAsync(
            int? page = default,
            int? size = default,
            string? search = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Key Aliases<br/>
        /// Lists key aliases with pagination and optional search.<br/>
        /// Non-admin users only see aliases for keys they own or keys belonging to<br/>
        /// their teams.<br/>
        /// Returns:<br/>
        ///     {<br/>
        ///         "aliases": List[str],<br/>
        ///         "total_count": int,<br/>
        ///         "current_page": int,<br/>
        ///         "total_pages": int,<br/>
        ///         "size": int,<br/>
        ///     }
        /// </summary>
        /// <param name="page">
        /// Page number<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Page size<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="search">
        /// Search key aliases (case-insensitive partial match)
        /// </param>
        /// <param name="teamId">
        /// Filter aliases to keys belonging to this team
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> KeyAliasesKeyAliasesGetAsResponseAsync(
            int? page = default,
            int? size = default,
            string? search = default,
            string? teamId = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}