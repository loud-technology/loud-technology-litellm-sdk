
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// LiteLLM Params with 'model' requirement - used for completions
    /// </summary>
    public sealed partial class LiteLLMParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token")]
        public double? InputCostPerToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token")]
        public double? OutputCostPerToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_character")]
        public double? InputCostPerCharacter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_character")]
        public double? OutputCostPerCharacter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost")]
        public double? CacheReadInputTokenCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost")]
        public double? CacheCreationInputTokenCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiered_pricing")]
        public global::System.Collections.Generic.IList<object>? TieredPricing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_second")]
        public double? InputCostPerSecond { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_second")]
        public double? OutputCostPerSecond { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_second_1080p")]
        public double? OutputCostPerSecond1080p { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_second_480p")]
        public double? OutputCostPerSecond480p { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_second_720p")]
        public double? OutputCostPerSecond720p { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_second_768p")]
        public double? OutputCostPerSecond768p { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_second_2k")]
        public double? OutputCostPerSecond2k { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_second_4k")]
        public double? OutputCostPerSecond4k { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_image_512")]
        public double? OutputCostPerImage512 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_image_1024")]
        public double? OutputCostPerImage1024 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_image_1536")]
        public double? OutputCostPerImage1536 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_pixel")]
        public double? InputCostPerPixel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_pixel")]
        public double? OutputCostPerPixel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_flex")]
        public double? InputCostPerTokenFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_priority")]
        public double? InputCostPerTokenPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_ultrafast")]
        public double? InputCostPerTokenUltrafast { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_above_1hr")]
        public double? CacheCreationInputTokenCostAbove1hr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_above_200k_tokens")]
        public double? CacheCreationInputTokenCostAbove200kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_above_272k_tokens")]
        public double? CacheCreationInputTokenCostAbove272kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_above_272k_tokens_priority")]
        public double? CacheCreationInputTokenCostAbove272kTokensPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_above_272k_tokens_flex")]
        public double? CacheCreationInputTokenCostAbove272kTokensFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_flex")]
        public double? CacheCreationInputTokenCostFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_priority")]
        public double? CacheCreationInputTokenCostPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_ultrafast")]
        public double? CacheCreationInputTokenCostUltrafast { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_audio_token_cost")]
        public double? CacheCreationInputAudioTokenCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_flex")]
        public double? CacheReadInputTokenCostFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_priority")]
        public double? CacheReadInputTokenCostPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_ultrafast")]
        public double? CacheReadInputTokenCostUltrafast { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_above_200k_tokens")]
        public double? CacheReadInputTokenCostAbove200kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_above_200k_tokens_priority")]
        public double? CacheReadInputTokenCostAbove200kTokensPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_above_272k_tokens_priority")]
        public double? CacheReadInputTokenCostAbove272kTokensPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_above_272k_tokens_flex")]
        public double? CacheReadInputTokenCostAbove272kTokensFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_batches")]
        public double? CacheReadInputTokenCostBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_above_272k_tokens_batches")]
        public double? CacheReadInputTokenCostAbove272kTokensBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_batches")]
        public double? CacheCreationInputTokenCostBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_token_cost_above_272k_tokens_batches")]
        public double? CacheCreationInputTokenCostAbove272kTokensBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_audio_token_cost")]
        public double? CacheReadInputAudioTokenCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_image_token_cost")]
        public double? CacheReadInputImageTokenCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_character_above_128k_tokens")]
        public double? InputCostPerCharacterAbove128kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_audio_token")]
        public double? InputCostPerAudioToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_cache_hit")]
        public double? InputCostPerTokenCacheHit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_above_128k_tokens")]
        public double? InputCostPerTokenAbove128kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_above_200k_tokens")]
        public double? InputCostPerTokenAbove200kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_above_200k_tokens_priority")]
        public double? InputCostPerTokenAbove200kTokensPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_above_272k_tokens_priority")]
        public double? InputCostPerTokenAbove272kTokensPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_above_272k_tokens_flex")]
        public double? InputCostPerTokenAbove272kTokensFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_above_272k_tokens_batches")]
        public double? InputCostPerTokenAbove272kTokensBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_query")]
        public double? InputCostPerQuery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_image")]
        public double? InputCostPerImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_image_above_128k_tokens")]
        public double? InputCostPerImageAbove128kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_audio_per_second")]
        public double? InputCostPerAudioPerSecond { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_audio_per_second_above_128k_tokens")]
        public double? InputCostPerAudioPerSecondAbove128kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_video_per_second")]
        public double? InputCostPerVideoPerSecond { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_video_per_second_above_128k_tokens")]
        public double? InputCostPerVideoPerSecondAbove128kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_video_per_second_above_15s_interval")]
        public double? InputCostPerVideoPerSecondAbove15sInterval { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_video_per_second_above_8s_interval")]
        public double? InputCostPerVideoPerSecondAbove8sInterval { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_audio_token_batches")]
        public double? InputCostPerAudioTokenBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_image_token_batches")]
        public double? InputCostPerImageTokenBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_batches")]
        public double? InputCostPerTokenBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_video_token_batches")]
        public double? InputCostPerVideoTokenBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_batches")]
        public double? OutputCostPerTokenBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_flex")]
        public double? OutputCostPerTokenFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_priority")]
        public double? OutputCostPerTokenPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_ultrafast")]
        public double? OutputCostPerTokenUltrafast { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_audio_token")]
        public double? OutputCostPerAudioToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_above_128k_tokens")]
        public double? OutputCostPerTokenAbove128kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_above_200k_tokens")]
        public double? OutputCostPerTokenAbove200kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_above_200k_tokens_priority")]
        public double? OutputCostPerTokenAbove200kTokensPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_above_272k_tokens_priority")]
        public double? OutputCostPerTokenAbove272kTokensPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_above_272k_tokens_flex")]
        public double? OutputCostPerTokenAbove272kTokensFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_above_272k_tokens_batches")]
        public double? OutputCostPerTokenAbove272kTokensBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_character_above_128k_tokens")]
        public double? OutputCostPerCharacterAbove128kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_image")]
        public double? OutputCostPerImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_image_token")]
        public double? OutputCostPerImageToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_video_token")]
        public double? OutputCostPerVideoToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_reasoning_token")]
        public double? OutputCostPerReasoningToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_reasoning_token_flex")]
        public double? OutputCostPerReasoningTokenFlex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_reasoning_token_priority")]
        public double? OutputCostPerReasoningTokenPriority { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_video_per_second")]
        public double? OutputCostPerVideoPerSecond { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_audio_per_second")]
        public double? OutputCostPerAudioPerSecond { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_cost_per_query")]
        public object? SearchContextCostPerQuery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google_maps_grounding_cost_per_query")]
        public double? GoogleMapsGroundingCostPerQuery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation_cost_per_token")]
        public double? CitationCostPerToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_above_272k_tokens")]
        public double? CacheReadInputTokenCostAbove272kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_token_cost_above_512k_tokens")]
        public double? CacheReadInputTokenCostAbove512kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_image_token")]
        public double? InputCostPerImageToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_video_token")]
        public double? InputCostPerVideoToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_above_272k_tokens")]
        public double? InputCostPerTokenAbove272kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token_above_512k_tokens")]
        public double? InputCostPerTokenAbove512kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_above_272k_tokens")]
        public double? OutputCostPerTokenAbove272kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token_above_512k_tokens")]
        public double? OutputCostPerTokenAbove512kTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_vector_size")]
        public int? OutputVectorSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_cost_per_page")]
        public double? OcrCostPerPage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_cost_per_page_batches")]
        public double? OcrCostPerPageBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_cost_per_credit")]
        public double? OcrCostPerCredit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_cost_per_page")]
        public double? AnnotationCostPerPage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_cost_per_page_batches")]
        public double? AnnotationCostPerPageBatches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regional_processing_uplift_multiplier_eu")]
        public double? RegionalProcessingUpliftMultiplierEu { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regional_processing_uplift_multiplier_us")]
        public double? RegionalProcessingUpliftMultiplierUs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regional_endpoint_uplift_multiplier")]
        public double? RegionalEndpointUpliftMultiplier { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_base")]
        public string? ApiBase { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_ad_token")]
        public string? AzureAdToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_scope")]
        public string? AzureScope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_username")]
        public string? AzureUsername { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_password")]
        public string? AzurePassword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_project")]
        public string? VertexProject { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_location")]
        public string? VertexLocation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertex_credentials")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, object, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, object>? VertexCredentials { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_name")]
        public string? RegionName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcs_bucket_name")]
        public string? GcsBucketName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_access_key_id")]
        public string? AwsAccessKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_secret_access_key")]
        public string? AwsSecretAccessKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_token")]
        public string? AwsSessionToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_region_name")]
        public string? AwsRegionName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_name")]
        public string? AwsSessionName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_profile_name")]
        public string? AwsProfileName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_role_name")]
        public string? AwsRoleName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_web_identity_token")]
        public string? AwsWebIdentityToken { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_sts_endpoint")]
        public string? AwsStsEndpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_external_id")]
        public string? AwsExternalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_session_tags")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AwsSessionTag>? AwsSessionTags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_bedrock_runtime_endpoint")]
        public string? AwsBedrockRuntimeEndpoint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_bedrock_project_id")]
        public string? AwsBedrockProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_bucket_name")]
        public string? S3BucketName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_endpoint_url")]
        public string? S3EndpointUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_region_name")]
        public string? S3RegionName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_access_key_id")]
        public string? S3AccessKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_secret_access_key")]
        public string? S3SecretAccessKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_encryption_key_id")]
        public string? S3EncryptionKeyId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_bucket_owner")]
        public string? S3BucketOwner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_batch_role_arn")]
        public string? AwsBatchRoleArn { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_output_bucket_name")]
        public string? S3OutputBucketName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bedrock_tags")]
        public global::System.Collections.Generic.IList<object>? BedrockTags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("watsonx_region_name")]
        public string? WatsonxRegionName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_llm_provider")]
        public string? CustomLlmProvider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tpm")]
        public int? Tpm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpm")]
        public int? Rpm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("itpm")]
        public int? Itpm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otpm")]
        public int? Otpm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<double?, string, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<double?, string, object>? Timeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_timeout")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<double?, string, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<double?, string, object>? StreamTimeout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("drop_params")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<bool?, string, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<bool?, string, object>? DropParams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public string? Organization { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configurable_clientside_auth_params")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::Loud.Technology.LiteLLM.Sdk.ConfigurableClientsideParamsCustomAuthInput>>? ConfigurableClientsideAuthParams { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_credential_name")]
        public string? LitellmCredentialName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_affinity_header")]
        public string? ProviderAffinityHeader { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_trace_id")]
        public string? LitellmTraceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_file_size_mb")]
        public double? MaxFileSizeMb { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_api_key_tpm_limit")]
        public int? DefaultApiKeyTpmLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_api_key_rpm_limit")]
        public int? DefaultApiKeyRpmLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_budget")]
        public double? MaxBudget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget_duration")]
        public string? BudgetDuration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepalive_seconds")]
        public double? KeepaliveSeconds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_client_keepalive_override")]
        public bool? AllowClientKeepaliveOverride { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_in_pass_through")]
        public bool? UseInPassThrough { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_litellm_proxy")]
        public bool? UseLitellmProxy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_chat_completions_api")]
        public bool? UseChatCompletionsApi { get; set; }

        /// <summary>
        /// Use stored xAI OAuth credentials when no xAI API key is configured.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_xai_oauth")]
        public bool? UseXaiOauth { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_reasoning_content_in_choices")]
        public bool? MergeReasoningContentInChoices { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_info")]
        public object? ModelInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mock_response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.AnyOfJsonConverter<string, global::Loud.Technology.LiteLLM.Sdk.ModelResponse, object, object>))]
        public global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::Loud.Technology.LiteLLM.Sdk.ModelResponse, object, object>? MockResponse { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_regex")]
        public global::System.Collections.Generic.IList<string>? TagRegex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_router_config_path")]
        public string? AutoRouterConfigPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_router_config")]
        public string? AutoRouterConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_router_default_model")]
        public string? AutoRouterDefaultModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_router_embedding_model")]
        public string? AutoRouterEmbeddingModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_router_max_input_chars")]
        public int? AutoRouterMaxInputChars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_router_routing_compression")]
        public string? AutoRouterRoutingCompression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_router_model_compression")]
        public string? AutoRouterModelCompression { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complexity_router_config")]
        public object? ComplexityRouterConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complexity_router_default_model")]
        public string? ComplexityRouterDefaultModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive_router_default_model")]
        public string? AdaptiveRouterDefaultModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive_router_config")]
        public object? AdaptiveRouterConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_router_config")]
        public object? QualityRouterConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality_router_default_model")]
        public string? QualityRouterDefaultModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_id")]
        public string? VectorStoreId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milvus_text_field")]
        public string? MilvusTextField { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milvus_db_name")]
        public string? MilvusDbName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("milvus_partition_names")]
        public global::System.Collections.Generic.IList<string>? MilvusPartitionNames { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valkey_host")]
        public string? ValkeyHost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valkey_port")]
        public int? ValkeyPort { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valkey_password")]
        public string? ValkeyPassword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valkey_ssl")]
        public bool? ValkeySsl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valkey_text_field")]
        public string? ValkeyTextField { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valkey_embedding_field")]
        public string? ValkeyEmbeddingField { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMParams" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="inputCostPerToken"></param>
        /// <param name="outputCostPerToken"></param>
        /// <param name="inputCostPerCharacter"></param>
        /// <param name="outputCostPerCharacter"></param>
        /// <param name="cacheReadInputTokenCost"></param>
        /// <param name="cacheCreationInputTokenCost"></param>
        /// <param name="tieredPricing"></param>
        /// <param name="inputCostPerSecond"></param>
        /// <param name="outputCostPerSecond"></param>
        /// <param name="outputCostPerSecond1080p"></param>
        /// <param name="outputCostPerSecond480p"></param>
        /// <param name="outputCostPerSecond720p"></param>
        /// <param name="outputCostPerSecond768p"></param>
        /// <param name="outputCostPerSecond2k"></param>
        /// <param name="outputCostPerSecond4k"></param>
        /// <param name="outputCostPerImage512"></param>
        /// <param name="outputCostPerImage1024"></param>
        /// <param name="outputCostPerImage1536"></param>
        /// <param name="inputCostPerPixel"></param>
        /// <param name="outputCostPerPixel"></param>
        /// <param name="inputCostPerTokenFlex"></param>
        /// <param name="inputCostPerTokenPriority"></param>
        /// <param name="inputCostPerTokenUltrafast"></param>
        /// <param name="cacheCreationInputTokenCostAbove1hr"></param>
        /// <param name="cacheCreationInputTokenCostAbove200kTokens"></param>
        /// <param name="cacheCreationInputTokenCostAbove272kTokens"></param>
        /// <param name="cacheCreationInputTokenCostAbove272kTokensPriority"></param>
        /// <param name="cacheCreationInputTokenCostAbove272kTokensFlex"></param>
        /// <param name="cacheCreationInputTokenCostFlex"></param>
        /// <param name="cacheCreationInputTokenCostPriority"></param>
        /// <param name="cacheCreationInputTokenCostUltrafast"></param>
        /// <param name="cacheCreationInputAudioTokenCost"></param>
        /// <param name="cacheReadInputTokenCostFlex"></param>
        /// <param name="cacheReadInputTokenCostPriority"></param>
        /// <param name="cacheReadInputTokenCostUltrafast"></param>
        /// <param name="cacheReadInputTokenCostAbove200kTokens"></param>
        /// <param name="cacheReadInputTokenCostAbove200kTokensPriority"></param>
        /// <param name="cacheReadInputTokenCostAbove272kTokensPriority"></param>
        /// <param name="cacheReadInputTokenCostAbove272kTokensFlex"></param>
        /// <param name="cacheReadInputTokenCostBatches"></param>
        /// <param name="cacheReadInputTokenCostAbove272kTokensBatches"></param>
        /// <param name="cacheCreationInputTokenCostBatches"></param>
        /// <param name="cacheCreationInputTokenCostAbove272kTokensBatches"></param>
        /// <param name="cacheReadInputAudioTokenCost"></param>
        /// <param name="cacheReadInputImageTokenCost"></param>
        /// <param name="inputCostPerCharacterAbove128kTokens"></param>
        /// <param name="inputCostPerAudioToken"></param>
        /// <param name="inputCostPerTokenCacheHit"></param>
        /// <param name="inputCostPerTokenAbove128kTokens"></param>
        /// <param name="inputCostPerTokenAbove200kTokens"></param>
        /// <param name="inputCostPerTokenAbove200kTokensPriority"></param>
        /// <param name="inputCostPerTokenAbove272kTokensPriority"></param>
        /// <param name="inputCostPerTokenAbove272kTokensFlex"></param>
        /// <param name="inputCostPerTokenAbove272kTokensBatches"></param>
        /// <param name="inputCostPerQuery"></param>
        /// <param name="inputCostPerImage"></param>
        /// <param name="inputCostPerImageAbove128kTokens"></param>
        /// <param name="inputCostPerAudioPerSecond"></param>
        /// <param name="inputCostPerAudioPerSecondAbove128kTokens"></param>
        /// <param name="inputCostPerVideoPerSecond"></param>
        /// <param name="inputCostPerVideoPerSecondAbove128kTokens"></param>
        /// <param name="inputCostPerVideoPerSecondAbove15sInterval"></param>
        /// <param name="inputCostPerVideoPerSecondAbove8sInterval"></param>
        /// <param name="inputCostPerAudioTokenBatches"></param>
        /// <param name="inputCostPerImageTokenBatches"></param>
        /// <param name="inputCostPerTokenBatches"></param>
        /// <param name="inputCostPerVideoTokenBatches"></param>
        /// <param name="outputCostPerTokenBatches"></param>
        /// <param name="outputCostPerTokenFlex"></param>
        /// <param name="outputCostPerTokenPriority"></param>
        /// <param name="outputCostPerTokenUltrafast"></param>
        /// <param name="outputCostPerAudioToken"></param>
        /// <param name="outputCostPerTokenAbove128kTokens"></param>
        /// <param name="outputCostPerTokenAbove200kTokens"></param>
        /// <param name="outputCostPerTokenAbove200kTokensPriority"></param>
        /// <param name="outputCostPerTokenAbove272kTokensPriority"></param>
        /// <param name="outputCostPerTokenAbove272kTokensFlex"></param>
        /// <param name="outputCostPerTokenAbove272kTokensBatches"></param>
        /// <param name="outputCostPerCharacterAbove128kTokens"></param>
        /// <param name="outputCostPerImage"></param>
        /// <param name="outputCostPerImageToken"></param>
        /// <param name="outputCostPerVideoToken"></param>
        /// <param name="outputCostPerReasoningToken"></param>
        /// <param name="outputCostPerReasoningTokenFlex"></param>
        /// <param name="outputCostPerReasoningTokenPriority"></param>
        /// <param name="outputCostPerVideoPerSecond"></param>
        /// <param name="outputCostPerAudioPerSecond"></param>
        /// <param name="searchContextCostPerQuery"></param>
        /// <param name="googleMapsGroundingCostPerQuery"></param>
        /// <param name="citationCostPerToken"></param>
        /// <param name="cacheReadInputTokenCostAbove272kTokens"></param>
        /// <param name="cacheReadInputTokenCostAbove512kTokens"></param>
        /// <param name="inputCostPerImageToken"></param>
        /// <param name="inputCostPerVideoToken"></param>
        /// <param name="inputCostPerTokenAbove272kTokens"></param>
        /// <param name="inputCostPerTokenAbove512kTokens"></param>
        /// <param name="outputCostPerTokenAbove272kTokens"></param>
        /// <param name="outputCostPerTokenAbove512kTokens"></param>
        /// <param name="outputVectorSize"></param>
        /// <param name="ocrCostPerPage"></param>
        /// <param name="ocrCostPerPageBatches"></param>
        /// <param name="ocrCostPerCredit"></param>
        /// <param name="annotationCostPerPage"></param>
        /// <param name="annotationCostPerPageBatches"></param>
        /// <param name="regionalProcessingUpliftMultiplierEu"></param>
        /// <param name="regionalProcessingUpliftMultiplierUs"></param>
        /// <param name="regionalEndpointUpliftMultiplier"></param>
        /// <param name="apiKey"></param>
        /// <param name="apiBase"></param>
        /// <param name="apiVersion"></param>
        /// <param name="azureAdToken"></param>
        /// <param name="tenantId"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="azureScope"></param>
        /// <param name="azureUsername"></param>
        /// <param name="azurePassword"></param>
        /// <param name="vertexProject"></param>
        /// <param name="vertexLocation"></param>
        /// <param name="vertexCredentials"></param>
        /// <param name="regionName"></param>
        /// <param name="gcsBucketName"></param>
        /// <param name="awsAccessKeyId"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="awsSessionToken"></param>
        /// <param name="awsRegionName"></param>
        /// <param name="awsSessionName"></param>
        /// <param name="awsProfileName"></param>
        /// <param name="awsRoleName"></param>
        /// <param name="awsWebIdentityToken"></param>
        /// <param name="awsStsEndpoint"></param>
        /// <param name="awsExternalId"></param>
        /// <param name="awsSessionTags"></param>
        /// <param name="awsBedrockRuntimeEndpoint"></param>
        /// <param name="awsBedrockProjectId"></param>
        /// <param name="s3BucketName"></param>
        /// <param name="s3EndpointUrl"></param>
        /// <param name="s3RegionName"></param>
        /// <param name="s3AccessKeyId"></param>
        /// <param name="s3SecretAccessKey"></param>
        /// <param name="s3EncryptionKeyId"></param>
        /// <param name="s3BucketOwner"></param>
        /// <param name="awsBatchRoleArn"></param>
        /// <param name="s3OutputBucketName"></param>
        /// <param name="bedrockTags"></param>
        /// <param name="watsonxRegionName"></param>
        /// <param name="customLlmProvider"></param>
        /// <param name="tpm"></param>
        /// <param name="rpm"></param>
        /// <param name="itpm"></param>
        /// <param name="otpm"></param>
        /// <param name="timeout"></param>
        /// <param name="streamTimeout"></param>
        /// <param name="maxRetries"></param>
        /// <param name="dropParams"></param>
        /// <param name="organization"></param>
        /// <param name="configurableClientsideAuthParams"></param>
        /// <param name="litellmCredentialName"></param>
        /// <param name="providerAffinityHeader"></param>
        /// <param name="litellmTraceId"></param>
        /// <param name="maxFileSizeMb"></param>
        /// <param name="defaultApiKeyTpmLimit"></param>
        /// <param name="defaultApiKeyRpmLimit"></param>
        /// <param name="maxBudget"></param>
        /// <param name="budgetDuration"></param>
        /// <param name="keepaliveSeconds"></param>
        /// <param name="allowClientKeepaliveOverride">
        /// Default Value: false
        /// </param>
        /// <param name="useInPassThrough">
        /// Default Value: false
        /// </param>
        /// <param name="useLitellmProxy">
        /// Default Value: false
        /// </param>
        /// <param name="useChatCompletionsApi"></param>
        /// <param name="useXaiOauth">
        /// Use stored xAI OAuth credentials when no xAI API key is configured.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mergeReasoningContentInChoices">
        /// Default Value: false
        /// </param>
        /// <param name="modelInfo"></param>
        /// <param name="mockResponse"></param>
        /// <param name="tags"></param>
        /// <param name="tagRegex"></param>
        /// <param name="autoRouterConfigPath"></param>
        /// <param name="autoRouterConfig"></param>
        /// <param name="autoRouterDefaultModel"></param>
        /// <param name="autoRouterEmbeddingModel"></param>
        /// <param name="autoRouterMaxInputChars"></param>
        /// <param name="autoRouterRoutingCompression"></param>
        /// <param name="autoRouterModelCompression"></param>
        /// <param name="complexityRouterConfig"></param>
        /// <param name="complexityRouterDefaultModel"></param>
        /// <param name="adaptiveRouterDefaultModel"></param>
        /// <param name="adaptiveRouterConfig"></param>
        /// <param name="qualityRouterConfig"></param>
        /// <param name="qualityRouterDefaultModel"></param>
        /// <param name="vectorStoreId"></param>
        /// <param name="milvusTextField"></param>
        /// <param name="milvusDbName"></param>
        /// <param name="milvusPartitionNames"></param>
        /// <param name="valkeyHost"></param>
        /// <param name="valkeyPort"></param>
        /// <param name="valkeyPassword"></param>
        /// <param name="valkeySsl"></param>
        /// <param name="valkeyTextField"></param>
        /// <param name="valkeyEmbeddingField"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiteLLMParams(
            string model,
            double? inputCostPerToken,
            double? outputCostPerToken,
            double? inputCostPerCharacter,
            double? outputCostPerCharacter,
            double? cacheReadInputTokenCost,
            double? cacheCreationInputTokenCost,
            global::System.Collections.Generic.IList<object>? tieredPricing,
            double? inputCostPerSecond,
            double? outputCostPerSecond,
            double? outputCostPerSecond1080p,
            double? outputCostPerSecond480p,
            double? outputCostPerSecond720p,
            double? outputCostPerSecond768p,
            double? outputCostPerSecond2k,
            double? outputCostPerSecond4k,
            double? outputCostPerImage512,
            double? outputCostPerImage1024,
            double? outputCostPerImage1536,
            double? inputCostPerPixel,
            double? outputCostPerPixel,
            double? inputCostPerTokenFlex,
            double? inputCostPerTokenPriority,
            double? inputCostPerTokenUltrafast,
            double? cacheCreationInputTokenCostAbove1hr,
            double? cacheCreationInputTokenCostAbove200kTokens,
            double? cacheCreationInputTokenCostAbove272kTokens,
            double? cacheCreationInputTokenCostAbove272kTokensPriority,
            double? cacheCreationInputTokenCostAbove272kTokensFlex,
            double? cacheCreationInputTokenCostFlex,
            double? cacheCreationInputTokenCostPriority,
            double? cacheCreationInputTokenCostUltrafast,
            double? cacheCreationInputAudioTokenCost,
            double? cacheReadInputTokenCostFlex,
            double? cacheReadInputTokenCostPriority,
            double? cacheReadInputTokenCostUltrafast,
            double? cacheReadInputTokenCostAbove200kTokens,
            double? cacheReadInputTokenCostAbove200kTokensPriority,
            double? cacheReadInputTokenCostAbove272kTokensPriority,
            double? cacheReadInputTokenCostAbove272kTokensFlex,
            double? cacheReadInputTokenCostBatches,
            double? cacheReadInputTokenCostAbove272kTokensBatches,
            double? cacheCreationInputTokenCostBatches,
            double? cacheCreationInputTokenCostAbove272kTokensBatches,
            double? cacheReadInputAudioTokenCost,
            double? cacheReadInputImageTokenCost,
            double? inputCostPerCharacterAbove128kTokens,
            double? inputCostPerAudioToken,
            double? inputCostPerTokenCacheHit,
            double? inputCostPerTokenAbove128kTokens,
            double? inputCostPerTokenAbove200kTokens,
            double? inputCostPerTokenAbove200kTokensPriority,
            double? inputCostPerTokenAbove272kTokensPriority,
            double? inputCostPerTokenAbove272kTokensFlex,
            double? inputCostPerTokenAbove272kTokensBatches,
            double? inputCostPerQuery,
            double? inputCostPerImage,
            double? inputCostPerImageAbove128kTokens,
            double? inputCostPerAudioPerSecond,
            double? inputCostPerAudioPerSecondAbove128kTokens,
            double? inputCostPerVideoPerSecond,
            double? inputCostPerVideoPerSecondAbove128kTokens,
            double? inputCostPerVideoPerSecondAbove15sInterval,
            double? inputCostPerVideoPerSecondAbove8sInterval,
            double? inputCostPerAudioTokenBatches,
            double? inputCostPerImageTokenBatches,
            double? inputCostPerTokenBatches,
            double? inputCostPerVideoTokenBatches,
            double? outputCostPerTokenBatches,
            double? outputCostPerTokenFlex,
            double? outputCostPerTokenPriority,
            double? outputCostPerTokenUltrafast,
            double? outputCostPerAudioToken,
            double? outputCostPerTokenAbove128kTokens,
            double? outputCostPerTokenAbove200kTokens,
            double? outputCostPerTokenAbove200kTokensPriority,
            double? outputCostPerTokenAbove272kTokensPriority,
            double? outputCostPerTokenAbove272kTokensFlex,
            double? outputCostPerTokenAbove272kTokensBatches,
            double? outputCostPerCharacterAbove128kTokens,
            double? outputCostPerImage,
            double? outputCostPerImageToken,
            double? outputCostPerVideoToken,
            double? outputCostPerReasoningToken,
            double? outputCostPerReasoningTokenFlex,
            double? outputCostPerReasoningTokenPriority,
            double? outputCostPerVideoPerSecond,
            double? outputCostPerAudioPerSecond,
            object? searchContextCostPerQuery,
            double? googleMapsGroundingCostPerQuery,
            double? citationCostPerToken,
            double? cacheReadInputTokenCostAbove272kTokens,
            double? cacheReadInputTokenCostAbove512kTokens,
            double? inputCostPerImageToken,
            double? inputCostPerVideoToken,
            double? inputCostPerTokenAbove272kTokens,
            double? inputCostPerTokenAbove512kTokens,
            double? outputCostPerTokenAbove272kTokens,
            double? outputCostPerTokenAbove512kTokens,
            int? outputVectorSize,
            double? ocrCostPerPage,
            double? ocrCostPerPageBatches,
            double? ocrCostPerCredit,
            double? annotationCostPerPage,
            double? annotationCostPerPageBatches,
            double? regionalProcessingUpliftMultiplierEu,
            double? regionalProcessingUpliftMultiplierUs,
            double? regionalEndpointUpliftMultiplier,
            string? apiKey,
            string? apiBase,
            string? apiVersion,
            string? azureAdToken,
            string? tenantId,
            string? clientId,
            string? clientSecret,
            string? azureScope,
            string? azureUsername,
            string? azurePassword,
            string? vertexProject,
            string? vertexLocation,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, object, object>? vertexCredentials,
            string? regionName,
            string? gcsBucketName,
            string? awsAccessKeyId,
            string? awsSecretAccessKey,
            string? awsSessionToken,
            string? awsRegionName,
            string? awsSessionName,
            string? awsProfileName,
            string? awsRoleName,
            string? awsWebIdentityToken,
            string? awsStsEndpoint,
            string? awsExternalId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AwsSessionTag>? awsSessionTags,
            string? awsBedrockRuntimeEndpoint,
            string? awsBedrockProjectId,
            string? s3BucketName,
            string? s3EndpointUrl,
            string? s3RegionName,
            string? s3AccessKeyId,
            string? s3SecretAccessKey,
            string? s3EncryptionKeyId,
            string? s3BucketOwner,
            string? awsBatchRoleArn,
            string? s3OutputBucketName,
            global::System.Collections.Generic.IList<object>? bedrockTags,
            string? watsonxRegionName,
            string? customLlmProvider,
            int? tpm,
            int? rpm,
            int? itpm,
            int? otpm,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<double?, string, object>? timeout,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<double?, string, object>? streamTimeout,
            int? maxRetries,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<bool?, string, object>? dropParams,
            string? organization,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::Loud.Technology.LiteLLM.Sdk.ConfigurableClientsideParamsCustomAuthInput>>? configurableClientsideAuthParams,
            string? litellmCredentialName,
            string? providerAffinityHeader,
            string? litellmTraceId,
            double? maxFileSizeMb,
            int? defaultApiKeyTpmLimit,
            int? defaultApiKeyRpmLimit,
            double? maxBudget,
            string? budgetDuration,
            double? keepaliveSeconds,
            bool? allowClientKeepaliveOverride,
            bool? useInPassThrough,
            bool? useLitellmProxy,
            bool? useChatCompletionsApi,
            bool? useXaiOauth,
            bool? mergeReasoningContentInChoices,
            object? modelInfo,
            global::Loud.Technology.LiteLLM.Sdk.AnyOf<string, global::Loud.Technology.LiteLLM.Sdk.ModelResponse, object, object>? mockResponse,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagRegex,
            string? autoRouterConfigPath,
            string? autoRouterConfig,
            string? autoRouterDefaultModel,
            string? autoRouterEmbeddingModel,
            int? autoRouterMaxInputChars,
            string? autoRouterRoutingCompression,
            string? autoRouterModelCompression,
            object? complexityRouterConfig,
            string? complexityRouterDefaultModel,
            string? adaptiveRouterDefaultModel,
            object? adaptiveRouterConfig,
            object? qualityRouterConfig,
            string? qualityRouterDefaultModel,
            string? vectorStoreId,
            string? milvusTextField,
            string? milvusDbName,
            global::System.Collections.Generic.IList<string>? milvusPartitionNames,
            string? valkeyHost,
            int? valkeyPort,
            string? valkeyPassword,
            bool? valkeySsl,
            string? valkeyTextField,
            string? valkeyEmbeddingField)
        {
            this.InputCostPerToken = inputCostPerToken;
            this.OutputCostPerToken = outputCostPerToken;
            this.InputCostPerCharacter = inputCostPerCharacter;
            this.OutputCostPerCharacter = outputCostPerCharacter;
            this.CacheReadInputTokenCost = cacheReadInputTokenCost;
            this.CacheCreationInputTokenCost = cacheCreationInputTokenCost;
            this.TieredPricing = tieredPricing;
            this.InputCostPerSecond = inputCostPerSecond;
            this.OutputCostPerSecond = outputCostPerSecond;
            this.OutputCostPerSecond1080p = outputCostPerSecond1080p;
            this.OutputCostPerSecond480p = outputCostPerSecond480p;
            this.OutputCostPerSecond720p = outputCostPerSecond720p;
            this.OutputCostPerSecond768p = outputCostPerSecond768p;
            this.OutputCostPerSecond2k = outputCostPerSecond2k;
            this.OutputCostPerSecond4k = outputCostPerSecond4k;
            this.OutputCostPerImage512 = outputCostPerImage512;
            this.OutputCostPerImage1024 = outputCostPerImage1024;
            this.OutputCostPerImage1536 = outputCostPerImage1536;
            this.InputCostPerPixel = inputCostPerPixel;
            this.OutputCostPerPixel = outputCostPerPixel;
            this.InputCostPerTokenFlex = inputCostPerTokenFlex;
            this.InputCostPerTokenPriority = inputCostPerTokenPriority;
            this.InputCostPerTokenUltrafast = inputCostPerTokenUltrafast;
            this.CacheCreationInputTokenCostAbove1hr = cacheCreationInputTokenCostAbove1hr;
            this.CacheCreationInputTokenCostAbove200kTokens = cacheCreationInputTokenCostAbove200kTokens;
            this.CacheCreationInputTokenCostAbove272kTokens = cacheCreationInputTokenCostAbove272kTokens;
            this.CacheCreationInputTokenCostAbove272kTokensPriority = cacheCreationInputTokenCostAbove272kTokensPriority;
            this.CacheCreationInputTokenCostAbove272kTokensFlex = cacheCreationInputTokenCostAbove272kTokensFlex;
            this.CacheCreationInputTokenCostFlex = cacheCreationInputTokenCostFlex;
            this.CacheCreationInputTokenCostPriority = cacheCreationInputTokenCostPriority;
            this.CacheCreationInputTokenCostUltrafast = cacheCreationInputTokenCostUltrafast;
            this.CacheCreationInputAudioTokenCost = cacheCreationInputAudioTokenCost;
            this.CacheReadInputTokenCostFlex = cacheReadInputTokenCostFlex;
            this.CacheReadInputTokenCostPriority = cacheReadInputTokenCostPriority;
            this.CacheReadInputTokenCostUltrafast = cacheReadInputTokenCostUltrafast;
            this.CacheReadInputTokenCostAbove200kTokens = cacheReadInputTokenCostAbove200kTokens;
            this.CacheReadInputTokenCostAbove200kTokensPriority = cacheReadInputTokenCostAbove200kTokensPriority;
            this.CacheReadInputTokenCostAbove272kTokensPriority = cacheReadInputTokenCostAbove272kTokensPriority;
            this.CacheReadInputTokenCostAbove272kTokensFlex = cacheReadInputTokenCostAbove272kTokensFlex;
            this.CacheReadInputTokenCostBatches = cacheReadInputTokenCostBatches;
            this.CacheReadInputTokenCostAbove272kTokensBatches = cacheReadInputTokenCostAbove272kTokensBatches;
            this.CacheCreationInputTokenCostBatches = cacheCreationInputTokenCostBatches;
            this.CacheCreationInputTokenCostAbove272kTokensBatches = cacheCreationInputTokenCostAbove272kTokensBatches;
            this.CacheReadInputAudioTokenCost = cacheReadInputAudioTokenCost;
            this.CacheReadInputImageTokenCost = cacheReadInputImageTokenCost;
            this.InputCostPerCharacterAbove128kTokens = inputCostPerCharacterAbove128kTokens;
            this.InputCostPerAudioToken = inputCostPerAudioToken;
            this.InputCostPerTokenCacheHit = inputCostPerTokenCacheHit;
            this.InputCostPerTokenAbove128kTokens = inputCostPerTokenAbove128kTokens;
            this.InputCostPerTokenAbove200kTokens = inputCostPerTokenAbove200kTokens;
            this.InputCostPerTokenAbove200kTokensPriority = inputCostPerTokenAbove200kTokensPriority;
            this.InputCostPerTokenAbove272kTokensPriority = inputCostPerTokenAbove272kTokensPriority;
            this.InputCostPerTokenAbove272kTokensFlex = inputCostPerTokenAbove272kTokensFlex;
            this.InputCostPerTokenAbove272kTokensBatches = inputCostPerTokenAbove272kTokensBatches;
            this.InputCostPerQuery = inputCostPerQuery;
            this.InputCostPerImage = inputCostPerImage;
            this.InputCostPerImageAbove128kTokens = inputCostPerImageAbove128kTokens;
            this.InputCostPerAudioPerSecond = inputCostPerAudioPerSecond;
            this.InputCostPerAudioPerSecondAbove128kTokens = inputCostPerAudioPerSecondAbove128kTokens;
            this.InputCostPerVideoPerSecond = inputCostPerVideoPerSecond;
            this.InputCostPerVideoPerSecondAbove128kTokens = inputCostPerVideoPerSecondAbove128kTokens;
            this.InputCostPerVideoPerSecondAbove15sInterval = inputCostPerVideoPerSecondAbove15sInterval;
            this.InputCostPerVideoPerSecondAbove8sInterval = inputCostPerVideoPerSecondAbove8sInterval;
            this.InputCostPerAudioTokenBatches = inputCostPerAudioTokenBatches;
            this.InputCostPerImageTokenBatches = inputCostPerImageTokenBatches;
            this.InputCostPerTokenBatches = inputCostPerTokenBatches;
            this.InputCostPerVideoTokenBatches = inputCostPerVideoTokenBatches;
            this.OutputCostPerTokenBatches = outputCostPerTokenBatches;
            this.OutputCostPerTokenFlex = outputCostPerTokenFlex;
            this.OutputCostPerTokenPriority = outputCostPerTokenPriority;
            this.OutputCostPerTokenUltrafast = outputCostPerTokenUltrafast;
            this.OutputCostPerAudioToken = outputCostPerAudioToken;
            this.OutputCostPerTokenAbove128kTokens = outputCostPerTokenAbove128kTokens;
            this.OutputCostPerTokenAbove200kTokens = outputCostPerTokenAbove200kTokens;
            this.OutputCostPerTokenAbove200kTokensPriority = outputCostPerTokenAbove200kTokensPriority;
            this.OutputCostPerTokenAbove272kTokensPriority = outputCostPerTokenAbove272kTokensPriority;
            this.OutputCostPerTokenAbove272kTokensFlex = outputCostPerTokenAbove272kTokensFlex;
            this.OutputCostPerTokenAbove272kTokensBatches = outputCostPerTokenAbove272kTokensBatches;
            this.OutputCostPerCharacterAbove128kTokens = outputCostPerCharacterAbove128kTokens;
            this.OutputCostPerImage = outputCostPerImage;
            this.OutputCostPerImageToken = outputCostPerImageToken;
            this.OutputCostPerVideoToken = outputCostPerVideoToken;
            this.OutputCostPerReasoningToken = outputCostPerReasoningToken;
            this.OutputCostPerReasoningTokenFlex = outputCostPerReasoningTokenFlex;
            this.OutputCostPerReasoningTokenPriority = outputCostPerReasoningTokenPriority;
            this.OutputCostPerVideoPerSecond = outputCostPerVideoPerSecond;
            this.OutputCostPerAudioPerSecond = outputCostPerAudioPerSecond;
            this.SearchContextCostPerQuery = searchContextCostPerQuery;
            this.GoogleMapsGroundingCostPerQuery = googleMapsGroundingCostPerQuery;
            this.CitationCostPerToken = citationCostPerToken;
            this.CacheReadInputTokenCostAbove272kTokens = cacheReadInputTokenCostAbove272kTokens;
            this.CacheReadInputTokenCostAbove512kTokens = cacheReadInputTokenCostAbove512kTokens;
            this.InputCostPerImageToken = inputCostPerImageToken;
            this.InputCostPerVideoToken = inputCostPerVideoToken;
            this.InputCostPerTokenAbove272kTokens = inputCostPerTokenAbove272kTokens;
            this.InputCostPerTokenAbove512kTokens = inputCostPerTokenAbove512kTokens;
            this.OutputCostPerTokenAbove272kTokens = outputCostPerTokenAbove272kTokens;
            this.OutputCostPerTokenAbove512kTokens = outputCostPerTokenAbove512kTokens;
            this.OutputVectorSize = outputVectorSize;
            this.OcrCostPerPage = ocrCostPerPage;
            this.OcrCostPerPageBatches = ocrCostPerPageBatches;
            this.OcrCostPerCredit = ocrCostPerCredit;
            this.AnnotationCostPerPage = annotationCostPerPage;
            this.AnnotationCostPerPageBatches = annotationCostPerPageBatches;
            this.RegionalProcessingUpliftMultiplierEu = regionalProcessingUpliftMultiplierEu;
            this.RegionalProcessingUpliftMultiplierUs = regionalProcessingUpliftMultiplierUs;
            this.RegionalEndpointUpliftMultiplier = regionalEndpointUpliftMultiplier;
            this.ApiKey = apiKey;
            this.ApiBase = apiBase;
            this.ApiVersion = apiVersion;
            this.AzureAdToken = azureAdToken;
            this.TenantId = tenantId;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.AzureScope = azureScope;
            this.AzureUsername = azureUsername;
            this.AzurePassword = azurePassword;
            this.VertexProject = vertexProject;
            this.VertexLocation = vertexLocation;
            this.VertexCredentials = vertexCredentials;
            this.RegionName = regionName;
            this.GcsBucketName = gcsBucketName;
            this.AwsAccessKeyId = awsAccessKeyId;
            this.AwsSecretAccessKey = awsSecretAccessKey;
            this.AwsSessionToken = awsSessionToken;
            this.AwsRegionName = awsRegionName;
            this.AwsSessionName = awsSessionName;
            this.AwsProfileName = awsProfileName;
            this.AwsRoleName = awsRoleName;
            this.AwsWebIdentityToken = awsWebIdentityToken;
            this.AwsStsEndpoint = awsStsEndpoint;
            this.AwsExternalId = awsExternalId;
            this.AwsSessionTags = awsSessionTags;
            this.AwsBedrockRuntimeEndpoint = awsBedrockRuntimeEndpoint;
            this.AwsBedrockProjectId = awsBedrockProjectId;
            this.S3BucketName = s3BucketName;
            this.S3EndpointUrl = s3EndpointUrl;
            this.S3RegionName = s3RegionName;
            this.S3AccessKeyId = s3AccessKeyId;
            this.S3SecretAccessKey = s3SecretAccessKey;
            this.S3EncryptionKeyId = s3EncryptionKeyId;
            this.S3BucketOwner = s3BucketOwner;
            this.AwsBatchRoleArn = awsBatchRoleArn;
            this.S3OutputBucketName = s3OutputBucketName;
            this.BedrockTags = bedrockTags;
            this.WatsonxRegionName = watsonxRegionName;
            this.CustomLlmProvider = customLlmProvider;
            this.Tpm = tpm;
            this.Rpm = rpm;
            this.Itpm = itpm;
            this.Otpm = otpm;
            this.Timeout = timeout;
            this.StreamTimeout = streamTimeout;
            this.MaxRetries = maxRetries;
            this.DropParams = dropParams;
            this.Organization = organization;
            this.ConfigurableClientsideAuthParams = configurableClientsideAuthParams;
            this.LitellmCredentialName = litellmCredentialName;
            this.ProviderAffinityHeader = providerAffinityHeader;
            this.LitellmTraceId = litellmTraceId;
            this.MaxFileSizeMb = maxFileSizeMb;
            this.DefaultApiKeyTpmLimit = defaultApiKeyTpmLimit;
            this.DefaultApiKeyRpmLimit = defaultApiKeyRpmLimit;
            this.MaxBudget = maxBudget;
            this.BudgetDuration = budgetDuration;
            this.KeepaliveSeconds = keepaliveSeconds;
            this.AllowClientKeepaliveOverride = allowClientKeepaliveOverride;
            this.UseInPassThrough = useInPassThrough;
            this.UseLitellmProxy = useLitellmProxy;
            this.UseChatCompletionsApi = useChatCompletionsApi;
            this.UseXaiOauth = useXaiOauth;
            this.MergeReasoningContentInChoices = mergeReasoningContentInChoices;
            this.ModelInfo = modelInfo;
            this.MockResponse = mockResponse;
            this.Tags = tags;
            this.TagRegex = tagRegex;
            this.AutoRouterConfigPath = autoRouterConfigPath;
            this.AutoRouterConfig = autoRouterConfig;
            this.AutoRouterDefaultModel = autoRouterDefaultModel;
            this.AutoRouterEmbeddingModel = autoRouterEmbeddingModel;
            this.AutoRouterMaxInputChars = autoRouterMaxInputChars;
            this.AutoRouterRoutingCompression = autoRouterRoutingCompression;
            this.AutoRouterModelCompression = autoRouterModelCompression;
            this.ComplexityRouterConfig = complexityRouterConfig;
            this.ComplexityRouterDefaultModel = complexityRouterDefaultModel;
            this.AdaptiveRouterDefaultModel = adaptiveRouterDefaultModel;
            this.AdaptiveRouterConfig = adaptiveRouterConfig;
            this.QualityRouterConfig = qualityRouterConfig;
            this.QualityRouterDefaultModel = qualityRouterDefaultModel;
            this.VectorStoreId = vectorStoreId;
            this.MilvusTextField = milvusTextField;
            this.MilvusDbName = milvusDbName;
            this.MilvusPartitionNames = milvusPartitionNames;
            this.ValkeyHost = valkeyHost;
            this.ValkeyPort = valkeyPort;
            this.ValkeyPassword = valkeyPassword;
            this.ValkeySsl = valkeySsl;
            this.ValkeyTextField = valkeyTextField;
            this.ValkeyEmbeddingField = valkeyEmbeddingField;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiteLLMParams" /> class.
        /// </summary>
        public LiteLLMParams()
        {
        }

    }
}