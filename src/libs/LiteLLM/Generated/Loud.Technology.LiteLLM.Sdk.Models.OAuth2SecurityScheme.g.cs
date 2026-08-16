
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Defines a security scheme using OAuth 2.0.
    /// </summary>
    public sealed partial class OAuth2SecurityScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"oauth2"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "oauth2";

        /// <summary>
        /// Defines the configuration for the supported OAuth 2.0 flows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.OAuthFlows Flows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth2MetadataUrl")]
        public string? Oauth2MetadataUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2SecurityScheme" /> class.
        /// </summary>
        /// <param name="flows">
        /// Defines the configuration for the supported OAuth 2.0 flows.
        /// </param>
        /// <param name="description"></param>
        /// <param name="oauth2MetadataUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OAuth2SecurityScheme(
            global::Loud.Technology.LiteLLM.Sdk.OAuthFlows flows,
            string? description,
            string? oauth2MetadataUrl,
            string type = "oauth2")
        {
            this.Description = description;
            this.Type = type;
            this.Flows = flows ?? throw new global::System.ArgumentNullException(nameof(flows));
            this.Oauth2MetadataUrl = oauth2MetadataUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuth2SecurityScheme" /> class.
        /// </summary>
        public OAuth2SecurityScheme()
        {
        }

        /// <summary>
        /// Creates a new <see cref="OAuth2SecurityScheme"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static OAuth2SecurityScheme FromFlows(global::Loud.Technology.LiteLLM.Sdk.OAuthFlows flows)
        {
            return new OAuth2SecurityScheme
            {
                Flows = flows,
            };
        }

    }
}