
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for /policy/list endpoint.
    /// </summary>
    public sealed partial class PolicyListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.PolicySummaryItem> Policies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyListResponse" /> class.
        /// </summary>
        /// <param name="policies"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyListResponse(
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.PolicySummaryItem> policies,
            int totalCount)
        {
            this.Policies = policies ?? throw new global::System.ArgumentNullException(nameof(policies));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyListResponse" /> class.
        /// </summary>
        public PolicyListResponse()
        {
        }

    }
}