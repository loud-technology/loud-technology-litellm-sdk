
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyTokenEndpointTokenPost
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_token_type")]
        public string? RequestedTokenType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public string? Resource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_token")]
        public string? SubjectToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_token_type")]
        public string? SubjectTokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTokenEndpointTokenPost" /> class.
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="grantType"></param>
        /// <param name="clientSecret"></param>
        /// <param name="code"></param>
        /// <param name="codeVerifier"></param>
        /// <param name="redirectUri"></param>
        /// <param name="refreshToken"></param>
        /// <param name="requestedTokenType"></param>
        /// <param name="resource"></param>
        /// <param name="scope"></param>
        /// <param name="subjectToken"></param>
        /// <param name="subjectTokenType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyTokenEndpointTokenPost(
            string clientId,
            string grantType,
            string? clientSecret,
            string? code,
            string? codeVerifier,
            string? redirectUri,
            string? refreshToken,
            string? requestedTokenType,
            string? resource,
            string? scope,
            string? subjectToken,
            string? subjectTokenType)
        {
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret;
            this.Code = code;
            this.CodeVerifier = codeVerifier;
            this.GrantType = grantType ?? throw new global::System.ArgumentNullException(nameof(grantType));
            this.RedirectUri = redirectUri;
            this.RefreshToken = refreshToken;
            this.RequestedTokenType = requestedTokenType;
            this.Resource = resource;
            this.Scope = scope;
            this.SubjectToken = subjectToken;
            this.SubjectTokenType = subjectTokenType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTokenEndpointTokenPost" /> class.
        /// </summary>
        public BodyTokenEndpointTokenPost()
        {
        }

    }
}