
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Outcome for one requested member, in request order.
    /// </summary>
    public sealed partial class TeamMemberDeleteResult
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberDeleteResult" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamMemberDeleteResult(
            bool success,
            string? userId,
            string? userEmail,
            string? error)
        {
            this.UserId = userId;
            this.UserEmail = userEmail;
            this.Success = success;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamMemberDeleteResult" /> class.
        /// </summary>
        public TeamMemberDeleteResult()
        {
        }

    }
}