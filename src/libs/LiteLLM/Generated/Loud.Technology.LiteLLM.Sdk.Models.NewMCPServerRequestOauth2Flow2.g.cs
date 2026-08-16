
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum NewMCPServerRequestOauth2Flow2
    {
        /// <summary>
        /// 
        /// </summary>
        AuthorizationCode,
        /// <summary>
        /// 
        /// </summary>
        ClientCredentials,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NewMCPServerRequestOauth2Flow2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewMCPServerRequestOauth2Flow2 value)
        {
            return value switch
            {
                NewMCPServerRequestOauth2Flow2.AuthorizationCode => "authorization_code",
                NewMCPServerRequestOauth2Flow2.ClientCredentials => "client_credentials",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewMCPServerRequestOauth2Flow2? ToEnum(string value)
        {
            return value switch
            {
                "authorization_code" => NewMCPServerRequestOauth2Flow2.AuthorizationCode,
                "client_credentials" => NewMCPServerRequestOauth2Flow2.ClientCredentials,
                _ => null,
            };
        }
    }
}