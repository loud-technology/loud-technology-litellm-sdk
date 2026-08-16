
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlockUsersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMEndUserTable> BlockedUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockUsersResponse" /> class.
        /// </summary>
        /// <param name="blockedUsers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlockUsersResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.LiteLLMEndUserTable> blockedUsers)
        {
            this.BlockedUsers = blockedUsers ?? throw new global::System.ArgumentNullException(nameof(blockedUsers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockUsersResponse" /> class.
        /// </summary>
        public BlockUsersResponse()
        {
        }

    }
}