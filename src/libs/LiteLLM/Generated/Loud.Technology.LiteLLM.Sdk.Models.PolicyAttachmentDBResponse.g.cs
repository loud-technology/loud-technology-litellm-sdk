
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for a policy attachment from the database.
    /// </summary>
    public sealed partial class PolicyAttachmentDBResponse
    {
        /// <summary>
        /// Unique ID of the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AttachmentId { get; set; }

        /// <summary>
        /// When the attachment was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Who created the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Where this attachment is defined: 'db' (database) or 'config' (config.yaml).<br/>
        /// Default Value: db
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.PolicyAttachmentDBResponseDefinitionLocationJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponseDefinitionLocation? DefinitionLocation { get; set; }

        /// <summary>
        /// Key patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<string>? Keys { get; set; }

        /// <summary>
        /// Model patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Name of the attached policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PolicyName { get; set; }

        /// <summary>
        /// Scope of the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Tag patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Team patterns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// When the attachment was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Who last updated the attachment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyAttachmentDBResponse" /> class.
        /// </summary>
        /// <param name="attachmentId">
        /// Unique ID of the attachment.
        /// </param>
        /// <param name="policyName">
        /// Name of the attached policy.
        /// </param>
        /// <param name="createdAt">
        /// When the attachment was created.
        /// </param>
        /// <param name="createdBy">
        /// Who created the attachment.
        /// </param>
        /// <param name="definitionLocation">
        /// Where this attachment is defined: 'db' (database) or 'config' (config.yaml).<br/>
        /// Default Value: db
        /// </param>
        /// <param name="keys">
        /// Key patterns.
        /// </param>
        /// <param name="models">
        /// Model patterns.
        /// </param>
        /// <param name="scope">
        /// Scope of the attachment.
        /// </param>
        /// <param name="tags">
        /// Tag patterns.
        /// </param>
        /// <param name="teams">
        /// Team patterns.
        /// </param>
        /// <param name="updatedAt">
        /// When the attachment was last updated.
        /// </param>
        /// <param name="updatedBy">
        /// Who last updated the attachment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyAttachmentDBResponse(
            string attachmentId,
            string policyName,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponseDefinitionLocation? definitionLocation,
            global::System.Collections.Generic.IList<string>? keys,
            global::System.Collections.Generic.IList<string>? models,
            string? scope,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? teams,
            global::System.DateTime? updatedAt,
            string? updatedBy)
        {
            this.AttachmentId = attachmentId ?? throw new global::System.ArgumentNullException(nameof(attachmentId));
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DefinitionLocation = definitionLocation;
            this.Keys = keys;
            this.Models = models;
            this.PolicyName = policyName ?? throw new global::System.ArgumentNullException(nameof(policyName));
            this.Scope = scope;
            this.Tags = tags;
            this.Teams = teams;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyAttachmentDBResponse" /> class.
        /// </summary>
        public PolicyAttachmentDBResponse()
        {
        }

    }
}