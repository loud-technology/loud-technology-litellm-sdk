
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolPolicyUpdateRequestInputPolicy2
    {
        /// <summary>
        /// 
        /// </summary>
        Blocked,
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
    public static class ToolPolicyUpdateRequestInputPolicy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolPolicyUpdateRequestInputPolicy2 value)
        {
            return value switch
            {
                ToolPolicyUpdateRequestInputPolicy2.Blocked => "blocked",
                ToolPolicyUpdateRequestInputPolicy2.Trusted => "trusted",
                ToolPolicyUpdateRequestInputPolicy2.Untrusted => "untrusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolPolicyUpdateRequestInputPolicy2? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ToolPolicyUpdateRequestInputPolicy2.Blocked,
                "trusted" => ToolPolicyUpdateRequestInputPolicy2.Trusted,
                "untrusted" => ToolPolicyUpdateRequestInputPolicy2.Untrusted,
                _ => null,
            };
        }
    }
}