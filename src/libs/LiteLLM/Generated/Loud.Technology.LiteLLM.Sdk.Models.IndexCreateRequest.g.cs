
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_info")]
        public object? IndexInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.IndexCreateLiteLLMParams LitellmParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexCreateRequest" /> class.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="litellmParams"></param>
        /// <param name="indexInfo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexCreateRequest(
            string indexName,
            global::Loud.Technology.LiteLLM.Sdk.IndexCreateLiteLLMParams litellmParams,
            object? indexInfo)
        {
            this.IndexInfo = indexInfo;
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.LitellmParams = litellmParams ?? throw new global::System.ArgumentNullException(nameof(litellmParams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexCreateRequest" /> class.
        /// </summary>
        public IndexCreateRequest()
        {
        }

    }
}