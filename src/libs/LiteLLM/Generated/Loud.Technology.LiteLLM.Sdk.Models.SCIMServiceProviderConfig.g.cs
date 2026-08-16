
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SCIMServiceProviderConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationSchemes")]
        public global::System.Collections.Generic.IList<object>? AuthenticationSchemes { get; set; }

        /// <summary>
        /// Default Value: {"supported":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bulk")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? Bulk { get; set; }

        /// <summary>
        /// Default Value: {"supported":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changePassword")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? ChangePassword { get; set; }

        /// <summary>
        /// Default Value: {"supported":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("etag")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? Etag { get; set; }

        /// <summary>
        /// Default Value: {"supported":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// Default Value: {"supported":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patch")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? Patch { get; set; }

        /// <summary>
        /// Default Value: [urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        public global::System.Collections.Generic.IList<string>? Schemas { get; set; }

        /// <summary>
        /// Default Value: {"supported":false}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? Sort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMServiceProviderConfig" /> class.
        /// </summary>
        /// <param name="authenticationSchemes"></param>
        /// <param name="bulk">
        /// Default Value: {"supported":false}
        /// </param>
        /// <param name="changePassword">
        /// Default Value: {"supported":false}
        /// </param>
        /// <param name="etag">
        /// Default Value: {"supported":false}
        /// </param>
        /// <param name="filter">
        /// Default Value: {"supported":false}
        /// </param>
        /// <param name="meta"></param>
        /// <param name="patch">
        /// Default Value: {"supported":true}
        /// </param>
        /// <param name="schemas">
        /// Default Value: [urn:ietf:params:scim:schemas:core:2.0:ServiceProviderConfig]
        /// </param>
        /// <param name="sort">
        /// Default Value: {"supported":false}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMServiceProviderConfig(
            global::System.Collections.Generic.IList<object>? authenticationSchemes,
            global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? bulk,
            global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? changePassword,
            global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? etag,
            global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? filter,
            object? meta,
            global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? patch,
            global::System.Collections.Generic.IList<string>? schemas,
            global::Loud.Technology.LiteLLM.Sdk.SCIMFeature? sort)
        {
            this.AuthenticationSchemes = authenticationSchemes;
            this.Bulk = bulk;
            this.ChangePassword = changePassword;
            this.Etag = etag;
            this.Filter = filter;
            this.Meta = meta;
            this.Patch = patch;
            this.Schemas = schemas;
            this.Sort = sort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMServiceProviderConfig" /> class.
        /// </summary>
        public SCIMServiceProviderConfig()
        {
        }

    }
}