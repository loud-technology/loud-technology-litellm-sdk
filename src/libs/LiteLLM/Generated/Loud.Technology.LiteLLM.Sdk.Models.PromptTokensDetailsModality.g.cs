
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptTokensDetailsModality
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptTokensDetailsModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptTokensDetailsModality value)
        {
            return value switch
            {
                PromptTokensDetailsModality.Audio => "AUDIO",
                PromptTokensDetailsModality.Image => "IMAGE",
                PromptTokensDetailsModality.Text => "TEXT",
                PromptTokensDetailsModality.Video => "VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptTokensDetailsModality? ToEnum(string value)
        {
            return value switch
            {
                "AUDIO" => PromptTokensDetailsModality.Audio,
                "IMAGE" => PromptTokensDetailsModality.Image,
                "TEXT" => PromptTokensDetailsModality.Text,
                "VIDEO" => PromptTokensDetailsModality.Video,
                _ => null,
            };
        }
    }
}