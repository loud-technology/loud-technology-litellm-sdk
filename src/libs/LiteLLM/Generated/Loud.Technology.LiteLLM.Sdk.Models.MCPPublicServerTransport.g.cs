
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPPublicServerTransport
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
    public static class MCPPublicServerTransportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPPublicServerTransport value)
        {
            return value switch
            {
                MCPPublicServerTransport.Http => "http",
                MCPPublicServerTransport.Sse => "sse",
                MCPPublicServerTransport.Stdio => "stdio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPPublicServerTransport? ToEnum(string value)
        {
            return value switch
            {
                "http" => MCPPublicServerTransport.Http,
                "sse" => MCPPublicServerTransport.Sse,
                "stdio" => MCPPublicServerTransport.Stdio,
                _ => null,
            };
        }
    }
}