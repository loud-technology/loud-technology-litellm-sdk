
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum LitellmParamsOnFlagged2
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Monitor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LitellmParamsOnFlagged2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsOnFlagged2 value)
        {
            return value switch
            {
                LitellmParamsOnFlagged2.Block => "block",
                LitellmParamsOnFlagged2.Monitor => "monitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsOnFlagged2? ToEnum(string value)
        {
            return value switch
            {
                "block" => LitellmParamsOnFlagged2.Block,
                "monitor" => LitellmParamsOnFlagged2.Monitor,
                _ => null,
            };
        }
    }
}