
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSearchToolRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("search_tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.SearchTool SearchTool { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchToolRequest" /> class.
        /// </summary>
        /// <param name="searchTool">
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
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSearchToolRequest(
            global::Loud.Technology.LiteLLM.Sdk.SearchTool searchTool)
        {
            this.SearchTool = searchTool ?? throw new global::System.ArgumentNullException(nameof(searchTool));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchToolRequest" /> class.
        /// </summary>
        public CreateSearchToolRequest()
        {
        }

    }
}