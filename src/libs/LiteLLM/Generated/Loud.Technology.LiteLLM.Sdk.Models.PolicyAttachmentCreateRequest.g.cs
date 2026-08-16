
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for creating a policy attachment.
    /// </summary>
    public sealed partial class PolicyAttachmentCreateRequest
    {
        /// <summary>
        /// Key aliases or patterns this attachment applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<string>? Keys { get; set; }

        /// <summary>
        /// Model names or patterns this attachment applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Name of the policy to attach.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PolicyName { get; set; }

        /// <summary>
        /// Use '*' for global scope (applies to all requests).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Tag patterns this attachment applies to. Supports wildcards (e.g., health-*).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Team aliases or patterns this attachment applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyAttachmentCreateRequest" /> class.
        /// </summary>
        /// <param name="policyName">
        /// Name of the policy to attach.
        /// </param>
        /// <param name="keys">
        /// Key aliases or patterns this attachment applies to.
        /// </param>
        /// <param name="models">
        /// Model names or patterns this attachment applies to.
        /// </param>
        /// <param name="scope">
        /// Use '*' for global scope (applies to all requests).
        /// </param>
        /// <param name="tags">
        /// Tag patterns this attachment applies to. Supports wildcards (e.g., health-*).
        /// </param>
        /// <param name="teams">
        /// Team aliases or patterns this attachment applies to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyAttachmentCreateRequest(
            string policyName,
            global::System.Collections.Generic.IList<string>? keys,
            global::System.Collections.Generic.IList<string>? models,
            string? scope,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? teams)
        {
            this.Keys = keys;
            this.Models = models;
            this.PolicyName = policyName ?? throw new global::System.ArgumentNullException(nameof(policyName));
            this.Scope = scope;
            this.Tags = tags;
            this.Teams = teams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyAttachmentCreateRequest" /> class.
        /// </summary>
        public PolicyAttachmentCreateRequest()
        {
        }

    }
}