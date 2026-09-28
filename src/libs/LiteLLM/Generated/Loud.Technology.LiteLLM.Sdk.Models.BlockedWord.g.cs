
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Represents a blocked word with its action and optional description
    /// </summary>
    public sealed partial class BlockedWord
    {
        /// <summary>
        /// Action to take when keyword is detected (BLOCK or MASK)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ContentFilterActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ContentFilterAction Action { get; set; }

        /// <summary>
        /// Optional description explaining why this keyword is sensitive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The keyword to block or mask
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Keyword { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedWord" /> class.
        /// </summary>
        /// <param name="action">
        /// Action to take when keyword is detected (BLOCK or MASK)
        /// </param>
        /// <param name="keyword">
        /// The keyword to block or mask
        /// </param>
        /// <param name="description">
        /// Optional description explaining why this keyword is sensitive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlockedWord(
            global::Loud.Technology.LiteLLM.Sdk.ContentFilterAction action,
            string keyword,
            string? description)
        {
            this.Action = action;
            this.Description = description;
            this.Keyword = keyword ?? throw new global::System.ArgumentNullException(nameof(keyword));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockedWord" /> class.
        /// </summary>
        public BlockedWord()
        {
        }

    }
}