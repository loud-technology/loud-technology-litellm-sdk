
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyVideoGenerationV1VideosPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_reference")]
        public byte[]? InputReference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_referencename")]
        public string? InputReferencename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVideoGenerationV1VideosPost" /> class.
        /// </summary>
        /// <param name="inputReference"></param>
        /// <param name="inputReferencename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyVideoGenerationV1VideosPost(
            byte[]? inputReference,
            string? inputReferencename)
        {
            this.InputReference = inputReference;
            this.InputReferencename = inputReferencename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVideoGenerationV1VideosPost" /> class.
        /// </summary>
        public BodyVideoGenerationV1VideosPost()
        {
        }

    }
}