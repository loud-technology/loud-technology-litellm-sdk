
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Choose whether disallowed tools block the request or get rewritten out of the payload<br/>
    /// Default Value: block
    /// </summary>
    public enum LitellmParamsOnDisallowedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Rewrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LitellmParamsOnDisallowedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsOnDisallowedAction value)
        {
            return value switch
            {
                LitellmParamsOnDisallowedAction.Block => "block",
                LitellmParamsOnDisallowedAction.Rewrite => "rewrite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsOnDisallowedAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => LitellmParamsOnDisallowedAction.Block,
                "rewrite" => LitellmParamsOnDisallowedAction.Rewrite,
                _ => null,
            };
        }
    }
}