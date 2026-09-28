
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseLitellmParamsOnSensitiveData2
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
    public static class BaseLitellmParamsOnSensitiveData2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseLitellmParamsOnSensitiveData2 value)
        {
            return value switch
            {
                BaseLitellmParamsOnSensitiveData2.Block => "block",
                BaseLitellmParamsOnSensitiveData2.Route => "route",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseLitellmParamsOnSensitiveData2? ToEnum(string value)
        {
            return value switch
            {
                "block" => BaseLitellmParamsOnSensitiveData2.Block,
                "route" => BaseLitellmParamsOnSensitiveData2.Route,
                _ => null,
            };
        }
    }
}