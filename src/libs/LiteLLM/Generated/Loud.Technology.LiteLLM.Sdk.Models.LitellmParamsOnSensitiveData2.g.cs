
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum LitellmParamsOnSensitiveData2
    {
        /// <summary>
        ///
        /// </summary>
        Block,
        /// <summary>
        ///
        /// </summary>
        Route,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LitellmParamsOnSensitiveData2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsOnSensitiveData2 value)
        {
            return value switch
            {
                LitellmParamsOnSensitiveData2.Block => "block",
                LitellmParamsOnSensitiveData2.Route => "route",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsOnSensitiveData2? ToEnum(string value)
        {
            return value switch
            {
                "block" => LitellmParamsOnSensitiveData2.Block,
                "route" => LitellmParamsOnSensitiveData2.Route,
                _ => null,
            };
        }
    }
}