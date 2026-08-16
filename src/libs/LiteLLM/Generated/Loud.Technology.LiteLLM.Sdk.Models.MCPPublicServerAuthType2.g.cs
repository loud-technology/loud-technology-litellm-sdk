
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPPublicServerAuthType2
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Authorization,
        /// <summary>
        /// 
        /// </summary>
        AwsSigv4,
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        BearerToken,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
        /// <summary>
        /// 
        /// </summary>
        Oauth2IdJag,
        /// <summary>
        /// 
        /// </summary>
        Oauth2TokenExchange,
        /// <summary>
        /// 
        /// </summary>
        OauthDelegate,
        /// <summary>
        /// 
        /// </summary>
        Token,
        /// <summary>
        /// 
        /// </summary>
        TruePassthrough,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPPublicServerAuthType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPPublicServerAuthType2 value)
        {
            return value switch
            {
                MCPPublicServerAuthType2.ApiKey => "api_key",
                MCPPublicServerAuthType2.Authorization => "authorization",
                MCPPublicServerAuthType2.AwsSigv4 => "aws_sigv4",
                MCPPublicServerAuthType2.Basic => "basic",
                MCPPublicServerAuthType2.BearerToken => "bearer_token",
                MCPPublicServerAuthType2.None => "none",
                MCPPublicServerAuthType2.Oauth2 => "oauth2",
                MCPPublicServerAuthType2.Oauth2IdJag => "oauth2_id_jag",
                MCPPublicServerAuthType2.Oauth2TokenExchange => "oauth2_token_exchange",
                MCPPublicServerAuthType2.OauthDelegate => "oauth_delegate",
                MCPPublicServerAuthType2.Token => "token",
                MCPPublicServerAuthType2.TruePassthrough => "true_passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPPublicServerAuthType2? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => MCPPublicServerAuthType2.ApiKey,
                "authorization" => MCPPublicServerAuthType2.Authorization,
                "aws_sigv4" => MCPPublicServerAuthType2.AwsSigv4,
                "basic" => MCPPublicServerAuthType2.Basic,
                "bearer_token" => MCPPublicServerAuthType2.BearerToken,
                "none" => MCPPublicServerAuthType2.None,
                "oauth2" => MCPPublicServerAuthType2.Oauth2,
                "oauth2_id_jag" => MCPPublicServerAuthType2.Oauth2IdJag,
                "oauth2_token_exchange" => MCPPublicServerAuthType2.Oauth2TokenExchange,
                "oauth_delegate" => MCPPublicServerAuthType2.OauthDelegate,
                "token" => MCPPublicServerAuthType2.Token,
                "true_passthrough" => MCPPublicServerAuthType2.TruePassthrough,
                _ => null,
            };
        }
    }
}