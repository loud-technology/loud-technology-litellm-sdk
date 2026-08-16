
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderCreateInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LitellmProvider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ProviderCredentialField> CredentialFields { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_model_placeholder")]
        public string? DefaultModelPlaceholder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderCreateInfo" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="providerDisplayName"></param>
        /// <param name="litellmProvider"></param>
        /// <param name="credentialFields"></param>
        /// <param name="defaultModelPlaceholder"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderCreateInfo(
            string provider,
            string providerDisplayName,
            string litellmProvider,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ProviderCredentialField> credentialFields,
            string? defaultModelPlaceholder)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ProviderDisplayName = providerDisplayName ?? throw new global::System.ArgumentNullException(nameof(providerDisplayName));
            this.LitellmProvider = litellmProvider ?? throw new global::System.ArgumentNullException(nameof(litellmProvider));
            this.CredentialFields = credentialFields ?? throw new global::System.ArgumentNullException(nameof(credentialFields));
            this.DefaultModelPlaceholder = defaultModelPlaceholder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderCreateInfo" /> class.
        /// </summary>
        public ProviderCreateInfo()
        {
        }

    }
}