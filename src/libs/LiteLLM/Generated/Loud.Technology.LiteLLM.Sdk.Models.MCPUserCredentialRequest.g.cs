
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPUserCredentialRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Credential { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save")]
        public bool? Save { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserCredentialRequest" /> class.
        /// </summary>
        /// <param name="credential"></param>
        /// <param name="save">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPUserCredentialRequest(
            string credential,
            bool? save)
        {
            this.Credential = credential ?? throw new global::System.ArgumentNullException(nameof(credential));
            this.Save = save;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPUserCredentialRequest" /> class.
        /// </summary>
        public MCPUserCredentialRequest()
        {
        }

    }
}