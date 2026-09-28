
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Score boundaries between tiers. These keys (simple_medium, medium_complex, complex_reasoning) name the gaps between the default tier names and are not renameable by tier_labels; they are scorer knobs persisted by name on every routing decision
    /// </summary>
    public sealed partial class RequestComplexityRouterConfigTierBoundaries
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}