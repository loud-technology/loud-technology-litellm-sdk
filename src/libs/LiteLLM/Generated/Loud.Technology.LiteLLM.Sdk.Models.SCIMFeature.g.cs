
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SCIMFeature
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxOperations")]
        public int? MaxOperations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxPayloadSize")]
        public int? MaxPayloadSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxResults")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMFeature" /> class.
        /// </summary>
        /// <param name="supported"></param>
        /// <param name="maxOperations"></param>
        /// <param name="maxPayloadSize"></param>
        /// <param name="maxResults"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMFeature(
            bool supported,
            int? maxOperations,
            int? maxPayloadSize,
            int? maxResults)
        {
            this.MaxOperations = maxOperations;
            this.MaxPayloadSize = maxPayloadSize;
            this.MaxResults = maxResults;
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMFeature" /> class.
        /// </summary>
        public SCIMFeature()
        {
        }

    }
}