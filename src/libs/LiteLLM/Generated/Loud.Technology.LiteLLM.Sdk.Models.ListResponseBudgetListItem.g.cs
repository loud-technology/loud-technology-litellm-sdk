
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListResponseBudgetListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetListItem> Data { get; set; }

        /// <summary>
        /// Page-mode counterpart to `PageMeta`: an entity list pays for the COUNT(*) so the table can show a page count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ListMeta Meta { get; set; }

        /// <summary>
        /// Page-mode counterpart to `PageLinks`. `first`/`last` are knowable here because the total count is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ListLinks Links { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseBudgetListItem" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="meta">
        /// Page-mode counterpart to `PageMeta`: an entity list pays for the COUNT(*) so the table can show a page count.
        /// </param>
        /// <param name="links">
        /// Page-mode counterpart to `PageLinks`. `first`/`last` are knowable here because the total count is.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListResponseBudgetListItem(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BudgetListItem> data,
            global::Loud.Technology.LiteLLM.Sdk.ListMeta meta,
            global::Loud.Technology.LiteLLM.Sdk.ListLinks links)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Meta = meta ?? throw new global::System.ArgumentNullException(nameof(meta));
            this.Links = links ?? throw new global::System.ArgumentNullException(nameof(links));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseBudgetListItem" /> class.
        /// </summary>
        public ListResponseBudgetListItem()
        {
        }

    }
}