
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolDetailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolPolicyOverrideRow>? Overrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.LiteLLMToolTableRow Tool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDetailResponse" /> class.
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="overrides"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolDetailResponse(
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMToolTableRow tool,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolPolicyOverrideRow>? overrides)
        {
            this.Overrides = overrides;
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDetailResponse" /> class.
        /// </summary>
        public ToolDetailResponse()
        {
        }

    }
}