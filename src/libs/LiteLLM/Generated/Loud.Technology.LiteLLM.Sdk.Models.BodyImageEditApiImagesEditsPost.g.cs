
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyImageEditApiImagesEditsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::System.Collections.Generic.IList<byte[]>? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image[]")]
        public global::System.Collections.Generic.IList<byte[]>? Image2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        public global::System.Collections.Generic.IList<byte[]>? Mask { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask[]")]
        public global::System.Collections.Generic.IList<byte[]>? Mask2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyImageEditApiImagesEditsPost" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="image2"></param>
        /// <param name="mask"></param>
        /// <param name="mask2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyImageEditApiImagesEditsPost(
            global::System.Collections.Generic.IList<byte[]>? image,
            global::System.Collections.Generic.IList<byte[]>? image2,
            global::System.Collections.Generic.IList<byte[]>? mask,
            global::System.Collections.Generic.IList<byte[]>? mask2)
        {
            this.Image = image;
            this.Image2 = image2;
            this.Mask = mask;
            this.Mask2 = mask2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyImageEditApiImagesEditsPost" /> class.
        /// </summary>
        public BodyImageEditApiImagesEditsPost()
        {
        }

    }
}