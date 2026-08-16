
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum LitellmParamsPresidioFilterScope2
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
    public static class LitellmParamsPresidioFilterScope2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsPresidioFilterScope2 value)
        {
            return value switch
            {
                LitellmParamsPresidioFilterScope2.Both => "both",
                LitellmParamsPresidioFilterScope2.Input => "input",
                LitellmParamsPresidioFilterScope2.Output => "output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsPresidioFilterScope2? ToEnum(string value)
        {
            return value switch
            {
                "both" => LitellmParamsPresidioFilterScope2.Both,
                "input" => LitellmParamsPresidioFilterScope2.Input,
                "output" => LitellmParamsPresidioFilterScope2.Output,
                _ => null,
            };
        }
    }
}