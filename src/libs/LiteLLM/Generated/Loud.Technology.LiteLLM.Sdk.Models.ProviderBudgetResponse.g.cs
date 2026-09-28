
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Complete provider budget configuration and status.<br/>
    /// Maps provider names to their budget configs.
    /// </summary>
    public sealed partial class ProviderBudgetResponse
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.ProviderBudgetResponseObject>? Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderBudgetResponse" /> class.
        /// </summary>
        /// <param name="providers">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderBudgetResponse(
            global::System.Collections.Generic.Dictionary<string, global::Loud.Technology.LiteLLM.Sdk.ProviderBudgetResponseObject>? providers)
        {
            this.Providers = providers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderBudgetResponse" /> class.
        /// </summary>
        public ProviderBudgetResponse()
        {
        }

    }
}