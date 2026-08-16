
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response from deleting a run
    /// </summary>
    public sealed partial class RunDeleteResponse
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Default Value: eval.run.deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunDeleteResponse" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="deleted">
        /// Default Value: true
        /// </param>
        /// <param name="object">
        /// Default Value: eval.run.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunDeleteResponse(
            string runId,
            bool? deleted,
            string? @object)
        {
            this.Deleted = deleted;
            this.Object = @object;
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunDeleteResponse" /> class.
        /// </summary>
        public RunDeleteResponse()
        {
        }

    }
}