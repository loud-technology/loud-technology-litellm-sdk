
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Total spend attributed to one tool over the requested window.
    /// </summary>
    public sealed partial class ToolSpendEntry
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_count")]
        public int? CallCount { get; set; }

        /// <summary>
        /// Attributed spend: a request that used several tools counts its full spend toward each of them<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend")]
        public double? Spend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSpendEntry" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="callCount">
        /// Default Value: 0
        /// </param>
        /// <param name="spend">
        /// Attributed spend: a request that used several tools counts its full spend toward each of them<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSpendEntry(
            string toolName,
            int? callCount,
            double? spend,
            int? totalTokens)
        {
            this.CallCount = callCount;
            this.Spend = spend;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSpendEntry" /> class.
        /// </summary>
        public ToolSpendEntry()
        {
        }

    }
}