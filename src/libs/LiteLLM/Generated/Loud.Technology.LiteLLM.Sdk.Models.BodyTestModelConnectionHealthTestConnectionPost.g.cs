
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyTestModelConnectionHealthTestConnectionPost
    {
        /// <summary>
        /// The mode to test the model with. If not provided, auto-detected from model capabilities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPostMode2? Mode { get; set; }

        /// <summary>
        /// Parameters for litellm.completion, litellm.embedding for the health check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public object? LitellmParams { get; set; }

        /// <summary>
        /// Model info for the health check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_info")]
        public object? ModelInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTestModelConnectionHealthTestConnectionPost" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode to test the model with. If not provided, auto-detected from model capabilities.
        /// </param>
        /// <param name="litellmParams">
        /// Parameters for litellm.completion, litellm.embedding for the health check
        /// </param>
        /// <param name="modelInfo">
        /// Model info for the health check
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyTestModelConnectionHealthTestConnectionPost(
            global::Loud.Technology.LiteLLM.Sdk.BodyTestModelConnectionHealthTestConnectionPostMode2? mode,
            object? litellmParams,
            object? modelInfo)
        {
            this.Mode = mode;
            this.LitellmParams = litellmParams;
            this.ModelInfo = modelInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyTestModelConnectionHealthTestConnectionPost" /> class.
        /// </summary>
        public BodyTestModelConnectionHealthTestConnectionPost()
        {
        }

    }
}