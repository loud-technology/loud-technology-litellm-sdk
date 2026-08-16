
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionCachedContentTtl
    {
        /// <summary>
        /// 
        /// </summary>
        x1h,
        /// <summary>
        /// 
        /// </summary>
        x5m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionCachedContentTtlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionCachedContentTtl value)
        {
            return value switch
            {
                ChatCompletionCachedContentTtl.x1h => "1h",
                ChatCompletionCachedContentTtl.x5m => "5m",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionCachedContentTtl? ToEnum(string value)
        {
            return value switch
            {
                "1h" => ChatCompletionCachedContentTtl.x1h,
                "5m" => ChatCompletionCachedContentTtl.x5m,
                _ => null,
            };
        }
    }
}