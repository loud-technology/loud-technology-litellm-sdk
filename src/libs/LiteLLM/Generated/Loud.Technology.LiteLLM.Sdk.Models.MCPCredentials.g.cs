
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPCredentials
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_value")]
        public string? AuthValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region_name")]
        public string? AwsRegionName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_name")]
        public string? AwsRoleName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_service_name")]
        public string? AwsServiceName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_name")]
        public string? AwsSessionName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_token")]
        public string? AwsSessionToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_assertion_signing_alg")]
        public string? ClientAssertionSigningAlg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_private_key")]
        public string? ClientPrivateKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_private_key_id")]
        public string? ClientPrivateKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_jag_resource")]
        public string? IdJagResource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_jag_resource_token_endpoint")]
        public string? IdJagResourceTokenEndpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_token_type")]
        public string? SubjectTokenType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_method")]
        public global::Loud.Technology.LiteLLM.Sdk.MCPCredentialsTokenEndpointAuthMethod2? TokenEndpointAuthMethod { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_exchange_endpoint")]
        public string? TokenExchangeEndpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_exchange_profile")]
        public string? TokenExchangeProfile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_resource")]
        public string? UpstreamResource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_token_header")]
        public string? UpstreamTokenHeader { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPCredentials" /> class.
        /// </summary>
        /// <param name="audience"></param>
        /// <param name="authValue"></param>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsRegionName"></param>
        /// <param name="awsRoleName"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="awsServiceName"></param>
        /// <param name="awsSessionName"></param>
        /// <param name="awsSessionToken"></param>
        /// <param name="clientAssertionSigningAlg"></param>
        /// <param name="clientId"></param>
        /// <param name="clientPrivateKey"></param>
        /// <param name="clientPrivateKeyId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="idJagResource"></param>
        /// <param name="idJagResourceTokenEndpoint"></param>
        /// <param name="redirectUris"></param>
        /// <param name="scopes"></param>
        /// <param name="subjectTokenType"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
        /// <param name="tokenExchangeEndpoint"></param>
        /// <param name="tokenExchangeProfile"></param>
        /// <param name="upstreamResource"></param>
        /// <param name="upstreamTokenHeader"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPCredentials(
            string? audience,
            string? authValue,
            string? awsAccessKeyId,
            string? awsRegionName,
            string? awsRoleName,
            string? awsSecretAccessKey,
            string? awsServiceName,
            string? awsSessionName,
            string? awsSessionToken,
            string? clientAssertionSigningAlg,
            string? clientId,
            string? clientPrivateKey,
            string? clientPrivateKeyId,
            string? clientSecret,
            string? idJagResource,
            string? idJagResourceTokenEndpoint,
            global::System.Collections.Generic.IList<string>? redirectUris,
            global::System.Collections.Generic.IList<string>? scopes,
            string? subjectTokenType,
            global::Loud.Technology.LiteLLM.Sdk.MCPCredentialsTokenEndpointAuthMethod2? tokenEndpointAuthMethod,
            string? tokenExchangeEndpoint,
            string? tokenExchangeProfile,
            string? upstreamResource,
            string? upstreamTokenHeader)
        {
            this.Audience = audience;
            this.AuthValue = authValue;
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsRegionName = awsRegionName;
            this.AwsRoleName = awsRoleName;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.AwsServiceName = awsServiceName;
            this.AwsSessionName = awsSessionName;
            this.AwsSessionToken = awsSessionToken;
            this.ClientAssertionSigningAlg = clientAssertionSigningAlg;
            this.ClientId = clientId;
            this.ClientPrivateKey = clientPrivateKey;
            this.ClientPrivateKeyId = clientPrivateKeyId;
            this.ClientSecret = clientSecret;
            this.IdJagResource = idJagResource;
            this.IdJagResourceTokenEndpoint = idJagResourceTokenEndpoint;
            this.RedirectUris = redirectUris;
            this.Scopes = scopes;
            this.SubjectTokenType = subjectTokenType;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
            this.TokenExchangeEndpoint = tokenExchangeEndpoint;
            this.TokenExchangeProfile = tokenExchangeProfile;
            this.UpstreamResource = upstreamResource;
            this.UpstreamTokenHeader = upstreamTokenHeader;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPCredentials" /> class.
        /// </summary>
        public MCPCredentials()
        {
        }

    }
}