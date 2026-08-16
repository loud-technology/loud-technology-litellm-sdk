
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SCIMGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMMember>? Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMGroup" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="schemas"></param>
        /// <param name="externalId"></param>
        /// <param name="id"></param>
        /// <param name="members"></param>
        /// <param name="meta"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMGroup(
            string displayName,
            global::System.Collections.Generic.IList<string> schemas,
            string? externalId,
            string? id,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMMember>? members,
            object? meta)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.ExternalId = externalId;
            this.Id = id;
            this.Members = members;
            this.Meta = meta;
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMGroup" /> class.
        /// </summary>
        public SCIMGroup()
        {
        }

    }
}