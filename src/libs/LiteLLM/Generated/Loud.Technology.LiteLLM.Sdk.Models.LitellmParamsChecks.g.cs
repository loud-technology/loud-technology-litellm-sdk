
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Inline safeguards for the resource-less InvokeGuardrailChecks API (contentFilter / promptAttack / sensitiveInformation). When set, the guardrail calls InvokeGuardrailChecks instead of ApplyGuardrail and no guardrailIdentifier is required. Mutually exclusive with guardrailIdentifier.
    /// </summary>
    public sealed partial class LitellmParamsChecks
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}