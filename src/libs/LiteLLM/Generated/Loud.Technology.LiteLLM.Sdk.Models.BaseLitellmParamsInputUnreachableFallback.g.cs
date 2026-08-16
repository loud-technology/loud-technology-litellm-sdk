
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Behavior when a guardrail endpoint is unreachable due to network errors. NOTE: This is currently only implemented by guardrail='generic_guardrail_api'. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and allows the request to proceed.<br/>
    /// Default Value: fail_closed
    /// </summary>
    public enum BaseLitellmParamsInputUnreachableFallback
    {
        /// <summary>
        /// This is currently only implemented by guardrail='generic_guardrail_api'. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and allows the request to proceed.
        /// </summary>
        FailClosed,
        /// <summary>
        /// This is currently only implemented by guardrail='generic_guardrail_api'. 'fail_closed' raises an error (default). 'fail_open' logs a critical error and allows the request to proceed.
        /// </summary>
        FailOpen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseLitellmParamsInputUnreachableFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseLitellmParamsInputUnreachableFallback value)
        {
            return value switch
            {
                BaseLitellmParamsInputUnreachableFallback.FailClosed => "fail_closed",
                BaseLitellmParamsInputUnreachableFallback.FailOpen => "fail_open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseLitellmParamsInputUnreachableFallback? ToEnum(string value)
        {
            return value switch
            {
                "fail_closed" => BaseLitellmParamsInputUnreachableFallback.FailClosed,
                "fail_open" => BaseLitellmParamsInputUnreachableFallback.FailOpen,
                _ => null,
            };
        }
    }
}