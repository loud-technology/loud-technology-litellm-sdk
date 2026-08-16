
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response model for listing search tools.
    /// </summary>
    public sealed partial class ListSearchToolsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SearchToolInfoResponse> SearchTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSearchToolsResponse" /> class.
        /// </summary>
        /// <param name="searchTools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSearchToolsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SearchToolInfoResponse> searchTools)
        {
            this.SearchTools = searchTools ?? throw new global::System.ArgumentNullException(nameof(searchTools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSearchToolsResponse" /> class.
        /// </summary>
        public ListSearchToolsResponse()
        {
        }

    }
}