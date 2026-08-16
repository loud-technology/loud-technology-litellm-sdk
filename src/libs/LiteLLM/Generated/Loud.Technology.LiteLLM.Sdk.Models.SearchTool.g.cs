
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Search tool configuration.<br/>
    /// Example:<br/>
    ///     {<br/>
    ///         "search_tool_id": "123e4567-e89b-12d3-a456-426614174000",<br/>
    ///         "search_tool_name": "litellm-search",<br/>
    ///         "litellm_params": {<br/>
    ///             "search_provider": "perplexity",<br/>
    ///             "api_key": "sk-..."<br/>
    ///         },<br/>
    ///         "search_tool_info": {<br/>
    ///             "description": "Perplexity search tool"<br/>
    ///         }<br/>
    ///     }
    /// </summary>
    public sealed partial class SearchTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// LiteLLM params for search tools configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.SearchToolLiteLLMParams LitellmParams { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SearchToolName { get; set; }

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
        /// Initializes a new instance of the <see cref="SearchTool" /> class.
        /// </summary>
        /// <param name="litellmParams">
        /// LiteLLM params for search tools configuration.
        /// </param>
        /// <param name="searchToolName"></param>
        /// <param name="createdAt"></param>
        /// <param name="searchToolId"></param>
        /// <param name="searchToolInfo"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchTool(
            global::Loud.Technology.LiteLLM.Sdk.SearchToolLiteLLMParams litellmParams,
            string searchToolName,
            string? createdAt,
            string? searchToolId,
            object? searchToolInfo,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.LitellmParams = litellmParams ?? throw new global::System.ArgumentNullException(nameof(litellmParams));
            this.SearchToolId = searchToolId;
            this.SearchToolInfo = searchToolInfo;
            this.SearchToolName = searchToolName ?? throw new global::System.ArgumentNullException(nameof(searchToolName));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTool" /> class.
        /// </summary>
        public SearchTool()
        {
        }

    }
}