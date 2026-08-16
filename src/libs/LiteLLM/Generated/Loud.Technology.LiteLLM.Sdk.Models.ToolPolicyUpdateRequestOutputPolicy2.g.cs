
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolPolicyUpdateRequestOutputPolicy2
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
    public static class ToolPolicyUpdateRequestOutputPolicy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolPolicyUpdateRequestOutputPolicy2 value)
        {
            return value switch
            {
                ToolPolicyUpdateRequestOutputPolicy2.Trusted => "trusted",
                ToolPolicyUpdateRequestOutputPolicy2.Untrusted => "untrusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolPolicyUpdateRequestOutputPolicy2? ToEnum(string value)
        {
            return value switch
            {
                "trusted" => ToolPolicyUpdateRequestOutputPolicy2.Trusted,
                "untrusted" => ToolPolicyUpdateRequestOutputPolicy2.Untrusted,
                _ => null,
            };
        }
    }
}