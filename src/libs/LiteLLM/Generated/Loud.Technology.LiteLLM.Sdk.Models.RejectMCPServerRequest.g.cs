
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RejectMCPServerRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review_notes")]
        public string? ReviewNotes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectMCPServerRequest" /> class.
        /// </summary>
        /// <param name="reviewNotes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RejectMCPServerRequest(
            string? reviewNotes)
        {
            this.ReviewNotes = reviewNotes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RejectMCPServerRequest" /> class.
        /// </summary>
        public RejectMCPServerRequest()
        {
        }

    }
}