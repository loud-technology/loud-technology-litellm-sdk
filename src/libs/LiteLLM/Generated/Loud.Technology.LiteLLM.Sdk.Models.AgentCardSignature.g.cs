
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Represents a JWS signature of an AgentCard.
    /// </summary>
    public sealed partial class AgentCardSignature
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        public string? Protected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        public object? Header { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCardSignature" /> class.
        /// </summary>
        /// <param name="protected"></param>
        /// <param name="signature"></param>
        /// <param name="header"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCardSignature(
            string? @protected,
            string? signature,
            object? header)
        {
            this.Protected = @protected;
            this.Signature = signature;
            this.Header = header;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCardSignature" /> class.
        /// </summary>
        public AgentCardSignature()
        {
        }

    }
}