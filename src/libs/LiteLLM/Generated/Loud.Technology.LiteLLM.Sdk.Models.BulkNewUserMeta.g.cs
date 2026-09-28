
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BulkNewUserMeta
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkNewUserMeta" /> class.
        /// </summary>
        /// <param name="totalRequested"></param>
        /// <param name="created"></param>
        /// <param name="failed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkNewUserMeta(
            int totalRequested,
            int created,
            int failed)
        {
            this.TotalRequested = totalRequested;
            this.Created = created;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkNewUserMeta" /> class.
        /// </summary>
        public BulkNewUserMeta()
        {
        }

    }
}