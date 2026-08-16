
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolSpendResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_tool")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolSpendEntry>? ByTool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolSpendDailyEntry>? Daily { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSpendResponse" /> class.
        /// </summary>
        /// <param name="byTool"></param>
        /// <param name="daily"></param>
        /// <param name="endDate"></param>
        /// <param name="startDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolSpendResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolSpendEntry>? byTool,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ToolSpendDailyEntry>? daily,
            string? endDate,
            string? startDate)
        {
            this.ByTool = byTool;
            this.Daily = daily;
            this.EndDate = endDate;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolSpendResponse" /> class.
        /// </summary>
        public ToolSpendResponse()
        {
        }

    }
}