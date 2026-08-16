
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// What to do when Akto is unreachable. 'fail_open' = allow, 'fail_closed' = block.<br/>
    /// Default Value: fail_closed
    /// </summary>
    public enum LitellmParamsUnreachableFallback
    {
        /// <summary>
        /// 
        /// </summary>
        FailClosed,
        /// <summary>
        /// 
        /// </summary>
        FailOpen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LitellmParamsUnreachableFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LitellmParamsUnreachableFallback value)
        {
            return value switch
            {
                LitellmParamsUnreachableFallback.FailClosed => "fail_closed",
                LitellmParamsUnreachableFallback.FailOpen => "fail_open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LitellmParamsUnreachableFallback? ToEnum(string value)
        {
            return value switch
            {
                "fail_closed" => LitellmParamsUnreachableFallback.FailClosed,
                "fail_open" => LitellmParamsUnreachableFallback.FailOpen,
                _ => null,
            };
        }
    }
}