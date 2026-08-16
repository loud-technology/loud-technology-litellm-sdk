
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: blocked
    /// </summary>
    public enum ToolPolicyOverrideRowInputPolicy
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
    public static class ToolPolicyOverrideRowInputPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolPolicyOverrideRowInputPolicy value)
        {
            return value switch
            {
                ToolPolicyOverrideRowInputPolicy.Blocked => "blocked",
                ToolPolicyOverrideRowInputPolicy.Trusted => "trusted",
                ToolPolicyOverrideRowInputPolicy.Untrusted => "untrusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolPolicyOverrideRowInputPolicy? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ToolPolicyOverrideRowInputPolicy.Blocked,
                "trusted" => ToolPolicyOverrideRowInputPolicy.Trusted,
                "untrusted" => ToolPolicyOverrideRowInputPolicy.Untrusted,
                _ => null,
            };
        }
    }
}