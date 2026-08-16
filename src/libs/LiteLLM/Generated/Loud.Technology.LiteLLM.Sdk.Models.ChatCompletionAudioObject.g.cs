
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionAudioObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.InputAudio InputAudio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"input_audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_audio";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAudioObject" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionAudioObject(
            global::Loud.Technology.LiteLLM.Sdk.InputAudio inputAudio,
            string type = "input_audio")
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionAudioObject" /> class.
        /// </summary>
        public ChatCompletionAudioObject()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ChatCompletionAudioObject"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ChatCompletionAudioObject FromInputAudio(global::Loud.Technology.LiteLLM.Sdk.InputAudio inputAudio)
        {
            return new ChatCompletionAudioObject
            {
                InputAudio = inputAudio,
            };
        }

    }
}