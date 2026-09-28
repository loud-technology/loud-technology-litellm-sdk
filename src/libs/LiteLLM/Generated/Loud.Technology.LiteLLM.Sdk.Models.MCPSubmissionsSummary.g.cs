
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPSubmissionsSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending_review")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PendingReview { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rejected { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPSubmissionsSummary" /> class.
        /// </summary>
        /// <param name="active"></param>
        /// <param name="items"></param>
        /// <param name="pendingReview"></param>
        /// <param name="rejected"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPSubmissionsSummary(
            int active,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMMCPServerTable> items,
            int pendingReview,
            int rejected,
            int total)
        {
            this.Active = active;
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.PendingReview = pendingReview;
            this.Rejected = rejected;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPSubmissionsSummary" /> class.
        /// </summary>
        public MCPSubmissionsSummary()
        {
        }

    }
}