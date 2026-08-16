
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexCreateLiteLLMParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorStoreIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorStoreName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexCreateLiteLLMParams" /> class.
        /// </summary>
        /// <param name="vectorStoreIndex"></param>
        /// <param name="vectorStoreName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexCreateLiteLLMParams(
            string vectorStoreIndex,
            string vectorStoreName)
        {
            this.VectorStoreIndex = vectorStoreIndex ?? throw new global::System.ArgumentNullException(nameof(vectorStoreIndex));
            this.VectorStoreName = vectorStoreName ?? throw new global::System.ArgumentNullException(nameof(vectorStoreName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexCreateLiteLLMParams" /> class.
        /// </summary>
        public IndexCreateLiteLLMParams()
        {
        }

    }
}