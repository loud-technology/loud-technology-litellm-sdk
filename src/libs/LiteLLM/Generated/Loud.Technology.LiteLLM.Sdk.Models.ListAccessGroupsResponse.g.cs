
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAccessGroupsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AccessGroupInfo> AccessGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccessGroupsResponse" /> class.
        /// </summary>
        /// <param name="accessGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAccessGroupsResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.AccessGroupInfo> accessGroups)
        {
            this.AccessGroups = accessGroups ?? throw new global::System.ArgumentNullException(nameof(accessGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAccessGroupsResponse" /> class.
        /// </summary>
        public ListAccessGroupsResponse()
        {
        }

    }
}