
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: sse
    /// </summary>
    public enum NewMCPServerRequestTransport
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
    public static class NewMCPServerRequestTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewMCPServerRequestTransport value)
        {
            return value switch
            {
                NewMCPServerRequestTransport.Http => "http",
                NewMCPServerRequestTransport.Sse => "sse",
                NewMCPServerRequestTransport.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewMCPServerRequestTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => NewMCPServerRequestTransport.Http,
                "sse" => NewMCPServerRequestTransport.Sse,
                "stdio" => NewMCPServerRequestTransport.Stdio,
                _ => null,
            };
        }
    }
}