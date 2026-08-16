
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The action to take when the category is detected
    /// </summary>
    public enum ContentFilterCategoryConfigAction
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
    public static class ContentFilterCategoryConfigActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterCategoryConfigAction value)
        {
            return value switch
            {
                ContentFilterCategoryConfigAction.Block => "BLOCK",
                ContentFilterCategoryConfigAction.Mask => "MASK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterCategoryConfigAction? ToEnum(string value)
        {
            return value switch
            {
                "BLOCK" => ContentFilterCategoryConfigAction.Block,
                "MASK" => ContentFilterCategoryConfigAction.Mask,
                _ => null,
            };
        }
    }
}