
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelDeprecationInfo
    {
        /// <summary>
        /// The public name of the model on the proxy (model_group).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// The underlying litellm model string the deprecation date is sourced from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_model")]
        public string? LitellmModel { get; set; }

        /// <summary>
        /// The date (UTC) when the model becomes deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecation_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DeprecationDate { get; set; }

        /// <summary>
        /// Days remaining until the deprecation date. Negative if the model is already deprecated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days_until_deprecation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DaysUntilDeprecation { get; set; }

        /// <summary>
        /// 'deprecated' if the date has passed, 'imminent' if it falls within warn_within_days, 'upcoming' otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ModelDeprecationInfoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ModelDeprecationInfoStatus Status { get; set; }

        /// <summary>
        /// The provider this model belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_provider")]
        public string? LitellmProvider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDeprecationInfo" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The public name of the model on the proxy (model_group).
        /// </param>
        /// <param name="deprecationDate">
        /// The date (UTC) when the model becomes deprecated.
        /// </param>
        /// <param name="daysUntilDeprecation">
        /// Days remaining until the deprecation date. Negative if the model is already deprecated.
        /// </param>
        /// <param name="status">
        /// 'deprecated' if the date has passed, 'imminent' if it falls within warn_within_days, 'upcoming' otherwise.
        /// </param>
        /// <param name="litellmModel">
        /// The underlying litellm model string the deprecation date is sourced from.
        /// </param>
        /// <param name="litellmProvider">
        /// The provider this model belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelDeprecationInfo(
            string modelName,
            global::System.DateTime deprecationDate,
            int daysUntilDeprecation,
            global::Loud.Technology.LiteLLM.Sdk.ModelDeprecationInfoStatus status,
            string? litellmModel,
            string? litellmProvider)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.LitellmModel = litellmModel;
            this.DeprecationDate = deprecationDate;
            this.DaysUntilDeprecation = daysUntilDeprecation;
            this.Status = status;
            this.LitellmProvider = litellmProvider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDeprecationInfo" /> class.
        /// </summary>
        public ModelDeprecationInfo()
        {
        }

    }
}