
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChangePasswordRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentPassword { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewPassword { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        /// <param name="currentPassword"></param>
        /// <param name="newPassword"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChangePasswordRequest(
            string currentPassword,
            string newPassword)
        {
            this.CurrentPassword = currentPassword ?? throw new global::System.ArgumentNullException(nameof(currentPassword));
            this.NewPassword = newPassword ?? throw new global::System.ArgumentNullException(nameof(newPassword));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        public ChangePasswordRequest()
        {
        }

    }
}