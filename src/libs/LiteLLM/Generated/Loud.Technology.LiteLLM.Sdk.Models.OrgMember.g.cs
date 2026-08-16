
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgMember
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.OrgMemberRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.OrgMemberRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMember" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="userId">
        /// The unique ID of the user to add. Either user_id or user_email must be provided
        /// </param>
        /// <param name="userEmail">
        /// The email address of the user to add. Either user_id or user_email must be provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgMember(
            global::Loud.Technology.LiteLLM.Sdk.OrgMemberRole role,
            string? userId,
            string? userEmail)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgMember" /> class.
        /// </summary>
        public OrgMember()
        {
        }

    }
}