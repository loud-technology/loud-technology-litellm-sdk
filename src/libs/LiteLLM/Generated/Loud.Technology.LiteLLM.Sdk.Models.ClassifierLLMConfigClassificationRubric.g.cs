
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Which calibration examples the built-in rubric carries. 'agentic' anchors routine installs, builds, multi-file edits, and standard debugging at MEDIUM, so ordinary engineering does not route to the most expensive tier; it suits agent, terminal, and coding-assistant traffic as well as mixed traffic. 'chat' omits those engineering anchors, for a deployment serving only conversational traffic. 'business' carries business/sales anchors and business-flavored tier criteria that keep routine drafting and summarizing off the expensive tiers and reserve the top tier for committing to decisions under tradeoffs; it suits sales, support, and go-to-market traffic. Every preset keeps the same four tiers, so this moves where the boundary sits without changing the taxonomy. Leave unset for 'legacy', the rubric as it shipped before calibration examples existed, so an existing router's tier decisions and spend do not move on upgrade. Mutually exclusive with system_prompt, which replaces the rubric this would select. Only applies when classifier_type is 'llm'.
    /// </summary>
    public sealed partial class ClassifierLLMConfigClassificationRubric
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}