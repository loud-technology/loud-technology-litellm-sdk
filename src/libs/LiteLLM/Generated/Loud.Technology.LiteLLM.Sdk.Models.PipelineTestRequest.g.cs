
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for testing a guardrail pipeline with sample messages.
    /// </summary>
    public sealed partial class PipelineTestRequest
    {
        /// <summary>
        /// Pipeline definition with 'mode' and 'steps'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Pipeline { get; set; }

        /// <summary>
        /// Test messages to run through the pipeline, e.g. [{'role': 'user', 'content': '...'}].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> TestMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTestRequest" /> class.
        /// </summary>
        /// <param name="pipeline">
        /// Pipeline definition with 'mode' and 'steps'.
        /// </param>
        /// <param name="testMessages">
        /// Test messages to run through the pipeline, e.g. [{'role': 'user', 'content': '...'}].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelineTestRequest(
            object pipeline,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> testMessages)
        {
            this.Pipeline = pipeline ?? throw new global::System.ArgumentNullException(nameof(pipeline));
            this.TestMessages = testMessages ?? throw new global::System.ArgumentNullException(nameof(testMessages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineTestRequest" /> class.
        /// </summary>
        public PipelineTestRequest()
        {
        }

    }
}