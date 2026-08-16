#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Create Model Group<br/>
        /// Create a new access group containing multiple model names.<br/>
        /// An access group is a named collection of model groups that can be referenced<br/>
        /// by teams/keys for simplified access control.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST 'http://localhost:4000/access_group/new' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "access_group": "production-models",<br/>
        ///     "model_names": ["gpt-4", "claude-3-opus", "gemini-pro"]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (e.g., "production-models")<br/>
        /// - model_names: List[str] - List of existing model groups to include<br/>
        /// Returns:<br/>
        /// - NewModelGroupResponse with the created access group details<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If any model names don't exist<br/>
        /// - HTTPException 500: If database operations fail
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewModelGroupResponse> CreateModelGroupAccessGroupNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewModelGroupRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Model Group<br/>
        /// Create a new access group containing multiple model names.<br/>
        /// An access group is a named collection of model groups that can be referenced<br/>
        /// by teams/keys for simplified access control.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST 'http://localhost:4000/access_group/new' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "access_group": "production-models",<br/>
        ///     "model_names": ["gpt-4", "claude-3-opus", "gemini-pro"]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (e.g., "production-models")<br/>
        /// - model_names: List[str] - List of existing model groups to include<br/>
        /// Returns:<br/>
        /// - NewModelGroupResponse with the created access group details<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If any model names don't exist<br/>
        /// - HTTPException 500: If database operations fail
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.NewModelGroupResponse>> CreateModelGroupAccessGroupNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewModelGroupRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Model Group<br/>
        /// Create a new access group containing multiple model names.<br/>
        /// An access group is a named collection of model groups that can be referenced<br/>
        /// by teams/keys for simplified access control.<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X POST 'http://localhost:4000/access_group/new' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "access_group": "production-models",<br/>
        ///     "model_names": ["gpt-4", "claude-3-opus", "gemini-pro"]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (e.g., "production-models")<br/>
        /// - model_names: List[str] - List of existing model groups to include<br/>
        /// Returns:<br/>
        /// - NewModelGroupResponse with the created access group details<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If any model names don't exist<br/>
        /// - HTTPException 500: If database operations fail
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="modelNames"></param>
        /// <param name="modelIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewModelGroupResponse> CreateModelGroupAccessGroupNewPostAsync(
            string accessGroup,
            global::System.Collections.Generic.IList<string>? modelNames = default,
            global::System.Collections.Generic.IList<string>? modelIds = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}