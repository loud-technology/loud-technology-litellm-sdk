
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateFileFilesPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Purpose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_model_names")]
        public string? TargetModelNames { get; set; }

        /// <summary>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_storage")]
        public string? TargetStorage { get; set; }

        /// <summary>
        /// Default Value: openai
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_provider")]
        public string? CustomLlmProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_metadata")]
        public string? LitellmMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateFileFilesPost" /> class.
        /// </summary>
        /// <param name="purpose"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="targetModelNames"></param>
        /// <param name="targetStorage">
        /// Default Value: default
        /// </param>
        /// <param name="customLlmProvider">
        /// Default Value: openai
        /// </param>
        /// <param name="litellmMetadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateFileFilesPost(
            string purpose,
            byte[] file,
            string filename,
            string? targetModelNames,
            string? targetStorage,
            string? customLlmProvider,
            string? litellmMetadata)
        {
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.TargetModelNames = targetModelNames;
            this.TargetStorage = targetStorage;
            this.CustomLlmProvider = customLlmProvider;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.LitellmMetadata = litellmMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateFileFilesPost" /> class.
        /// </summary>
        public BodyCreateFileFilesPost()
        {
        }

    }
}