#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// New Team<br/>
        /// Allow users to create a new team. Apply user permissions to their team.<br/>
        /// 👉 [Detailed Doc on setting team budgets](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// Parameters:<br/>
        /// - team_alias: Optional[str] - User defined team alias<br/>
        /// - team_id: Optional[str] - The team id of the user. If none passed, we'll generate it.<br/>
        /// - members_with_roles: List[{"role": "admin" or "user", "user_id": "&lt;user-id&gt;"}] - A list of users and their roles in the team. Get user_id when making a new user via `/user/new`.<br/>
        /// - team_member_permissions: Optional[List[str]] - A list of routes that non-admin team members can access. example: ["/key/generate", "/key/update", "/key/delete"]<br/>
        /// - metadata: Optional[dict] - Metadata for team, store information for team. Example metadata = {"extra_info": "some info"}<br/>
        /// - model_rpm_limit: Optional[Dict[str, int]] - The RPM (Requests Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - model_tpm_limit: Optional[Dict[str, int]] - The TPM (Tokens Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - mcp_rpm_limit: Optional[Dict[str, int]] - Per-MCP-server RPM limit for this team, keyed by MCP server name (alias if set, else the configured name). Example: {"github": 100, "slack": 200}. Applied across all keys for this team.<br/>
        /// - tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for this team - all keys with this team_id will have at max this TPM limit<br/>
        /// - rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for this team - all keys associated with this team_id will have at max this RPM limit<br/>
        /// - rpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of RPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating RPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - tpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of TPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating TPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the team - all keys for this team_id will have at max this max_budget<br/>
        /// - soft_budget: Optional[float] - The soft budget threshold for the team. If max_budget is set, soft_budget must be strictly lower than max_budget. Can be set independently if max_budget is not set.<br/>
        /// - budget_duration: Optional[str] - The duration of the budget for the team. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - models: Optional[list] - A list of models associated with the team - all keys for this team_id will have at most, these models. If empty, assumes all models are allowed.<br/>
        /// - blocked: bool - Flag indicating if the team is blocked or not - will stop all calls from keys with this team_id.<br/>
        /// - members: Optional[List] - Control team members via `/team/member/add` and `/team/member/delete`.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the team is allowed to use.<br/>
        /// - organization_id: Optional[str] - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - guardrails: Optional[List[str]] - Guardrails for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails)<br/>
        /// - policies: Optional[List[str]] - Policies for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails/guardrail_policies)<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - team-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - team_member_budget: Optional[float] - The maximum budget allocated to an individual team member.<br/>
        /// - team_member_budget_duration: Optional[str] - The duration of the budget for the team member. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - team_member_rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for individual team members.<br/>
        /// - team_member_tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for individual team members.<br/>
        /// - team_member_key_duration: Optional[str] - The duration for a team member's key. e.g. "1d", "1w", "1mo"<br/>
        /// - allowed_passthrough_routes: Optional[List[str]] - List of allowed pass through routes for the team.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - secret_manager_settings: Optional[dict] - Secret manager settings for the team. [Docs](https://docs.litellm.ai/docs/secret_managers/overview)<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - team-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the team. Access groups define which models the team can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - enforced_file_expires_after: Optional[dict] - Enforced file expiration policy for the team. Keys created under this team will inherit this policy for file uploads. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - enforced_batch_output_expires_after: Optional[dict] - Enforced batch output file expiration policy for the team. Keys created under this team will inherit this policy for batch output files. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the team. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// - default_team_member_models: Optional[List[str]] - Default models assigned to new team members when they join this team. Must be a subset of the team's models.<br/>
        /// Returns:<br/>
        /// - team_id: (str) Unique team id - used for tracking spend across multiple keys for same team id.<br/>
        /// _deprecated_params:<br/>
        /// - admins: list - A list of user_id's for the admin role<br/>
        /// - users: list - A list of user_id's for the user role<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///   "team_alias": "my-new-team_2",<br/>
        ///   "members_with_roles": [{"role": "admin", "user_id": "user-1234"},<br/>
        ///     {"role": "user", "user_id": "user-2434"}]<br/>
        /// }'<br/>
        /// ```<br/>
        ///  ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///             "team_alias": "QA Prod Bot",<br/>
        ///             "max_budget": 0.000000001,<br/>
        ///             "budget_duration": "1d"<br/>
        ///         }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable> NewTeamTeamNewPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New Team<br/>
        /// Allow users to create a new team. Apply user permissions to their team.<br/>
        /// 👉 [Detailed Doc on setting team budgets](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// Parameters:<br/>
        /// - team_alias: Optional[str] - User defined team alias<br/>
        /// - team_id: Optional[str] - The team id of the user. If none passed, we'll generate it.<br/>
        /// - members_with_roles: List[{"role": "admin" or "user", "user_id": "&lt;user-id&gt;"}] - A list of users and their roles in the team. Get user_id when making a new user via `/user/new`.<br/>
        /// - team_member_permissions: Optional[List[str]] - A list of routes that non-admin team members can access. example: ["/key/generate", "/key/update", "/key/delete"]<br/>
        /// - metadata: Optional[dict] - Metadata for team, store information for team. Example metadata = {"extra_info": "some info"}<br/>
        /// - model_rpm_limit: Optional[Dict[str, int]] - The RPM (Requests Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - model_tpm_limit: Optional[Dict[str, int]] - The TPM (Tokens Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - mcp_rpm_limit: Optional[Dict[str, int]] - Per-MCP-server RPM limit for this team, keyed by MCP server name (alias if set, else the configured name). Example: {"github": 100, "slack": 200}. Applied across all keys for this team.<br/>
        /// - tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for this team - all keys with this team_id will have at max this TPM limit<br/>
        /// - rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for this team - all keys associated with this team_id will have at max this RPM limit<br/>
        /// - rpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of RPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating RPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - tpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of TPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating TPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the team - all keys for this team_id will have at max this max_budget<br/>
        /// - soft_budget: Optional[float] - The soft budget threshold for the team. If max_budget is set, soft_budget must be strictly lower than max_budget. Can be set independently if max_budget is not set.<br/>
        /// - budget_duration: Optional[str] - The duration of the budget for the team. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - models: Optional[list] - A list of models associated with the team - all keys for this team_id will have at most, these models. If empty, assumes all models are allowed.<br/>
        /// - blocked: bool - Flag indicating if the team is blocked or not - will stop all calls from keys with this team_id.<br/>
        /// - members: Optional[List] - Control team members via `/team/member/add` and `/team/member/delete`.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the team is allowed to use.<br/>
        /// - organization_id: Optional[str] - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - guardrails: Optional[List[str]] - Guardrails for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails)<br/>
        /// - policies: Optional[List[str]] - Policies for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails/guardrail_policies)<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - team-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - team_member_budget: Optional[float] - The maximum budget allocated to an individual team member.<br/>
        /// - team_member_budget_duration: Optional[str] - The duration of the budget for the team member. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - team_member_rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for individual team members.<br/>
        /// - team_member_tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for individual team members.<br/>
        /// - team_member_key_duration: Optional[str] - The duration for a team member's key. e.g. "1d", "1w", "1mo"<br/>
        /// - allowed_passthrough_routes: Optional[List[str]] - List of allowed pass through routes for the team.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - secret_manager_settings: Optional[dict] - Secret manager settings for the team. [Docs](https://docs.litellm.ai/docs/secret_managers/overview)<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - team-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the team. Access groups define which models the team can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - enforced_file_expires_after: Optional[dict] - Enforced file expiration policy for the team. Keys created under this team will inherit this policy for file uploads. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - enforced_batch_output_expires_after: Optional[dict] - Enforced batch output file expiration policy for the team. Keys created under this team will inherit this policy for batch output files. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the team. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// - default_team_member_models: Optional[List[str]] - Default models assigned to new team members when they join this team. Must be a subset of the team's models.<br/>
        /// Returns:<br/>
        /// - team_id: (str) Unique team id - used for tracking spend across multiple keys for same team id.<br/>
        /// _deprecated_params:<br/>
        /// - admins: list - A list of user_id's for the admin role<br/>
        /// - users: list - A list of user_id's for the user role<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///   "team_alias": "my-new-team_2",<br/>
        ///   "members_with_roles": [{"role": "admin", "user_id": "user-1234"},<br/>
        ///     {"role": "user", "user_id": "user-2434"}]<br/>
        /// }'<br/>
        /// ```<br/>
        ///  ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///             "team_alias": "QA Prod Bot",<br/>
        ///             "max_budget": 0.000000001,<br/>
        ///             "budget_duration": "1d"<br/>
        ///         }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable>> NewTeamTeamNewPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequest request,
            string? litellmChangedBy = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// New Team<br/>
        /// Allow users to create a new team. Apply user permissions to their team.<br/>
        /// 👉 [Detailed Doc on setting team budgets](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// Parameters:<br/>
        /// - team_alias: Optional[str] - User defined team alias<br/>
        /// - team_id: Optional[str] - The team id of the user. If none passed, we'll generate it.<br/>
        /// - members_with_roles: List[{"role": "admin" or "user", "user_id": "&lt;user-id&gt;"}] - A list of users and their roles in the team. Get user_id when making a new user via `/user/new`.<br/>
        /// - team_member_permissions: Optional[List[str]] - A list of routes that non-admin team members can access. example: ["/key/generate", "/key/update", "/key/delete"]<br/>
        /// - metadata: Optional[dict] - Metadata for team, store information for team. Example metadata = {"extra_info": "some info"}<br/>
        /// - model_rpm_limit: Optional[Dict[str, int]] - The RPM (Requests Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - model_tpm_limit: Optional[Dict[str, int]] - The TPM (Tokens Per Minute) limit for this team - applied across all keys for this team.<br/>
        /// - mcp_rpm_limit: Optional[Dict[str, int]] - Per-MCP-server RPM limit for this team, keyed by MCP server name (alias if set, else the configured name). Example: {"github": 100, "slack": 200}. Applied across all keys for this team.<br/>
        /// - tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for this team - all keys with this team_id will have at max this TPM limit<br/>
        /// - rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for this team - all keys associated with this team_id will have at max this RPM limit<br/>
        /// - rpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of RPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating RPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - tpm_limit_type: Optional[Literal["guaranteed_throughput", "best_effort_throughput"]] - The type of TPM limit enforcement. Use "guaranteed_throughput" to raise an error if overallocating TPM, or "best_effort_throughput" for best effort enforcement.<br/>
        /// - max_budget: Optional[float] - The maximum budget allocated to the team - all keys for this team_id will have at max this max_budget<br/>
        /// - soft_budget: Optional[float] - The soft budget threshold for the team. If max_budget is set, soft_budget must be strictly lower than max_budget. Can be set independently if max_budget is not set.<br/>
        /// - budget_duration: Optional[str] - The duration of the budget for the team. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - models: Optional[list] - A list of models associated with the team - all keys for this team_id will have at most, these models. If empty, assumes all models are allowed.<br/>
        /// - blocked: bool - Flag indicating if the team is blocked or not - will stop all calls from keys with this team_id.<br/>
        /// - members: Optional[List] - Control team members via `/team/member/add` and `/team/member/delete`.<br/>
        /// - tags: Optional[List[str]] - Tags for [tracking spend](https://litellm.vercel.app/docs/proxy/enterprise#tracking-spend-for-custom-tags) and/or doing [tag-based routing](https://litellm.vercel.app/docs/proxy/tag_routing).<br/>
        /// - prompts: Optional[List[str]] - List of prompts that the team is allowed to use.<br/>
        /// - organization_id: Optional[str] - The organization id of the team. Default is None. Create via `/organization/new`.<br/>
        /// - model_aliases: Optional[dict] - Model aliases for the team. [Docs](https://docs.litellm.ai/docs/proxy/team_based_routing#create-team-with-model-alias)<br/>
        /// - guardrails: Optional[List[str]] - Guardrails for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails)<br/>
        /// - policies: Optional[List[str]] - Policies for the team. [Docs](https://docs.litellm.ai/docs/proxy/guardrails/guardrail_policies)<br/>
        /// - disable_global_guardrails: Optional[bool] - Whether to disable global guardrails for the key.<br/>
        /// - object_permission: Optional[LiteLLM_ObjectPermissionBase] - team-specific object permission. Example - {"vector_stores": ["vector_store_1", "vector_store_2"], "agents": ["agent_1", "agent_2"], "agent_access_groups": ["dev_group"]}. IF null or {} then no object permission.<br/>
        /// - team_member_budget: Optional[float] - The maximum budget allocated to an individual team member.<br/>
        /// - team_member_budget_duration: Optional[str] - The duration of the budget for the team member. Doc [here](https://docs.litellm.ai/docs/proxy/team_budgets)<br/>
        /// - team_member_rpm_limit: Optional[int] - The RPM (Requests Per Minute) limit for individual team members.<br/>
        /// - team_member_tpm_limit: Optional[int] - The TPM (Tokens Per Minute) limit for individual team members.<br/>
        /// - team_member_key_duration: Optional[str] - The duration for a team member's key. e.g. "1d", "1w", "1mo"<br/>
        /// - allowed_passthrough_routes: Optional[List[str]] - List of allowed pass through routes for the team.<br/>
        /// - allowed_vector_store_indexes: Optional[List[dict]] - List of allowed vector store indexes for the key. Example - [{"index_name": "my-index", "index_permissions": ["write", "read"]}]. If specified, the key will only be able to use these specific vector store indexes. Create index, using `/v1/indexes` endpoint.<br/>
        /// - secret_manager_settings: Optional[dict] - Secret manager settings for the team. [Docs](https://docs.litellm.ai/docs/secret_managers/overview)<br/>
        /// - router_settings: Optional[UpdateRouterConfig] - team-specific router settings. Example - {"model_group_retry_policy": {"gpt-4": {"RateLimitErrorRetries": 5}}}. IF null or {} then no router settings.<br/>
        /// - access_group_ids: Optional[List[str]] - List of access group IDs to associate with the team. Access groups define which models the team can access. Example - ["access_group_1", "access_group_2"].<br/>
        /// - enforced_file_expires_after: Optional[dict] - Enforced file expiration policy for the team. Keys created under this team will inherit this policy for file uploads. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - enforced_batch_output_expires_after: Optional[dict] - Enforced batch output file expiration policy for the team. Keys created under this team will inherit this policy for batch output files. Example - {"anchor": "created_at", "days": 30}.<br/>
        /// - budget_limits: Optional[list] - List of concurrent budget windows for the team. Each window specifies a budget_limit, time_period, and optional budget_duration. Example - [{"budget_limit": 10.0, "time_period": "1d"}, {"budget_limit": 50.0, "time_period": "7d"}].<br/>
        /// - default_team_member_models: Optional[List[str]] - Default models assigned to new team members when they join this team. Must be a subset of the team's models.<br/>
        /// Returns:<br/>
        /// - team_id: (str) Unique team id - used for tracking spend across multiple keys for same team id.<br/>
        /// _deprecated_params:<br/>
        /// - admins: list - A list of user_id's for the admin role<br/>
        /// - users: list - A list of user_id's for the user role<br/>
        /// Example Request:<br/>
        /// ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///   "team_alias": "my-new-team_2",<br/>
        ///   "members_with_roles": [{"role": "admin", "user_id": "user-1234"},<br/>
        ///     {"role": "user", "user_id": "user-2434"}]<br/>
        /// }'<br/>
        /// ```<br/>
        ///  ```<br/>
        /// curl --location 'http://0.0.0.0:4000/team/new'     --header 'Authorization: Bearer sk-1234'     --header 'Content-Type: application/json'     --data '{<br/>
        ///             "team_alias": "QA Prod Bot",<br/>
        ///             "max_budget": 0.000000001,<br/>
        ///             "budget_duration": "1d"<br/>
        ///         }'<br/>
        /// ```
        /// </summary>
        /// <param name="litellmChangedBy">
        /// The litellm-changed-by header enables tracking of actions performed by authorized users on behalf of other users, providing an audit trail for accountability
        /// </param>
        /// <param name="teamAlias"></param>
        /// <param name="teamId"></param>
        /// <param name="organizationId"></param>
        /// <param name="admins">
        /// Default Value: []
        /// </param>
        /// <param name="members">
        /// Default Value: []
        /// </param>
        /// <param name="membersWithRoles">
        /// Default Value: []
        /// </param>
        /// <param name="teamMemberPermissions"></param>
        /// <param name="metadata"></param>
        /// <param name="tpmLimit"></param>
        /// <param name="rpmLimit"></param>
        /// <param name="maxBudget"></param>
        /// <param name="softBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="budgetLimits"></param>
        /// <param name="models">
        /// Default Value: []
        /// </param>
        /// <param name="blocked">
        /// Default Value: false
        /// </param>
        /// <param name="routerSettings"></param>
        /// <param name="accessGroupIds"></param>
        /// <param name="defaultTeamMemberModels"></param>
        /// <param name="modelAliases"></param>
        /// <param name="tags"></param>
        /// <param name="guardrails"></param>
        /// <param name="policies"></param>
        /// <param name="prompts"></param>
        /// <param name="objectPermission"></param>
        /// <param name="allowedPassthroughRoutes"></param>
        /// <param name="disableGlobalGuardrails"></param>
        /// <param name="secretManagerSettings"></param>
        /// <param name="modelRpmLimit"></param>
        /// <param name="rpmLimitType"></param>
        /// <param name="tpmLimitType"></param>
        /// <param name="modelTpmLimit"></param>
        /// <param name="mcpRpmLimit"></param>
        /// <param name="teamMemberBudget"></param>
        /// <param name="teamMemberRpmLimit"></param>
        /// <param name="teamMemberTpmLimit"></param>
        /// <param name="teamMemberKeyDuration"></param>
        /// <param name="teamMemberBudgetDuration"></param>
        /// <param name="allowedVectorStoreIndexes"></param>
        /// <param name="enforcedBatchOutputExpiresAfter"></param>
        /// <param name="enforcedFileExpiresAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.LiteLLMTeamTable> NewTeamTeamNewPostAsync(
            string? litellmChangedBy = default,
            string? teamAlias = default,
            string? teamId = default,
            string? organizationId = default,
            global::System.Collections.Generic.IList<object>? admins = default,
            global::System.Collections.Generic.IList<object>? members = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.Member>? membersWithRoles = default,
            global::System.Collections.Generic.IList<string>? teamMemberPermissions = default,
            object? metadata = default,
            int? tpmLimit = default,
            int? rpmLimit = default,
            double? maxBudget = default,
            double? softBudget = default,
            string? budgetDuration = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetLimitEntry>? budgetLimits = default,
            global::System.Collections.Generic.IList<object>? models = default,
            bool? blocked = default,
            object? routerSettings = default,
            global::System.Collections.Generic.IList<string>? accessGroupIds = default,
            global::System.Collections.Generic.IList<string>? defaultTeamMemberModels = default,
            object? modelAliases = default,
            global::System.Collections.Generic.IList<object>? tags = default,
            global::System.Collections.Generic.IList<string>? guardrails = default,
            global::System.Collections.Generic.IList<string>? policies = default,
            global::System.Collections.Generic.IList<string>? prompts = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMObjectPermissionBase? objectPermission = default,
            global::System.Collections.Generic.IList<object>? allowedPassthroughRoutes = default,
            bool? disableGlobalGuardrails = default,
            object? secretManagerSettings = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelRpmLimit = default,
            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequestRpmLimitType2? rpmLimitType = default,
            global::Loud.Technology.LiteLLM.Sdk.NewTeamRequestTpmLimitType2? tpmLimitType = default,
            global::System.Collections.Generic.Dictionary<string, int>? modelTpmLimit = default,
            global::System.Collections.Generic.Dictionary<string, int>? mcpRpmLimit = default,
            double? teamMemberBudget = default,
            int? teamMemberRpmLimit = default,
            int? teamMemberTpmLimit = default,
            string? teamMemberKeyDuration = default,
            string? teamMemberBudgetDuration = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AllowedVectorStoreIndexItem>? allowedVectorStoreIndexes = default,
            object? enforcedBatchOutputExpiresAfter = default,
            object? enforcedFileExpiresAfter = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}