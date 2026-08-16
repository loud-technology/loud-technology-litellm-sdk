
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Member
    {
        /// <summary>
        /// The unique ID of the user to add. Either user_id or user_email must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// The email address of the user to add. Either user_id or user_email must be provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// The role of the user within the team. 'admin' users can manage team settings and members, 'user' is a regular team member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.MemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.MemberRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the user within the team. 'admin' users can manage team settings and members, 'user' is a regular team member
        /// </param>
        /// <param name="userId">
        /// The unique ID of the user to add. Either user_id or user_email must be provided
        /// </param>
        /// <param name="userEmail">
        /// The email address of the user to add. Either user_id or user_email must be provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Member(
            global::Loud.Technology.LiteLLM.Sdk.MemberRole role,
            string? userId,
            string? userEmail)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member" /> class.
        /// </summary>
        public Member()
        {
        }

    }
}