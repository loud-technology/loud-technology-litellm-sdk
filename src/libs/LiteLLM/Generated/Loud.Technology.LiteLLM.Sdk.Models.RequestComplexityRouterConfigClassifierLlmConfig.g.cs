
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Configuration for the LLM classifier; required when classifier_type is 'llm', 'capability', 'heuristic_first' or 'hybrid'
    /// </summary>
    public sealed partial class RequestComplexityRouterConfigClassifierLlmConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}