
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeyHealthResponseKey
    {
        /// <summary>
        /// 
        /// </summary>
        Healthy,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KeyHealthResponseKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeyHealthResponseKey value)
        {
            return value switch
            {
                KeyHealthResponseKey.Healthy => "healthy",
                KeyHealthResponseKey.Unhealthy => "unhealthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeyHealthResponseKey? ToEnum(string value)
        {
            return value switch
            {
                "healthy" => KeyHealthResponseKey.Healthy,
                "unhealthy" => KeyHealthResponseKey.Unhealthy,
                _ => null,
            };
        }
    }
}