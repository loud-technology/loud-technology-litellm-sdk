
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteOrganizationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OrganizationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrganizationRequest" /> class.
        /// </summary>
        /// <param name="organizationIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteOrganizationRequest(
            global::System.Collections.Generic.IList<string> organizationIds)
        {
            this.OrganizationIds = organizationIds ?? throw new global::System.ArgumentNullException(nameof(organizationIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteOrganizationRequest" /> class.
        /// </summary>
        public DeleteOrganizationRequest()
        {
        }

    }
}