
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserAPIKeyAuthAllowedModelRegion2
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
    public static class UserAPIKeyAuthAllowedModelRegion2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserAPIKeyAuthAllowedModelRegion2 value)
        {
            return value switch
            {
                UserAPIKeyAuthAllowedModelRegion2.Eu => "eu",
                UserAPIKeyAuthAllowedModelRegion2.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserAPIKeyAuthAllowedModelRegion2? ToEnum(string value)
        {
            return value switch
            {
                "eu" => UserAPIKeyAuthAllowedModelRegion2.Eu,
                "us" => UserAPIKeyAuthAllowedModelRegion2.Us,
                _ => null,
            };
        }
    }
}