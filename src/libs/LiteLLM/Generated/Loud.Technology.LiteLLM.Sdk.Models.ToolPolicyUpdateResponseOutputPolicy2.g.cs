
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolPolicyUpdateResponseOutputPolicy2
    {
        /// <summary>
        /// 
        /// </summary>
        Trusted,
        /// <summary>
        /// 
        /// </summary>
        Untrusted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolPolicyUpdateResponseOutputPolicy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolPolicyUpdateResponseOutputPolicy2 value)
        {
            return value switch
            {
                ToolPolicyUpdateResponseOutputPolicy2.Trusted => "trusted",
                ToolPolicyUpdateResponseOutputPolicy2.Untrusted => "untrusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolPolicyUpdateResponseOutputPolicy2? ToEnum(string value)
        {
            return value switch
            {
                "trusted" => ToolPolicyUpdateResponseOutputPolicy2.Trusted,
                "untrusted" => ToolPolicyUpdateResponseOutputPolicy2.Untrusted,
                _ => null,
            };
        }
    }
}