
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Max budget per model for every key on the team, overridable per key (e.g. {'gpt-4o': {'max_budget': 10, 'budget_duration': '1d'}})
    /// </summary>
    public sealed partial class PatchTeamRequestModelMaxBudget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}