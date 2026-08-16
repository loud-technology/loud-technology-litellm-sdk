
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionFileObject
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"file"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "file";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFileObjectFile File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFileObject" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionFileObject(
            global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFileObjectFile file,
            string type = "file")
        {
            this.Type = type;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionFileObject" /> class.
        /// </summary>
        public ChatCompletionFileObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionFileObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionFileObject FromFile(global::Loud.Technology.LiteLLM.Sdk.ChatCompletionFileObjectFile file)
        {
            return new ChatCompletionFileObject
            {
                File = file,
            };
        }

    }
}