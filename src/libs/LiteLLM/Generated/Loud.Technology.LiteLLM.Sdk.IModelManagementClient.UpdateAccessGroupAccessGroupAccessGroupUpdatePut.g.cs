#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IModelManagementClient
    {
        /// <summary>
        /// Update Access Group<br/>
        /// Update an access group's model names.<br/>
        /// This will:<br/>
        /// 1. Remove the access group from all current deployments<br/>
        /// 2. Add the access group to all deployments for the new model_names list<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X PUT 'http://localhost:4000/access_group/production-models/update' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "model_names": ["gpt-4", "claude-3-sonnet"]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// - model_names: List[str] - New list of model groups to include<br/>
        /// Returns:<br/>
        /// - NewModelGroupResponse with the updated access group details<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If any model names don't exist<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewModelGroupResponse> UpdateAccessGroupAccessGroupAccessGroupUpdatePutAsync(
            string accessGroup,

            global::Loud.Technology.LiteLLM.Sdk.UpdateModelGroupRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Access Group<br/>
        /// Update an access group's model names.<br/>
        /// This will:<br/>
        /// 1. Remove the access group from all current deployments<br/>
        /// 2. Add the access group to all deployments for the new model_names list<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X PUT 'http://localhost:4000/access_group/production-models/update' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "model_names": ["gpt-4", "claude-3-sonnet"]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// - model_names: List[str] - New list of model groups to include<br/>
        /// Returns:<br/>
        /// - NewModelGroupResponse with the updated access group details<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If any model names don't exist<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.NewModelGroupResponse>> UpdateAccessGroupAccessGroupAccessGroupUpdatePutAsResponseAsync(
            string accessGroup,

            global::Loud.Technology.LiteLLM.Sdk.UpdateModelGroupRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Access Group<br/>
        /// Update an access group's model names.<br/>
        /// This will:<br/>
        /// 1. Remove the access group from all current deployments<br/>
        /// 2. Add the access group to all deployments for the new model_names list<br/>
        /// Example:<br/>
        /// ```bash<br/>
        /// curl -X PUT 'http://localhost:4000/access_group/production-models/update' \<br/>
        ///   -H 'Authorization: Bearer sk-1234' \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{<br/>
        ///     "model_names": ["gpt-4", "claude-3-sonnet"]<br/>
        ///   }'<br/>
        /// ```<br/>
        /// Parameters:<br/>
        /// - access_group: str - The access group name (URL path parameter)<br/>
        /// - model_names: List[str] - New list of model groups to include<br/>
        /// Returns:<br/>
        /// - NewModelGroupResponse with the updated access group details<br/>
        /// Raises:<br/>
        /// - HTTPException 400: If any model names don't exist<br/>
        /// - HTTPException 404: If access group not found
        /// </summary>
        /// <param name="accessGroup"></param>
        /// <param name="modelNames"></param>
        /// <param name="modelIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.NewModelGroupResponse> UpdateAccessGroupAccessGroupAccessGroupUpdatePutAsync(
            string accessGroup,
            global::System.Collections.Generic.IList<string>? modelNames = default,
            global::System.Collections.Generic.IList<string>? modelIds = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}