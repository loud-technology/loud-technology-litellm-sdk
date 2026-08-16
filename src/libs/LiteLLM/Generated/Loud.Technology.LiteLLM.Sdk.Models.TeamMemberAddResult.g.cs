
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Result of a single team member add operation
    /// </summary>
    public sealed partial class TeamMemberAddResult
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_user")]
        public object? UpdatedUser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_team_membership")]
        public object? UpdatedTeamMembership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberAddResult" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="error"></param>
        /// <param name="updatedUser"></param>
        /// <param name="updatedTeamMembership"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberAddResult(
            bool success,
            string? userId,
            string? userEmail,
            string? error,
            object? updatedUser,
            object? updatedTeamMembership)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.Success = success;
            this.Error = error;
            this.UpdatedUser = updatedUser;
            this.UpdatedTeamMembership = updatedTeamMembership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberAddResult" /> class.
        /// </summary>
        public TeamMemberAddResult()
        {
        }

    }
}