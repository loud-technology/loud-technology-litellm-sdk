
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum MCPCredentialsTokenEndpointAuthMethod2
    {
        /// <summary>
        ///
        /// </summary>
        ClientSecretBasic,
        /// <summary>
        ///
        /// </summary>
        ClientSecretPost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPCredentialsTokenEndpointAuthMethod2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPCredentialsTokenEndpointAuthMethod2 value)
        {
            return value switch
            {
                MCPCredentialsTokenEndpointAuthMethod2.ClientSecretBasic => "client_secret_basic",
                MCPCredentialsTokenEndpointAuthMethod2.ClientSecretPost => "client_secret_post",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPCredentialsTokenEndpointAuthMethod2? ToEnum(string value)
        {
            return value switch
            {
                "client_secret_basic" => MCPCredentialsTokenEndpointAuthMethod2.ClientSecretBasic,
                "client_secret_post" => MCPCredentialsTokenEndpointAuthMethod2.ClientSecretPost,
                _ => null,
            };
        }
    }
}