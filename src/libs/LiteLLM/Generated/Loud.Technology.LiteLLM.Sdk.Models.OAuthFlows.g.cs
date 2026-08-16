
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Defines the configuration for the supported OAuth 2.0 flows.
    /// </summary>
    public sealed partial class OAuthFlows
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorizationCode")]
        public object? AuthorizationCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientCredentials")]
        public object? ClientCredentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("implicit")]
        public object? Implicit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public object? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthFlows" /> class.
        /// </summary>
        /// <param name="authorizationCode"></param>
        /// <param name="clientCredentials"></param>
        /// <param name="implicit"></param>
        /// <param name="password"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuthFlows(
            object? authorizationCode,
            object? clientCredentials,
            object? @implicit,
            object? password)
        {
            this.AuthorizationCode = authorizationCode;
            this.ClientCredentials = clientCredentials;
            this.Implicit = @implicit;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthFlows" /> class.
        /// </summary>
        public OAuthFlows()
        {
        }

    }
}