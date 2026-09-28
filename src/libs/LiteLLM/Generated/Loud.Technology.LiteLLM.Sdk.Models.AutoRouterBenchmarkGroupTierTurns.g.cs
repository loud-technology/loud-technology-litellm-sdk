
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Turns per tier, keyed by the tier name the routing decision recorded at request time (never re-derived at read time, since the tier-to-model mapping is mutable config). Tier names are scoped to this group's router_type and are not comparable across types: a complexity router reports 'SIMPLE'/'MEDIUM'/'COMPLEX'/'REASONING', a quality router reports its numeric quality tier, and an adaptive router records no tier at all. Turns no tier served (the classifier fell back to default_model) are absent rather than pooled under a sentinel key, so the values may sum to less than turns
    /// </summary>
    public sealed partial class AutoRouterBenchmarkGroupTierTurns
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}