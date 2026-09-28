
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateUserBannerResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("banner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.UserBanner Banner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserBannerResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="banner"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateUserBannerResponse(
            string message,
            global::Loud.Technology.LiteLLM.Sdk.UserBanner banner)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Banner = banner ?? throw new global::System.ArgumentNullException(nameof(banner));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUserBannerResponse" /> class.
        /// </summary>
        public UpdateUserBannerResponse()
        {
        }

    }
}