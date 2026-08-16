
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnblockUsersResponse
    {
        /// <summary>
        /// User IDs that remain blocked after this unblock call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BlockedUsers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnblockUsersResponse" /> class.
        /// </summary>
        /// <param name="blockedUsers">
        /// User IDs that remain blocked after this unblock call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnblockUsersResponse(
            global::System.Collections.Generic.IList<string> blockedUsers)
        {
            this.BlockedUsers = blockedUsers ?? throw new global::System.ArgumentNullException(nameof(blockedUsers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnblockUsersResponse" /> class.
        /// </summary>
        public UnblockUsersResponse()
        {
        }

    }
}