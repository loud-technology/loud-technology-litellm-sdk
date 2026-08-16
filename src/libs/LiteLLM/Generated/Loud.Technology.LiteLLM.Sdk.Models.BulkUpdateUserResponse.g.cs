
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response for bulk user update operations
    /// </summary>
    public sealed partial class BulkUpdateUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UserUpdateResult> Results { get; set; }

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
        public required int SuccessfulUpdates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedUpdates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateUserResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="totalRequested"></param>
        /// <param name="successfulUpdates"></param>
        /// <param name="failedUpdates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateUserResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UserUpdateResult> results,
            int totalRequested,
            int successfulUpdates,
            int failedUpdates)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TotalRequested = totalRequested;
            this.SuccessfulUpdates = successfulUpdates;
            this.FailedUpdates = failedUpdates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateUserResponse" /> class.
        /// </summary>
        public BulkUpdateUserResponse()
        {
        }

    }
}