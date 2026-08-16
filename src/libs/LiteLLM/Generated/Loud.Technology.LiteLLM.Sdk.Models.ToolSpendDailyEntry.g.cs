
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Spend attributed to one tool on one UTC day.
    /// </summary>
    public sealed partial class ToolSpendDailyEntry
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_count")]
        public int? CallCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSpendDailyEntry" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="toolName"></param>
        /// <param name="callCount">
        /// Default Value: 0
        /// </param>
        /// <param name="spend">
        /// Default Value: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSpendDailyEntry(
            string date,
            string toolName,
            int? callCount,
            double? spend)
        {
            this.CallCount = callCount;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Spend = spend;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSpendDailyEntry" /> class.
        /// </summary>
        public ToolSpendDailyEntry()
        {
        }

    }
}