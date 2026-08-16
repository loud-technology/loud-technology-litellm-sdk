
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum LitellmParamsPresidioRunOn2
    {
        /// <summary>
        /// 
        /// </summary>
        Both,
        /// <summary>
        /// 
        /// </summary>
        Input,
        /// <summary>
        /// 
        /// </summary>
        Output,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LitellmParamsPresidioRunOn2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsPresidioRunOn2 value)
        {
            return value switch
            {
                LitellmParamsPresidioRunOn2.Both => "both",
                LitellmParamsPresidioRunOn2.Input => "input",
                LitellmParamsPresidioRunOn2.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsPresidioRunOn2? ToEnum(string value)
        {
            return value switch
            {
                "both" => LitellmParamsPresidioRunOn2.Both,
                "input" => LitellmParamsPresidioRunOn2.Input,
                "output" => LitellmParamsPresidioRunOn2.Output,
                _ => null,
            };
        }
    }
}