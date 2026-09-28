#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface ITeamManagementClient
    {
        /// <summary>
        /// Get Team Spend By User<br/>
        /// Spend per user within the given teams, attributed per request from spend logs.<br/>
        /// Proxy admins may query any team. Team admins and members holding the<br/>
        /// `/team/daily/activity` permission see every user of the requested teams;<br/>
        /// other members only see their own row.
        /// </summary>
        /// <param name="teamIds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.TeamUserSpendResponse> GetTeamSpendByUserTeamSpendByUserGetAsync(
            string? teamIds = default,
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Team Spend By User<br/>
        /// Spend per user within the given teams, attributed per request from spend logs.<br/>
        /// Proxy admins may query any team. Team admins and members holding the<br/>
        /// `/team/daily/activity` permission see every user of the requested teams;<br/>
        /// other members only see their own row.
        /// </summary>
        /// <param name="teamIds"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<global::Loud.Technology.LiteLLM.Sdk.TeamUserSpendResponse>> GetTeamSpendByUserTeamSpendByUserGetAsResponseAsync(
            string? teamIds = default,
            string? startDate = default,
            string? endDate = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}