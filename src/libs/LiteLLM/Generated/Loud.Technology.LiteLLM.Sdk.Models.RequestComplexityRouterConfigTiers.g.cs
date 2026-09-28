
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Mapping of complexity tiers to a model or model pool. A list is randomly picked from when adaptive=False, and used as a soft-floor home pool when adaptive=True
    /// </summary>
    public sealed partial class RequestComplexityRouterConfigTiers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}