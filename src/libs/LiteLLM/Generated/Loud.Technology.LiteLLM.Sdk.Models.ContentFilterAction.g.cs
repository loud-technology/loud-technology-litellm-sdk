
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Action to take when content filter detects a match
    /// </summary>
    public enum ContentFilterAction
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Mask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterAction value)
        {
            return value switch
            {
                ContentFilterAction.Block => "BLOCK",
                ContentFilterAction.Mask => "MASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterAction? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK" => ContentFilterAction.Block,
                "MASK" => ContentFilterAction.Mask,
                _ => null,
            };
        }
    }
}