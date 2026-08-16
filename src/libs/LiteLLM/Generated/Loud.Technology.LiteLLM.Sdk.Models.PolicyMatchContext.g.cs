
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Context used to match a request against policies.<br/>
    /// Contains the team alias, key alias, and model from the incoming request.
    /// </summary>
    public sealed partial class PolicyMatchContext
    {
        /// <summary>
        /// API key alias from the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_alias")]
        public string? KeyAlias { get; set; }

        /// <summary>
        /// Model name from the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Tags from key/team metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Team alias from the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_alias")]
        public string? TeamAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyMatchContext" /> class.
        /// </summary>
        /// <param name="keyAlias">
        /// API key alias from the request.
        /// </param>
        /// <param name="model">
        /// Model name from the request.
        /// </param>
        /// <param name="tags">
        /// Tags from key/team metadata.
        /// </param>
        /// <param name="teamAlias">
        /// Team alias from the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyMatchContext(
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
        /// Initializes a new instance of the <see cref="PolicyMatchContext" /> class.
        /// </summary>
        public PolicyMatchContext()
        {
        }

    }
}