
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The distinct values one column takes over a filtered query. `data` holds bare values, not entity rows.
    /// </summary>
    public sealed partial class FacetListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Data { get; set; }

        /// <summary>
        /// `has_more` rather than `total_count`, which would need a COUNT(*) over the whole match set per keystroke.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PageMeta Meta { get; set; }

        /// <summary>
        /// Hypermedia for a paginated list. No `first`/`last`: without a total count the last page is unknown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.PageLinks Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="meta">
        /// `has_more` rather than `total_count`, which would need a COUNT(*) over the whole match set per keystroke.
        /// </param>
        /// <param name="links">
        /// Hypermedia for a paginated list. No `first`/`last`: without a total count the last page is unknown.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FacetListResponse(
            global::System.Collections.Generic.IList<string> data,
            global::Loud.Technology.LiteLLM.Sdk.PageMeta meta,
            global::Loud.Technology.LiteLLM.Sdk.PageLinks links)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FacetListResponse" /> class.
        /// </summary>
        public FacetListResponse()
        {
        }

    }
}