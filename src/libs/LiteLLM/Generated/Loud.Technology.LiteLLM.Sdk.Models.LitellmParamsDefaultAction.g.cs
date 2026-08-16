
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Fallback decision when no rule matches<br/>
    /// Default Value: deny
    /// </summary>
    public enum LitellmParamsDefaultAction
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
    public static class LitellmParamsDefaultActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsDefaultAction value)
        {
            return value switch
            {
                LitellmParamsDefaultAction.Allow => "allow",
                LitellmParamsDefaultAction.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsDefaultAction? ToEnum(string value)
        {
            return value switch
            {
                "allow" => LitellmParamsDefaultAction.Allow,
                "deny" => LitellmParamsDefaultAction.Deny,
                _ => null,
            };
        }
    }
}