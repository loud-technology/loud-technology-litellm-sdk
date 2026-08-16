#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ICustomerManagementClient
    {
        /// <summary>
        /// New End User<br/>
        /// Allow creating a new Customer <br/>
        /// Parameters:<br/>
        /// - user_id: str - The unique identifier for the user.<br/>
        /// - alias: Optional[str] - A human-friendly alias for the user.<br/>
        /// - blocked: bool - Flag to allow or disallow requests for this end-user. Default is False.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the user. Either 'max_budget' or 'budget_id' should be provided, not both.<br/>
        /// - budget_id: Optional[str] - The identifier for an existing budget allocated to the user. Either 'max_budget' or 'budget_id' should be provided, not both.<br/>
        /// - allowed_model_region: Optional[Union[Literal["eu"], Literal["us"]]] - Require all user requests to use models in this specific region.<br/>
        /// - default_model: Optional[str] - If no equivalent model in the allowed region, default all requests to this model.<br/>
        /// - metadata: Optional[dict] = Metadata for customer, store information for customer. Example metadata = {"data_training_opt_out": True}<br/>
        /// - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - tpm_limit: Optional[int] - [Not Implemented Yet] Specify tpm limit for a given customer (Tokens per minute)<br/>
        /// - rpm_limit: Optional[int] - [Not Implemented Yet] Specify rpm limit for a given customer (Requests per minute)<br/>
        /// - model_max_budget: Optional[dict] - [Not Implemented Yet] Specify max budget for a given model. Example: {"openai/gpt-4o-mini": {"max_budget": 100.0, "budget_duration": "1d"}}<br/>
        /// - max_parallel_requests: Optional[int] - [Not Implemented Yet] Specify max parallel requests for a given customer.<br/>
        /// - soft_budget: Optional[float] - [Not Implemented Yet] Get alerts when customer crosses given budget, doesn't block requests.<br/>
        /// - spend: Optional[float] - Specify initial spend for a given customer.<br/>
        /// - budget_reset_at: Optional[str] - Specify the date and time when the budget should be reset.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Customer-specific object permissions to control access to resources.<br/>
        ///     Supported fields:<br/>
        ///     * mcp_servers: List[str] - List of allowed MCP server IDs<br/>
        ///     * mcp_access_groups: List[str] - List of MCP access group names<br/>
        ///     * mcp_tool_permissions: Dict[str, List[str]] - Map of server ID to allowed tool names (e.g., {"server_1": ["tool_a", "tool_b"]})<br/>
        ///     * vector_stores: List[str] - List of allowed vector store IDs<br/>
        ///     * agents: List[str] - List of allowed agent IDs<br/>
        ///     * agent_access_groups: List[str] - List of agent access group names<br/>
        ///     Example: {"mcp_servers": ["server_1", "server_2"], "vector_stores": ["vector_store_1"], "agents": ["agent_1"]}<br/>
        ///     IF null or {} then no object-level restrictions apply.<br/>
        /// - Allow specifying allowed regions <br/>
        /// - Allow specifying default model<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/new'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "user_id" : "ishaan-jaff-3",<br/>
        ///         "allowed_region": "eu",<br/>
        ///         "budget_id": "free_tier",<br/>
        ///         "default_model": "azure/gpt-3.5-turbo-eu"<br/>
        ///     }'<br/>
        /// # With object permissions<br/>
        /// curl -L -X POST 'http://localhost:4000/customer/new'         -H 'Authorization: Bearer sk-1234'         -H 'Content-Type: application/json'         -d '{<br/>
        ///         "user_id": "user_1",<br/>
        ///         "object_permission": {<br/>
        ///           "mcp_servers": ["server_1"],<br/>
        ///           "mcp_access_groups": ["public_group"],<br/>
        ///           "vector_stores": ["vector_store_1"]<br/>
        ///         }<br/>
        ///       }'<br/>
        ///     # return end-user object<br/>
        /// ```<br/>
        /// NOTE: This used to be called `/end_user/new`, we will still be maintaining compatibility for /end_user/XXX for these endpoints
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CustomerResponse> NewEndUserCustomerNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewCustomerRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New End User<br/>
        /// Allow creating a new Customer <br/>
        /// Parameters:<br/>
        /// - user_id: str - The unique identifier for the user.<br/>
        /// - alias: Optional[str] - A human-friendly alias for the user.<br/>
        /// - blocked: bool - Flag to allow or disallow requests for this end-user. Default is False.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the user. Either 'max_budget' or 'budget_id' should be provided, not both.<br/>
        /// - budget_id: Optional[str] - The identifier for an existing budget allocated to the user. Either 'max_budget' or 'budget_id' should be provided, not both.<br/>
        /// - allowed_model_region: Optional[Union[Literal["eu"], Literal["us"]]] - Require all user requests to use models in this specific region.<br/>
        /// - default_model: Optional[str] - If no equivalent model in the allowed region, default all requests to this model.<br/>
        /// - metadata: Optional[dict] = Metadata for customer, store information for customer. Example metadata = {"data_training_opt_out": True}<br/>
        /// - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - tpm_limit: Optional[int] - [Not Implemented Yet] Specify tpm limit for a given customer (Tokens per minute)<br/>
        /// - rpm_limit: Optional[int] - [Not Implemented Yet] Specify rpm limit for a given customer (Requests per minute)<br/>
        /// - model_max_budget: Optional[dict] - [Not Implemented Yet] Specify max budget for a given model. Example: {"openai/gpt-4o-mini": {"max_budget": 100.0, "budget_duration": "1d"}}<br/>
        /// - max_parallel_requests: Optional[int] - [Not Implemented Yet] Specify max parallel requests for a given customer.<br/>
        /// - soft_budget: Optional[float] - [Not Implemented Yet] Get alerts when customer crosses given budget, doesn't block requests.<br/>
        /// - spend: Optional[float] - Specify initial spend for a given customer.<br/>
        /// - budget_reset_at: Optional[str] - Specify the date and time when the budget should be reset.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Customer-specific object permissions to control access to resources.<br/>
        ///     Supported fields:<br/>
        ///     * mcp_servers: List[str] - List of allowed MCP server IDs<br/>
        ///     * mcp_access_groups: List[str] - List of MCP access group names<br/>
        ///     * mcp_tool_permissions: Dict[str, List[str]] - Map of server ID to allowed tool names (e.g., {"server_1": ["tool_a", "tool_b"]})<br/>
        ///     * vector_stores: List[str] - List of allowed vector store IDs<br/>
        ///     * agents: List[str] - List of allowed agent IDs<br/>
        ///     * agent_access_groups: List[str] - List of agent access group names<br/>
        ///     Example: {"mcp_servers": ["server_1", "server_2"], "vector_stores": ["vector_store_1"], "agents": ["agent_1"]}<br/>
        ///     IF null or {} then no object-level restrictions apply.<br/>
        /// - Allow specifying allowed regions <br/>
        /// - Allow specifying default model<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/new'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "user_id" : "ishaan-jaff-3",<br/>
        ///         "allowed_region": "eu",<br/>
        ///         "budget_id": "free_tier",<br/>
        ///         "default_model": "azure/gpt-3.5-turbo-eu"<br/>
        ///     }'<br/>
        /// # With object permissions<br/>
        /// curl -L -X POST 'http://localhost:4000/customer/new'         -H 'Authorization: Bearer sk-1234'         -H 'Content-Type: application/json'         -d '{<br/>
        ///         "user_id": "user_1",<br/>
        ///         "object_permission": {<br/>
        ///           "mcp_servers": ["server_1"],<br/>
        ///           "mcp_access_groups": ["public_group"],<br/>
        ///           "vector_stores": ["vector_store_1"]<br/>
        ///         }<br/>
        ///       }'<br/>
        ///     # return end-user object<br/>
        /// ```<br/>
        /// NOTE: This used to be called `/end_user/new`, we will still be maintaining compatibility for /end_user/XXX for these endpoints
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.CustomerResponse>> NewEndUserCustomerNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewCustomerRequest request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New End User<br/>
        /// Allow creating a new Customer <br/>
        /// Parameters:<br/>
        /// - user_id: str - The unique identifier for the user.<br/>
        /// - alias: Optional[str] - A human-friendly alias for the user.<br/>
        /// - blocked: bool - Flag to allow or disallow requests for this end-user. Default is False.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the user. Either 'max_budget' or 'budget_id' should be provided, not both.<br/>
        /// - budget_id: Optional[str] - The identifier for an existing budget allocated to the user. Either 'max_budget' or 'budget_id' should be provided, not both.<br/>
        /// - allowed_model_region: Optional[Union[Literal["eu"], Literal["us"]]] - Require all user requests to use models in this specific region.<br/>
        /// - default_model: Optional[str] - If no equivalent model in the allowed region, default all requests to this model.<br/>
        /// - metadata: Optional[dict] = Metadata for customer, store information for customer. Example metadata = {"data_training_opt_out": True}<br/>
        /// - budget_duration: Optional[str] - Budget is reset at the end of specified duration. If not set, budget is never reset. You can set duration as seconds ("30s"), minutes ("30m"), hours ("30h"), days ("30d").<br/>
        /// - tpm_limit: Optional[int] - [Not Implemented Yet] Specify tpm limit for a given customer (Tokens per minute)<br/>
        /// - rpm_limit: Optional[int] - [Not Implemented Yet] Specify rpm limit for a given customer (Requests per minute)<br/>
        /// - model_max_budget: Optional[dict] - [Not Implemented Yet] Specify max budget for a given model. Example: {"openai/gpt-4o-mini": {"max_budget": 100.0, "budget_duration": "1d"}}<br/>
        /// - max_parallel_requests: Optional[int] - [Not Implemented Yet] Specify max parallel requests for a given customer.<br/>
        /// - soft_budget: Optional[float] - [Not Implemented Yet] Get alerts when customer crosses given budget, doesn't block requests.<br/>
        /// - spend: Optional[float] - Specify initial spend for a given customer.<br/>
        /// - budget_reset_at: Optional[str] - Specify the date and time when the budget should be reset.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - Customer-specific object permissions to control access to resources.<br/>
        ///     Supported fields:<br/>
        ///     * mcp_servers: List[str] - List of allowed MCP server IDs<br/>
        ///     * mcp_access_groups: List[str] - List of MCP access group names<br/>
        ///     * mcp_tool_permissions: Dict[str, List[str]] - Map of server ID to allowed tool names (e.g., {"server_1": ["tool_a", "tool_b"]})<br/>
        ///     * vector_stores: List[str] - List of allowed vector store IDs<br/>
        ///     * agents: List[str] - List of allowed agent IDs<br/>
        ///     * agent_access_groups: List[str] - List of agent access group names<br/>
        ///     Example: {"mcp_servers": ["server_1", "server_2"], "vector_stores": ["vector_store_1"], "agents": ["agent_1"]}<br/>
        ///     IF null or {} then no object-level restrictions apply.<br/>
        /// - Allow specifying allowed regions <br/>
        /// - Allow specifying default model<br/>
        /// Example curl:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/customer/new'         --header 'Authorization: Bearer sk-1234'         --header 'Content-Type: application/json'         --data '{<br/>
        ///         "user_id" : "ishaan-jaff-3",<br/>
        ///         "allowed_region": "eu",<br/>
        ///         "budget_id": "free_tier",<br/>
        ///         "default_model": "azure/gpt-3.5-turbo-eu"<br/>
        ///     }'<br/>
        /// # With object permissions<br/>
        /// curl -L -X POST 'http://localhost:4000/customer/new'         -H 'Authorization: Bearer sk-1234'         -H 'Content-Type: application/json'         -d '{<br/>
        ///         "user_id": "user_1",<br/>
        ///         "object_permission": {<br/>
        ///           "mcp_servers": ["server_1"],<br/>
        ///           "mcp_access_groups": ["public_group"],<br/>
        ///           "vector_stores": ["vector_store_1"]<br/>
        ///         }<br/>
        ///       }'<br/>
        ///     # return end-user object<br/>
        /// ```<br/>
        /// NOTE: This used to be called `/end_user/new`, we will still be maintaining compatibility for /end_user/XXX for these endpoints
        /// </summary>
        /// <param name="budgetId"></param>
        /// <param name="maxBudget">
        /// Requests will fail if this budget (in USD) is exceeded.
        /// </param>
        /// <param name="softBudget">
        /// Requests will NOT fail if this is exceeded. Will fire alerting though.
        /// </param>
        /// <param name="maxParallelRequests">
        /// Max concurrent requests allowed for this budget id.
        /// </param>
        /// <param name="tpmLimit">
        /// Max tokens per minute, allowed for this budget id.
        /// </param>
        /// <param name="rpmLimit">
        /// Max requests per minute, allowed for this budget id.
        /// </param>
        /// <param name="budgetDuration">
        /// Max duration budget should be set for (e.g. '1hr', '1d', '28d')
        /// </param>
        /// <param name="modelMaxBudget">
        /// Max budget for each model (e.g. {'gpt-4o': {'max_budget': '0.0000001', 'budget_duration': '1d', 'tpm_limit': 1000, 'rpm_limit': 1000}})
        /// </param>
        /// <param name="budgetResetAt">
        /// Datetime when the budget is reset
        /// </param>
        /// <param name="userId"></param>
        /// <param name="alias"></param>
        /// <param name="blocked">
        /// Default Value: false
        /// </param>
        /// <param name="spend"></param>
        /// <param name="allowedModelRegion"></param>
        /// <param name="defaultModel"></param>
        /// <param name="objectPermission"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.CustomerResponse> NewEndUserCustomerNewPostAsync(
            string userId,
            string? budgetId = default,
            double? maxBudget = default,
            double? softBudget = default,
            int? maxParallelRequests = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.BudgetConfig>? modelMaxBudget = default,
            global::System.DateTime? budgetResetAt = default,
            string? alias = default,
            bool? blocked = default,
            double? spend = default,
            global::Loud.Technology.LiteLLM.Sdk.NewCustomerRequestAllowedModelRegion2? allowedModelRegion = default,
            string? defaultModel = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}