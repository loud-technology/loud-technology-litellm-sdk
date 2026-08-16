
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Whether to allow or deny this tool usage
    /// </summary>
    public enum ToolPermissionRuleDecision
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolPermissionRuleDecisionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolPermissionRuleDecision value)
        {
            return value switch
            {
                ToolPermissionRuleDecision.Allow => "allow",
                ToolPermissionRuleDecision.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolPermissionRuleDecision? ToEnum(string value)
        {
            return value switch
            {
                "allow" => ToolPermissionRuleDecision.Allow,
                "deny" => ToolPermissionRuleDecision.Deny,
                _ => null,
            };
        }
    }
}