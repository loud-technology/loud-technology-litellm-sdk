
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request model for updating public model groups
    /// </summary>
    public sealed partial class UpdatePublicModelGroupsRequest
    {
        /// <summary>
        /// List of model group names to make public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModelGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePublicModelGroupsRequest" /> class.
        /// </summary>
        /// <param name="modelGroups">
        /// List of model group names to make public
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePublicModelGroupsRequest(
            global::System.Collections.Generic.IList<string> modelGroups)
        {
            this.ModelGroups = modelGroups ?? throw new global::System.ArgumentNullException(nameof(modelGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePublicModelGroupsRequest" /> class.
        /// </summary>
        public UpdatePublicModelGroupsRequest()
        {
        }

    }
}