
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApplyGuardrailResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyGuardrailResponse" /> class.
        /// </summary>
        /// <param name="responseText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyGuardrailResponse(
            string responseText)
        {
            this.ResponseText = responseText ?? throw new global::System.ArgumentNullException(nameof(responseText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyGuardrailResponse" /> class.
        /// </summary>
        public ApplyGuardrailResponse()
        {
        }

    }
}