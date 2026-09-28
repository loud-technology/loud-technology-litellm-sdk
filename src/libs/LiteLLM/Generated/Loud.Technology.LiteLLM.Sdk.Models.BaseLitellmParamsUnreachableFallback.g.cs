
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Behavior when a guardrail endpoint is unreachable due to network errors. Implemented by guardrail='generic_guardrail_api', 'agent_365', 'akto', 'vigil_guard', 'repelloai', 'headroom', 'compresr', and 'typesafe'. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and allows the request to proceed.<br/>
    /// Default Value: fail_closed
    /// </summary>
    public enum BaseLitellmParamsUnreachableFallback
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
    public static class BaseLitellmParamsUnreachableFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseLitellmParamsUnreachableFallback value)
        {
            return value switch
            {
                BaseLitellmParamsUnreachableFallback.FailClosed => "fail_closed",
                BaseLitellmParamsUnreachableFallback.FailOpen => "fail_open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseLitellmParamsUnreachableFallback? ToEnum(string value)
        {
            return value switch
            {
                "fail_closed" => BaseLitellmParamsUnreachableFallback.FailClosed,
                "fail_open" => BaseLitellmParamsUnreachableFallback.FailOpen,
                _ => null,
            };
        }
    }
}