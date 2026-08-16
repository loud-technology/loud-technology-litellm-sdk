
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CredentialName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CredentialInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object CredentialValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialItem" /> class.
        /// </summary>
        /// <param name="credentialName"></param>
        /// <param name="credentialInfo"></param>
        /// <param name="credentialValues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CredentialItem(
            string credentialName,
            object credentialInfo,
            object credentialValues)
        {
            this.CredentialName = credentialName ?? throw new global::System.ArgumentNullException(nameof(credentialName));
            this.CredentialInfo = credentialInfo ?? throw new global::System.ArgumentNullException(nameof(credentialInfo));
            this.CredentialValues = credentialValues ?? throw new global::System.ArgumentNullException(nameof(credentialValues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialItem" /> class.
        /// </summary>
        public CredentialItem()
        {
        }

    }
}