
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewCustomerRequestAllowedModelRegion2
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
    public static class NewCustomerRequestAllowedModelRegion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewCustomerRequestAllowedModelRegion2 value)
        {
            return value switch
            {
                NewCustomerRequestAllowedModelRegion2.Eu => "eu",
                NewCustomerRequestAllowedModelRegion2.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewCustomerRequestAllowedModelRegion2? ToEnum(string value)
        {
            return value switch
            {
                "eu" => NewCustomerRequestAllowedModelRegion2.Eu,
                "us" => NewCustomerRequestAllowedModelRegion2.Us,
                _ => null,
            };
        }
    }
}