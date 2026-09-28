
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for listing policies from the database.
    /// </summary>
    public sealed partial class PolicyListDBResponse
    {
        /// <summary>
        /// List of policies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse>? Policies { get; set; }

        /// <summary>
        /// Total number of policies.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyListDBResponse" /> class.
        /// </summary>
        /// <param name="policies">
        /// List of policies.
        /// </param>
        /// <param name="totalCount">
        /// Total number of policies.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyListDBResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyDBResponse>? policies,
            int? totalCount)
        {
            this.Policies = policies;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyListDBResponse" /> class.
        /// </summary>
        public PolicyListDBResponse()
        {
        }

    }
}