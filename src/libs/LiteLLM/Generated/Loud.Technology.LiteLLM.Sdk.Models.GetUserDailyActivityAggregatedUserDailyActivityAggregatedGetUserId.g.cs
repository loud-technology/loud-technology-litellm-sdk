
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Filter by specific user ID. Admins can filter by any user or omit for global view. Non-admins must provide their own user_id.
    /// </summary>
    public sealed partial class GetUserDailyActivityAggregatedUserDailyActivityAggregatedGetUserId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}