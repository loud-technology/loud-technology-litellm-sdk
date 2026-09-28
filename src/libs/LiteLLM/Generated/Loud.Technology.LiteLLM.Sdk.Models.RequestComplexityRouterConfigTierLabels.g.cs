
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Display names for the complexity tiers, so a deployment can use its own vocabulary (e.g. Cheap/Standard/Premium/Deep) in the dashboard, spend logs, and the LLM classifier rubric. Purely operator-facing: config keys stay canonical (tiers, keyword_tier_rules[].tier, tier_boundaries), API callers never see these names, and the heuristic scorer never reads them. Unlisted tiers keep their canonical name. Partial maps are allowed.
    /// </summary>
    public sealed partial class RequestComplexityRouterConfigTierLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}