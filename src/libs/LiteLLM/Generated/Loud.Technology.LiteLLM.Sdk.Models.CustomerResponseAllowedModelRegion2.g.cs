
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomerResponseAllowedModelRegion2
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomerResponseAllowedModelRegion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomerResponseAllowedModelRegion2 value)
        {
            return value switch
            {
                CustomerResponseAllowedModelRegion2.Eu => "eu",
                CustomerResponseAllowedModelRegion2.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomerResponseAllowedModelRegion2? ToEnum(string value)
        {
            return value switch
            {
                "eu" => CustomerResponseAllowedModelRegion2.Eu,
                "us" => CustomerResponseAllowedModelRegion2.Us,
                _ => null,
            };
        }
    }
}