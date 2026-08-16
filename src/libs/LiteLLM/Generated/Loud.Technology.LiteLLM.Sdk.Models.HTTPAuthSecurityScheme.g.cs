
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Defines a security scheme using HTTP authentication.
    /// </summary>
    public sealed partial class HTTPAuthSecurityScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"http"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "http";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearerFormat")]
        public string? BearerFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPAuthSecurityScheme" /> class.
        /// </summary>
        /// <param name="scheme"></param>
        /// <param name="description"></param>
        /// <param name="bearerFormat"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HTTPAuthSecurityScheme(
            string scheme,
            string? description,
            string? bearerFormat,
            string type = "http")
        {
            this.Description = description;
            this.Type = type;
            this.Scheme = scheme ?? throw new global::System.ArgumentNullException(nameof(scheme));
            this.BearerFormat = bearerFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPAuthSecurityScheme" /> class.
        /// </summary>
        public HTTPAuthSecurityScheme()
        {
        }

        /// <summary>
        /// Creates a new <see cref="HTTPAuthSecurityScheme"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static HTTPAuthSecurityScheme FromScheme(string scheme)
        {
            return new HTTPAuthSecurityScheme
            {
                Scheme = scheme,
            };
        }

    }
}