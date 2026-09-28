
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Mode-specific parameters. ``langgraph_platform`` requires ``{'assistant_id': &lt;id&gt;}``. ``well_known_fallback`` ignores this.
    /// </summary>
    public sealed partial class DiscoverAgentRequestParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}