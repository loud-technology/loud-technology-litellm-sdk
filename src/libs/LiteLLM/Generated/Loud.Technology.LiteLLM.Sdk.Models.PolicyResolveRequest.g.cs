
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for resolving effective policies/guardrails for a context.
    /// </summary>
    public sealed partial class PolicyResolveRequest
    {
        /// <summary>
        /// Key alias to resolve for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_alias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        /// Model name to resolve for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Tags to resolve for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Team alias to resolve for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_alias")]
        public string? TeamAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResolveRequest" /> class.
        /// </summary>
        /// <param name="keyAlias">
        /// Key alias to resolve for.
        /// </param>
        /// <param name="model">
        /// Model name to resolve for.
        /// </param>
        /// <param name="tags">
        /// Tags to resolve for.
        /// </param>
        /// <param name="teamAlias">
        /// Team alias to resolve for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyResolveRequest(
            string? keyAlias,
            string? model,
            global::System.Collections.Generic.IList<string>? tags,
            string? teamAlias)
        {
            this.KeyAlias = keyAlias;
            this.Model = model;
            this.Tags = tags;
            this.TeamAlias = teamAlias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyResolveRequest" /> class.
        /// </summary>
        public PolicyResolveRequest()
        {
        }

    }
}