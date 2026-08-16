
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyVideoCreateCharacterV1VideosCharactersPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Videoname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVideoCreateCharacterV1VideosCharactersPost" /> class.
        /// </summary>
        /// <param name="video"></param>
        /// <param name="videoname"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyVideoCreateCharacterV1VideosCharactersPost(
            byte[] video,
            string videoname,
            string name)
        {
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
            this.Videoname = videoname ?? throw new global::System.ArgumentNullException(nameof(videoname));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyVideoCreateCharacterV1VideosCharactersPost" /> class.
        /// </summary>
        public BodyVideoCreateCharacterV1VideosCharactersPost()
        {
        }

    }
}