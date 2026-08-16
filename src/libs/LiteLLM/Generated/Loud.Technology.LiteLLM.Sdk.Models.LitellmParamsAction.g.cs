
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 'block' raises an error; 'mask' replaces the code block with a placeholder.<br/>
    /// Default Value: block
    /// </summary>
    public enum LitellmParamsAction
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
    public static class LitellmParamsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsAction value)
        {
            return value switch
            {
                LitellmParamsAction.Block => "block",
                LitellmParamsAction.Mask => "mask",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => LitellmParamsAction.Block,
                "mask" => LitellmParamsAction.Mask,
                _ => null,
            };
        }
    }
}