
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for listing policy attachments.
    /// </summary>
    public sealed partial class PolicyAttachmentListResponse
    {
        /// <summary>
        /// List of policy attachments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponse>? Attachments { get; set; }

        /// <summary>
        /// Total number of attachments.<br/>
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
        /// Initializes a new instance of the <see cref="PolicyAttachmentListResponse" /> class.
        /// </summary>
        /// <param name="attachments">
        /// List of policy attachments.
        /// </param>
        /// <param name="totalCount">
        /// Total number of attachments.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyAttachmentListResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PolicyAttachmentDBResponse>? attachments,
            int? totalCount)
        {
            this.Attachments = attachments;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyAttachmentListResponse" /> class.
        /// </summary>
        public PolicyAttachmentListResponse()
        {
        }

    }
}