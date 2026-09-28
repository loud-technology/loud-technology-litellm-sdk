
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum LiteLLMMCPServerTableTransport
    {
        /// <summary>
        ///
        /// </summary>
        Http,
        /// <summary>
        ///
        /// </summary>
        Sse,
        /// <summary>
        ///
        /// </summary>
        Stdio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiteLLMMCPServerTableTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteLLMMCPServerTableTransport value)
        {
            return value switch
            {
                LiteLLMMCPServerTableTransport.Http => "http",
                LiteLLMMCPServerTableTransport.Sse => "sse",
                LiteLLMMCPServerTableTransport.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteLLMMCPServerTableTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => LiteLLMMCPServerTableTransport.Http,
                "sse" => LiteLLMMCPServerTableTransport.Sse,
                "stdio" => LiteLLMMCPServerTableTransport.Stdio,
                _ => null,
            };
        }
    }
}