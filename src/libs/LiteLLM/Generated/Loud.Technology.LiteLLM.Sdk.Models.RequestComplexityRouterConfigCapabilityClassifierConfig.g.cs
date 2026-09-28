
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Probability threshold policy required when classifier_type is 'capability'. The classifier forecasts p_solve for efficient_tier, adjusts base_threshold using the capability-card boundary, and otherwise routes to capable_tier
    /// </summary>
    public sealed partial class RequestComplexityRouterConfigCapabilityClassifierConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}