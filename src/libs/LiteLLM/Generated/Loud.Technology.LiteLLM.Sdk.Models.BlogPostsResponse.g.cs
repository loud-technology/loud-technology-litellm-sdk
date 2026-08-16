
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlogPostsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("posts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BlogPost> Posts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPostsResponse" /> class.
        /// </summary>
        /// <param name="posts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlogPostsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.BlogPost> posts)
        {
            this.Posts = posts ?? throw new global::System.ArgumentNullException(nameof(posts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPostsResponse" /> class.
        /// </summary>
        public BlogPostsResponse()
        {
        }

    }
}