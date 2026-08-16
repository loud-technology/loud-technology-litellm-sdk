
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolPolicyUpdateResponseInputPolicy2
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
    public static class ToolPolicyUpdateResponseInputPolicy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolPolicyUpdateResponseInputPolicy2 value)
        {
            return value switch
            {
                ToolPolicyUpdateResponseInputPolicy2.Blocked => "blocked",
                ToolPolicyUpdateResponseInputPolicy2.Trusted => "trusted",
                ToolPolicyUpdateResponseInputPolicy2.Untrusted => "untrusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolPolicyUpdateResponseInputPolicy2? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ToolPolicyUpdateResponseInputPolicy2.Blocked,
                "trusted" => ToolPolicyUpdateResponseInputPolicy2.Trusted,
                "untrusted" => ToolPolicyUpdateResponseInputPolicy2.Untrusted,
                _ => null,
            };
        }
    }
}