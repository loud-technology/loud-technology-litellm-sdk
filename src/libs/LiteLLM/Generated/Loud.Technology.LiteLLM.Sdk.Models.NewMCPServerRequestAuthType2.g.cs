
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum NewMCPServerRequestAuthType2
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
    public static class NewMCPServerRequestAuthType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NewMCPServerRequestAuthType2 value)
        {
            return value switch
            {
                NewMCPServerRequestAuthType2.ApiKey => "api_key",
                NewMCPServerRequestAuthType2.Authorization => "authorization",
                NewMCPServerRequestAuthType2.AwsSigv4 => "aws_sigv4",
                NewMCPServerRequestAuthType2.Basic => "basic",
                NewMCPServerRequestAuthType2.BearerToken => "bearer_token",
                NewMCPServerRequestAuthType2.None => "none",
                NewMCPServerRequestAuthType2.Oauth2 => "oauth2",
                NewMCPServerRequestAuthType2.Oauth2IdJag => "oauth2_id_jag",
                NewMCPServerRequestAuthType2.Oauth2TokenExchange => "oauth2_token_exchange",
                NewMCPServerRequestAuthType2.OauthDelegate => "oauth_delegate",
                NewMCPServerRequestAuthType2.Token => "token",
                NewMCPServerRequestAuthType2.TruePassthrough => "true_passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NewMCPServerRequestAuthType2? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => NewMCPServerRequestAuthType2.ApiKey,
                "authorization" => NewMCPServerRequestAuthType2.Authorization,
                "aws_sigv4" => NewMCPServerRequestAuthType2.AwsSigv4,
                "basic" => NewMCPServerRequestAuthType2.Basic,
                "bearer_token" => NewMCPServerRequestAuthType2.BearerToken,
                "none" => NewMCPServerRequestAuthType2.None,
                "oauth2" => NewMCPServerRequestAuthType2.Oauth2,
                "oauth2_id_jag" => NewMCPServerRequestAuthType2.Oauth2IdJag,
                "oauth2_token_exchange" => NewMCPServerRequestAuthType2.Oauth2TokenExchange,
                "oauth_delegate" => NewMCPServerRequestAuthType2.OauthDelegate,
                "token" => NewMCPServerRequestAuthType2.Token,
                "true_passthrough" => NewMCPServerRequestAuthType2.TruePassthrough,
                _ => null,
            };
        }
    }
}