
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// One member, named by exactly one of `user_id` or `user_email`.
    /// </summary>
    public sealed partial class TeamMemberRef
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberRef" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberRef(
            string? userId,
            string? userEmail)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberRef" /> class.
        /// </summary>
        public TeamMemberRef()
        {
        }

    }
}