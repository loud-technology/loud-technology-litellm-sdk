
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Outcome for one requested user, in request order. `teams_removed` lists the teams the user left.
    /// </summary>
    public sealed partial class UserDeleteResult
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_removed")]
        public global::System.Collections.Generic.IList<string>? TeamsRemoved { get; set; }

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
        /// Initializes a new instance of the <see cref="UserDeleteResult" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="success"></param>
        /// <param name="userEmail"></param>
        /// <param name="teamsRemoved">
        /// Default Value: []
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserDeleteResult(
            string userId,
            bool success,
            string? userEmail,
            global::System.Collections.Generic.IList<string>? teamsRemoved,
            string? error)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserEmail = userEmail;
            this.Success = success;
            this.TeamsRemoved = teamsRemoved;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDeleteResult" /> class.
        /// </summary>
        public UserDeleteResult()
        {
        }

    }
}