
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Hypermedia for a paginated list. No `first`/`last`: without a total count the last page is unknown.
    /// </summary>
    public sealed partial class PageLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Self { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev")]
        public string? Prev { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="prev"></param>
        /// <param name="next"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PageLinks(
            string self,
            string? prev,
            string? next)
        {
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
            this.Prev = prev;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageLinks" /> class.
        /// </summary>
        public PageLinks()
        {
        }

    }
}