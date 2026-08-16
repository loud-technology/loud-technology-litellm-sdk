
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SCIMUser
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserEmail>? Emails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserGroup>? Groups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public object? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMUserName2? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schemas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Schemas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMUser" /> class.
        /// </summary>
        /// <param name="schemas"></param>
        /// <param name="active">
        /// Default Value: true
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="emails"></param>
        /// <param name="externalId"></param>
        /// <param name="groups"></param>
        /// <param name="id"></param>
        /// <param name="meta"></param>
        /// <param name="name"></param>
        /// <param name="userName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMUser(
            global::System.Collections.Generic.IList<string> schemas,
            bool? active,
            string? displayName,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserEmail>? emails,
            string? externalId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SCIMUserGroup>? groups,
            string? id,
            object? meta,
            global::Loud.Technology.LiteLLM.Sdk.SCIMUserName2? name,
            string? userName)
        {
            this.Active = active;
            this.DisplayName = displayName;
            this.Emails = emails;
            this.ExternalId = externalId;
            this.Groups = groups;
            this.Id = id;
            this.Meta = meta;
            this.Name = name;
            this.Schemas = schemas ?? throw new global::System.ArgumentNullException(nameof(schemas));
            this.UserName = userName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMUser" /> class.
        /// </summary>
        public SCIMUser()
        {
        }

    }
}