
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateJWTKeyMappingRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_claim_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwtClaimName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwt_claim_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JwtClaimValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJWTKeyMappingRequest" /> class.
        /// </summary>
        /// <param name="jwtClaimName"></param>
        /// <param name="jwtClaimValue"></param>
        /// <param name="key"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateJWTKeyMappingRequest(
            string jwtClaimName,
            string jwtClaimValue,
            string key,
            string? description)
        {
            this.Description = description;
            this.JwtClaimName = jwtClaimName ?? throw new global::System.ArgumentNullException(nameof(jwtClaimName));
            this.JwtClaimValue = jwtClaimValue ?? throw new global::System.ArgumentNullException(nameof(jwtClaimValue));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateJWTKeyMappingRequest" /> class.
        /// </summary>
        public CreateJWTKeyMappingRequest()
        {
        }

    }
}