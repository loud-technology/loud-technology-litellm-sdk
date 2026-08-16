
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// XecGuard policies to apply on each scan. Select one or more of the built-in default policies; if none are selected, the guardrail defaults to System Prompt Enforcement + Harmful Content Protection.
    /// </summary>
    public sealed partial class LitellmParamsPolicyNames
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}