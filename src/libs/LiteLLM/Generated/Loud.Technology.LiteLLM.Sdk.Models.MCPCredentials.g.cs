
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
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPCredentials" /> class.
        /// </summary>
        /// <param name="authValue"></param>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsRegionName"></param>
        /// <param name="awsRoleName"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="awsServiceName"></param>
        /// <param name="awsSessionName"></param>
        /// <param name="awsSessionToken"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="scopes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPCredentials(
            string? authValue,
            string? awsAccessKeyId,
            string? awsRegionName,
            string? awsRoleName,
            string? awsSecretAccessKey,
            string? awsServiceName,
            string? awsSessionName,
            string? awsSessionToken,
            string? clientId,
            string? clientSecret,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.AuthValue = authValue;
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsRegionName = awsRegionName;
            this.AwsRoleName = awsRoleName;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.AwsServiceName = awsServiceName;
            this.AwsSessionName = awsSessionName;
            this.AwsSessionToken = awsSessionToken;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPCredentials" /> class.
        /// </summary>
        public MCPCredentials()
        {
        }

    }
}