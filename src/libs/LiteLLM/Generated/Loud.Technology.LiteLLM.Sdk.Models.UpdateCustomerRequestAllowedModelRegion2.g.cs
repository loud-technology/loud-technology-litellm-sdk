
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCustomerRequestAllowedModelRegion2
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
    public static class UpdateCustomerRequestAllowedModelRegion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomerRequestAllowedModelRegion2 value)
        {
            return value switch
            {
                UpdateCustomerRequestAllowedModelRegion2.Eu => "eu",
                UpdateCustomerRequestAllowedModelRegion2.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomerRequestAllowedModelRegion2? ToEnum(string value)
        {
            return value switch
            {
                "eu" => UpdateCustomerRequestAllowedModelRegion2.Eu,
                "us" => UpdateCustomerRequestAllowedModelRegion2.Us,
                _ => null,
            };
        }
    }
}