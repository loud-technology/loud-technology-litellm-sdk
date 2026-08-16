
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListGuardrailSubmissionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GuardrailSubmissionItem> Submissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.GuardrailSubmissionSummary Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGuardrailSubmissionsResponse" /> class.
        /// </summary>
        /// <param name="submissions"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGuardrailSubmissionsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.GuardrailSubmissionItem> submissions,
            global::Loud.Technology.LiteLLM.Sdk.GuardrailSubmissionSummary summary)
        {
            this.Submissions = submissions ?? throw new global::System.ArgumentNullException(nameof(submissions));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGuardrailSubmissionsResponse" /> class.
        /// </summary>
        public ListGuardrailSubmissionsResponse()
        {
        }

    }
}