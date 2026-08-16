
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Scope configuration for a policy.
    /// </summary>
    public sealed partial class PolicyScopeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<string>? Keys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyScopeResponse" /> class.
        /// </summary>
        /// <param name="keys"></param>
        /// <param name="models"></param>
        /// <param name="tags"></param>
        /// <param name="teams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyScopeResponse(
            global::System.Collections.Generic.IList<string>? keys,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? teams)
        {
            this.Keys = keys;
            this.Models = models;
            this.Tags = tags;
            this.Teams = teams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyScopeResponse" /> class.
        /// </summary>
        public PolicyScopeResponse()
        {
        }

    }
}