
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMCPServerRequestAuthType2
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
    public static class UpdateMCPServerRequestAuthType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMCPServerRequestAuthType2 value)
        {
            return value switch
            {
                UpdateMCPServerRequestAuthType2.ApiKey => "api_key",
                UpdateMCPServerRequestAuthType2.Authorization => "authorization",
                UpdateMCPServerRequestAuthType2.AwsSigv4 => "aws_sigv4",
                UpdateMCPServerRequestAuthType2.Basic => "basic",
                UpdateMCPServerRequestAuthType2.BearerToken => "bearer_token",
                UpdateMCPServerRequestAuthType2.None => "none",
                UpdateMCPServerRequestAuthType2.Oauth2 => "oauth2",
                UpdateMCPServerRequestAuthType2.Oauth2IdJag => "oauth2_id_jag",
                UpdateMCPServerRequestAuthType2.Oauth2TokenExchange => "oauth2_token_exchange",
                UpdateMCPServerRequestAuthType2.OauthDelegate => "oauth_delegate",
                UpdateMCPServerRequestAuthType2.Token => "token",
                UpdateMCPServerRequestAuthType2.TruePassthrough => "true_passthrough",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMCPServerRequestAuthType2? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => UpdateMCPServerRequestAuthType2.ApiKey,
                "authorization" => UpdateMCPServerRequestAuthType2.Authorization,
                "aws_sigv4" => UpdateMCPServerRequestAuthType2.AwsSigv4,
                "basic" => UpdateMCPServerRequestAuthType2.Basic,
                "bearer_token" => UpdateMCPServerRequestAuthType2.BearerToken,
                "none" => UpdateMCPServerRequestAuthType2.None,
                "oauth2" => UpdateMCPServerRequestAuthType2.Oauth2,
                "oauth2_id_jag" => UpdateMCPServerRequestAuthType2.Oauth2IdJag,
                "oauth2_token_exchange" => UpdateMCPServerRequestAuthType2.Oauth2TokenExchange,
                "oauth_delegate" => UpdateMCPServerRequestAuthType2.OauthDelegate,
                "token" => UpdateMCPServerRequestAuthType2.Token,
                "true_passthrough" => UpdateMCPServerRequestAuthType2.TruePassthrough,
                _ => null,
            };
        }
    }
}