
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelDeprecationResponse
    {
        /// <summary>
        /// Models whose deprecation date has already passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ModelDeprecationInfo>? Deprecated { get; set; }

        /// <summary>
        /// Models whose deprecation date is within warn_within_days from today and require immediate migration planning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imminent")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ModelDeprecationInfo>? Imminent { get; set; }

        /// <summary>
        /// Models with a future deprecation date outside the warn window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upcoming")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ModelDeprecationInfo>? Upcoming { get; set; }

        /// <summary>
        /// The window (in days) used to bucket 'imminent' models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warn_within_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WarnWithinDays { get; set; }

        /// <summary>
        /// UTC timestamp when the deprecation snapshot was generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checked_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CheckedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDeprecationResponse" /> class.
        /// </summary>
        /// <param name="warnWithinDays">
        /// The window (in days) used to bucket 'imminent' models.
        /// </param>
        /// <param name="checkedAt">
        /// UTC timestamp when the deprecation snapshot was generated.
        /// </param>
        /// <param name="deprecated">
        /// Models whose deprecation date has already passed.
        /// </param>
        /// <param name="imminent">
        /// Models whose deprecation date is within warn_within_days from today and require immediate migration planning.
        /// </param>
        /// <param name="upcoming">
        /// Models with a future deprecation date outside the warn window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelDeprecationResponse(
            int warnWithinDays,
            global::System.DateTime checkedAt,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ModelDeprecationInfo>? deprecated,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ModelDeprecationInfo>? imminent,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ModelDeprecationInfo>? upcoming)
        {
            this.Deprecated = deprecated;
            this.Imminent = imminent;
            this.Upcoming = upcoming;
            this.WarnWithinDays = warnWithinDays;
            this.CheckedAt = checkedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDeprecationResponse" /> class.
        /// </summary>
        public ModelDeprecationResponse()
        {
        }

    }
}