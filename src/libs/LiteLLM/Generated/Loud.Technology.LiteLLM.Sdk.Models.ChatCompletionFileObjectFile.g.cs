
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionFileObjectFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_metadata")]
        public object? VideoMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFileObjectFile" /> class.
        /// </summary>
        /// <param name="fileData"></param>
        /// <param name="fileId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="detail"></param>
        /// <param name="videoMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionFileObjectFile(
            string? fileData,
            string? fileId,
            string? filename,
            string? format,
            string? detail,
            object? videoMetadata)
        {
            this.FileData = fileData;
            this.FileId = fileId;
            this.Filename = filename;
            this.Format = format;
            this.Detail = detail;
            this.VideoMetadata = videoMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFileObjectFile" /> class.
        /// </summary>
        public ChatCompletionFileObjectFile()
        {
        }

    }
}