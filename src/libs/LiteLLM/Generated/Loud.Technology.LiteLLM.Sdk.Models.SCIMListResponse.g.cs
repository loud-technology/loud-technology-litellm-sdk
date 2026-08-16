
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SCIMListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Resources")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUser>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMGroup>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUser>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMGroup>> Resources { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itemsPerPage")]
        public int? ItemsPerPage { get; set; }

        /// <summary>
        /// Default Value: [urn:ietf:params:scim:api:messages:2.0:ListResponse]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        public global::System.Collections.Generic.IList<string>? Schemas { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startIndex")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalResults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMListResponse" /> class.
        /// </summary>
        /// <param name="resources"></param>
        /// <param name="totalResults"></param>
        /// <param name="itemsPerPage">
        /// Default Value: 10
        /// </param>
        /// <param name="schemas">
        /// Default Value: [urn:ietf:params:scim:api:messages:2.0:ListResponse]
        /// </param>
        /// <param name="startIndex">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMListResponse(
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUser>, global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMGroup>> resources,
            int totalResults,
            int? itemsPerPage,
            global::System.Collections.Generic.IList<string>? schemas,
            int? startIndex)
        {
            this.Resources = resources;
            this.ItemsPerPage = itemsPerPage;
            this.Schemas = schemas;
            this.StartIndex = startIndex;
            this.TotalResults = totalResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMListResponse" /> class.
        /// </summary>
        public SCIMListResponse()
        {
        }

    }
}