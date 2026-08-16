
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for search tool information.
    /// </summary>
    public sealed partial class SearchToolInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_from_config")]
        public bool? IsFromConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public object? LitellmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_tool_id")]
        public string? SearchToolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_tool_info")]
        public object? SearchToolInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_tool_name")]
        public string? SearchToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchToolInfoResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="isFromConfig"></param>
        /// <param name="litellmParams"></param>
        /// <param name="searchToolId"></param>
        /// <param name="searchToolInfo"></param>
        /// <param name="searchToolName"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchToolInfoResponse(
            string? createdAt,
            bool? isFromConfig,
            object? litellmParams,
            string? searchToolId,
            object? searchToolInfo,
            string? searchToolName,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.IsFromConfig = isFromConfig;
            this.LitellmParams = litellmParams;
            this.SearchToolId = searchToolId;
            this.SearchToolInfo = searchToolInfo;
            this.SearchToolName = searchToolName;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchToolInfoResponse" /> class.
        /// </summary>
        public SearchToolInfoResponse()
        {
        }

    }
}