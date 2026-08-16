
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Response from a compliance check endpoint.
    /// </summary>
    public sealed partial class ComplianceResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ComplianceCheckResult> Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Compliant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regulation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Regulation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceResponse" /> class.
        /// </summary>
        /// <param name="checks"></param>
        /// <param name="compliant"></param>
        /// <param name="regulation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComplianceResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ComplianceCheckResult> checks,
            bool compliant,
            string regulation)
        {
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
            this.Compliant = compliant;
            this.Regulation = regulation ?? throw new global::System.ArgumentNullException(nameof(regulation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceResponse" /> class.
        /// </summary>
        public ComplianceResponse()
        {
        }

    }
}