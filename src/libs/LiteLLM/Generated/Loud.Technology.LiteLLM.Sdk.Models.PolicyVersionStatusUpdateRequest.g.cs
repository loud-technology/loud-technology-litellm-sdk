
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request body for updating a policy version's status.
    /// </summary>
    public sealed partial class PolicyVersionStatusUpdateRequest
    {
        /// <summary>
        /// New status: 'published' or 'production'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyVersionStatusUpdateRequest" /> class.
        /// </summary>
        /// <param name="versionStatus">
        /// New status: 'published' or 'production'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyVersionStatusUpdateRequest(
            string versionStatus)
        {
            this.VersionStatus = versionStatus ?? throw new global::System.ArgumentNullException(nameof(versionStatus));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyVersionStatusUpdateRequest" /> class.
        /// </summary>
        public PolicyVersionStatusUpdateRequest()
        {
        }

    }
}