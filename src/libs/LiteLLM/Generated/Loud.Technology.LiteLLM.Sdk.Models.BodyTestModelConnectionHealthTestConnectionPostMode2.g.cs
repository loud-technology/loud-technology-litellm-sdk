
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyTestModelConnectionHealthTestConnectionPostMode2
    {
        /// <summary>
        /// 
        /// </summary>
        AudioSpeech,
        /// <summary>
        /// 
        /// </summary>
        AudioTranscription,
        /// <summary>
        /// 
        /// </summary>
        Batch,
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
        Ocr,
        /// <summary>
        /// 
        /// </summary>
        Realtime,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        Responses,
        /// <summary>
        /// 
        /// </summary>
        VideoGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyTestModelConnectionHealthTestConnectionPostMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyTestModelConnectionHealthTestConnectionPostMode2 value)
        {
            return value switch
            {
                BodyTestModelConnectionHealthTestConnectionPostMode2.AudioSpeech => "audio_speech",
                BodyTestModelConnectionHealthTestConnectionPostMode2.AudioTranscription => "audio_transcription",
                BodyTestModelConnectionHealthTestConnectionPostMode2.Batch => "batch",
                BodyTestModelConnectionHealthTestConnectionPostMode2.Chat => "chat",
                BodyTestModelConnectionHealthTestConnectionPostMode2.Completion => "completion",
                BodyTestModelConnectionHealthTestConnectionPostMode2.Embedding => "embedding",
                BodyTestModelConnectionHealthTestConnectionPostMode2.ImageGeneration => "image_generation",
                BodyTestModelConnectionHealthTestConnectionPostMode2.Ocr => "ocr",
                BodyTestModelConnectionHealthTestConnectionPostMode2.Realtime => "realtime",
                BodyTestModelConnectionHealthTestConnectionPostMode2.Rerank => "rerank",
                BodyTestModelConnectionHealthTestConnectionPostMode2.Responses => "responses",
                BodyTestModelConnectionHealthTestConnectionPostMode2.VideoGeneration => "video_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyTestModelConnectionHealthTestConnectionPostMode2? ToEnum(string value)
        {
            return value switch
            {
                "audio_speech" => BodyTestModelConnectionHealthTestConnectionPostMode2.AudioSpeech,
                "audio_transcription" => BodyTestModelConnectionHealthTestConnectionPostMode2.AudioTranscription,
                "batch" => BodyTestModelConnectionHealthTestConnectionPostMode2.Batch,
                "chat" => BodyTestModelConnectionHealthTestConnectionPostMode2.Chat,
                "completion" => BodyTestModelConnectionHealthTestConnectionPostMode2.Completion,
                "embedding" => BodyTestModelConnectionHealthTestConnectionPostMode2.Embedding,
                "image_generation" => BodyTestModelConnectionHealthTestConnectionPostMode2.ImageGeneration,
                "ocr" => BodyTestModelConnectionHealthTestConnectionPostMode2.Ocr,
                "realtime" => BodyTestModelConnectionHealthTestConnectionPostMode2.Realtime,
                "rerank" => BodyTestModelConnectionHealthTestConnectionPostMode2.Rerank,
                "responses" => BodyTestModelConnectionHealthTestConnectionPostMode2.Responses,
                "video_generation" => BodyTestModelConnectionHealthTestConnectionPostMode2.VideoGeneration,
                _ => null,
            };
        }
    }
}