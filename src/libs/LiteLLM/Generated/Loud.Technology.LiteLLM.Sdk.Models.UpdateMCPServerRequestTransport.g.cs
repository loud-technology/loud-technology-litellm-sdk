
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: sse
    /// </summary>
    public enum UpdateMCPServerRequestTransport
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
    public static class UpdateMCPServerRequestTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMCPServerRequestTransport value)
        {
            return value switch
            {
                UpdateMCPServerRequestTransport.Http => "http",
                UpdateMCPServerRequestTransport.Sse => "sse",
                UpdateMCPServerRequestTransport.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMCPServerRequestTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => UpdateMCPServerRequestTransport.Http,
                "sse" => UpdateMCPServerRequestTransport.Sse,
                "stdio" => UpdateMCPServerRequestTransport.Stdio,
                _ => null,
            };
        }
    }
}