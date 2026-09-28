
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum LiteLLMMCPServerTableAuthType2
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
    public static class LiteLLMMCPServerTableAuthType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiteLLMMCPServerTableAuthType2 value)
        {
            return value switch
            {
                LiteLLMMCPServerTableAuthType2.ApiKey => "api_key",
                LiteLLMMCPServerTableAuthType2.Authorization => "authorization",
                LiteLLMMCPServerTableAuthType2.AwsSigv4 => "aws_sigv4",
                LiteLLMMCPServerTableAuthType2.Basic => "basic",
                LiteLLMMCPServerTableAuthType2.BearerToken => "bearer_token",
                LiteLLMMCPServerTableAuthType2.None => "none",
                LiteLLMMCPServerTableAuthType2.Oauth2 => "oauth2",
                LiteLLMMCPServerTableAuthType2.Oauth2IdJag => "oauth2_id_jag",
                LiteLLMMCPServerTableAuthType2.Oauth2TokenExchange => "oauth2_token_exchange",
                LiteLLMMCPServerTableAuthType2.OauthDelegate => "oauth_delegate",
                LiteLLMMCPServerTableAuthType2.Token => "token",
                LiteLLMMCPServerTableAuthType2.TruePassthrough => "true_passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiteLLMMCPServerTableAuthType2? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => LiteLLMMCPServerTableAuthType2.ApiKey,
                "authorization" => LiteLLMMCPServerTableAuthType2.Authorization,
                "aws_sigv4" => LiteLLMMCPServerTableAuthType2.AwsSigv4,
                "basic" => LiteLLMMCPServerTableAuthType2.Basic,
                "bearer_token" => LiteLLMMCPServerTableAuthType2.BearerToken,
                "none" => LiteLLMMCPServerTableAuthType2.None,
                "oauth2" => LiteLLMMCPServerTableAuthType2.Oauth2,
                "oauth2_id_jag" => LiteLLMMCPServerTableAuthType2.Oauth2IdJag,
                "oauth2_token_exchange" => LiteLLMMCPServerTableAuthType2.Oauth2TokenExchange,
                "oauth_delegate" => LiteLLMMCPServerTableAuthType2.OauthDelegate,
                "token" => LiteLLMMCPServerTableAuthType2.Token,
                "true_passthrough" => LiteLLMMCPServerTableAuthType2.TruePassthrough,
                _ => null,
            };
        }
    }
}