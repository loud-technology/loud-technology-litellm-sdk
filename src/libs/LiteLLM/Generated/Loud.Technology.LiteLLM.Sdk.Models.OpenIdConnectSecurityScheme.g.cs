
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Defines a security scheme using OpenID Connect.
    /// </summary>
    public sealed partial class OpenIdConnectSecurityScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"openIdConnect"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "openIdConnect";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openIdConnectUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OpenIdConnectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenIdConnectSecurityScheme" /> class.
        /// </summary>
        /// <param name="openIdConnectUrl"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenIdConnectSecurityScheme(
            string openIdConnectUrl,
            string? description,
            string type = "openIdConnect")
        {
            this.Description = description;
            this.Type = type;
            this.OpenIdConnectUrl = openIdConnectUrl ?? throw new global::System.ArgumentNullException(nameof(openIdConnectUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenIdConnectSecurityScheme" /> class.
        /// </summary>
        public OpenIdConnectSecurityScheme()
        {
        }

        /// <summary>
        /// Creates a new <see cref="OpenIdConnectSecurityScheme"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static OpenIdConnectSecurityScheme FromOpenIdConnectUrl(string openIdConnectUrl)
        {
            return new OpenIdConnectSecurityScheme
            {
                OpenIdConnectUrl = openIdConnectUrl,
            };
        }

    }
}