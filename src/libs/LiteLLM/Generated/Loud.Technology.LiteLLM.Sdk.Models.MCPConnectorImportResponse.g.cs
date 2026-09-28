
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MCPConnectorImportResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportFailure> Errors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportResult> Imported { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportSkipped> Skipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPConnectorImportResponse" /> class.
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="imported"></param>
        /// <param name="skipped"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPConnectorImportResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportFailure> errors,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportResult> imported,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.MCPConnectorImportSkipped> skipped)
        {
            this.Errors = errors ?? throw new global::System.ArgumentNullException(nameof(errors));
            this.Imported = imported ?? throw new global::System.ArgumentNullException(nameof(imported));
            this.Skipped = skipped ?? throw new global::System.ArgumentNullException(nameof(skipped));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPConnectorImportResponse" /> class.
        /// </summary>
        public MCPConnectorImportResponse()
        {
        }

    }
}