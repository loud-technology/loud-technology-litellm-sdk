
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Page-mode counterpart to `PageLinks`. `first`/`last` are knowable here because the total count is.
    /// </summary>
    public sealed partial class ListLinks
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
        [global::System.Text.Json.Serialization.JsonPropertyName("first")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string First { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Last { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="prev"></param>
        /// <param name="next"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLinks(
            string self,
            string first,
            string last,
            string? prev,
            string? next)
        {
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
            this.First = first ?? throw new global::System.ArgumentNullException(nameof(first));
            this.Prev = prev;
            this.Next = next;
            this.Last = last ?? throw new global::System.ArgumentNullException(nameof(last));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLinks" /> class.
        /// </summary>
        public ListLinks()
        {
        }

    }
}