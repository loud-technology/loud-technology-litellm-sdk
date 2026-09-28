
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for Vantage dry-run operations (capped for preview)
    /// </summary>
    public sealed partial class VantageDryRunRequest
    {
        /// <summary>
        /// Limit on number of records to preview (default: 500)<br/>
        /// Default Value: 500
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageDryRunRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Limit on number of records to preview (default: 500)<br/>
        /// Default Value: 500
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VantageDryRunRequest(
            int? limit)
        {
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VantageDryRunRequest" /> class.
        /// </summary>
        public VantageDryRunRequest()
        {
        }

    }
}