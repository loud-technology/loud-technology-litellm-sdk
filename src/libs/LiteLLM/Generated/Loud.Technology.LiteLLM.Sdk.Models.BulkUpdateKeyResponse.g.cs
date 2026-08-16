
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for bulk key update operations
    /// </summary>
    public sealed partial class BulkUpdateKeyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_requested")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalRequested { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SuccessfulKeyUpdate> SuccessfulUpdates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.FailedKeyUpdate> FailedUpdates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateKeyResponse" /> class.
        /// </summary>
        /// <param name="totalRequested"></param>
        /// <param name="successfulUpdates"></param>
        /// <param name="failedUpdates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateKeyResponse(
            int totalRequested,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.SuccessfulKeyUpdate> successfulUpdates,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.FailedKeyUpdate> failedUpdates)
        {
            this.TotalRequested = totalRequested;
            this.SuccessfulUpdates = successfulUpdates ?? throw new global::System.ArgumentNullException(nameof(successfulUpdates));
            this.FailedUpdates = failedUpdates ?? throw new global::System.ArgumentNullException(nameof(failedUpdates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateKeyResponse" /> class.
        /// </summary>
        public BulkUpdateKeyResponse()
        {
        }

    }
}