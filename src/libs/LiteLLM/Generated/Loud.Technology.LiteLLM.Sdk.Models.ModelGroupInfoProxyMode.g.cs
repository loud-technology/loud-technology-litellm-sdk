
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelGroupInfoProxyMode
    {
        /// <summary>
        /// 
        /// </summary>
        AudioTranscription,
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Completion,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        Moderations,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelGroupInfoProxyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelGroupInfoProxyMode value)
        {
            return value switch
            {
                ModelGroupInfoProxyMode.AudioTranscription => "audio_transcription",
                ModelGroupInfoProxyMode.Chat => "chat",
                ModelGroupInfoProxyMode.Completion => "completion",
                ModelGroupInfoProxyMode.Embedding => "embedding",
                ModelGroupInfoProxyMode.ImageGeneration => "image_generation",
                ModelGroupInfoProxyMode.Moderations => "moderations",
                ModelGroupInfoProxyMode.Rerank => "rerank",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelGroupInfoProxyMode? ToEnum(string value)
        {
            return value switch
            {
                "audio_transcription" => ModelGroupInfoProxyMode.AudioTranscription,
                "chat" => ModelGroupInfoProxyMode.Chat,
                "completion" => ModelGroupInfoProxyMode.Completion,
                "embedding" => ModelGroupInfoProxyMode.Embedding,
                "image_generation" => ModelGroupInfoProxyMode.ImageGeneration,
                "moderations" => ModelGroupInfoProxyMode.Moderations,
                "rerank" => ModelGroupInfoProxyMode.Rerank,
                _ => null,
            };
        }
    }
}