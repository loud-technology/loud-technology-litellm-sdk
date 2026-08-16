
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Request for bulk user updates
    /// </summary>
    public sealed partial class BulkUpdateUserRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest>? Users { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_users")]
        public bool? AllUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_updates")]
        public global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequestNoUserIDorEmail? UserUpdates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateUserRequest" /> class.
        /// </summary>
        /// <param name="users"></param>
        /// <param name="allUsers">
        /// Default Value: false
        /// </param>
        /// <param name="userUpdates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateUserRequest(
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequest>? users,
            bool? allUsers,
            global::Loud.Technology.LiteLLM.Sdk.UpdateUserRequestNoUserIDorEmail? userUpdates)
        {
            this.Users = users;
            this.AllUsers = allUsers;
            this.UserUpdates = userUpdates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateUserRequest" /> class.
        /// </summary>
        public BulkUpdateUserRequest()
        {
        }

    }
}