
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolPolicyOptionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolPolicyOption> InputPolicies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolPolicyOption> OutputPolicies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPolicyOptionsResponse" /> class.
        /// </summary>
        /// <param name="inputPolicies"></param>
        /// <param name="outputPolicies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPolicyOptionsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolPolicyOption> inputPolicies,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolPolicyOption> outputPolicies)
        {
            this.InputPolicies = inputPolicies ?? throw new global::System.ArgumentNullException(nameof(inputPolicies));
            this.OutputPolicies = outputPolicies ?? throw new global::System.ArgumentNullException(nameof(outputPolicies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPolicyOptionsResponse" /> class.
        /// </summary>
        public ToolPolicyOptionsResponse()
        {
        }

    }
}