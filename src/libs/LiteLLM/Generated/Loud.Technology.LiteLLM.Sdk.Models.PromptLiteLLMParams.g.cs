
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptLiteLLMParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_base")]
        public string? ApiBase { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dotprompt_content")]
        public string? DotpromptContent { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_prompt_manager_model")]
        public bool? IgnorePromptManagerModel { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_prompt_manager_optional_params")]
        public bool? IgnorePromptManagerOptionalParams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_id")]
        public string? PromptId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_integration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptIntegration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_specific_query_params")]
        public object? ProviderSpecificQueryParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptLiteLLMParams" /> class.
        /// </summary>
        /// <param name="promptIntegration"></param>
        /// <param name="apiBase"></param>
        /// <param name="apiKey"></param>
        /// <param name="dotpromptContent"></param>
        /// <param name="ignorePromptManagerModel">
        /// Default Value: false
        /// </param>
        /// <param name="ignorePromptManagerOptionalParams">
        /// Default Value: false
        /// </param>
        /// <param name="promptId"></param>
        /// <param name="providerSpecificQueryParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptLiteLLMParams(
            string promptIntegration,
            string? apiBase,
            string? apiKey,
            string? dotpromptContent,
            bool? ignorePromptManagerModel,
            bool? ignorePromptManagerOptionalParams,
            string? promptId,
            object? providerSpecificQueryParams)
        {
            this.ApiBase = apiBase;
            this.ApiKey = apiKey;
            this.DotpromptContent = dotpromptContent;
            this.IgnorePromptManagerModel = ignorePromptManagerModel;
            this.IgnorePromptManagerOptionalParams = ignorePromptManagerOptionalParams;
            this.PromptId = promptId;
            this.PromptIntegration = promptIntegration ?? throw new global::System.ArgumentNullException(nameof(promptIntegration));
            this.ProviderSpecificQueryParams = providerSpecificQueryParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptLiteLLMParams" /> class.
        /// </summary>
        public PromptLiteLLMParams()
        {
        }

    }
}