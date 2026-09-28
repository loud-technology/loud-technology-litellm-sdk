
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomDimension
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Weight { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keywords")]
        public global::System.Collections.Generic.IList<string>? Keywords { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patterns")]
        public global::System.Collections.Generic.IList<string>? Patterns { get; set; }

        /// <summary>
        /// 'binary' scores 1 when any matcher hits. 'match_count' scores 0.5 when one distinct matcher hits and 1 when two or more do; repeated occurrences of one matcher never raise it. Keywords are distinct case-insensitively, patterns by source, and a keyword and a pattern are always distinct from each other.<br/>
        /// Default Value: binary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scoring_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.CustomDimensionScoringModeJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.CustomDimensionScoringMode? ScoringMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDimension" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="keywords">
        /// Default Value: []
        /// </param>
        /// <param name="patterns">
        /// Default Value: []
        /// </param>
        /// <param name="scoringMode">
        /// 'binary' scores 1 when any matcher hits. 'match_count' scores 0.5 when one distinct matcher hits and 1 when two or more do; repeated occurrences of one matcher never raise it. Keywords are distinct case-insensitively, patterns by source, and a keyword and a pattern are always distinct from each other.<br/>
        /// Default Value: binary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomDimension(
            string name,
            double weight,
            global::System.Collections.Generic.IList<string>? keywords,
            global::System.Collections.Generic.IList<string>? patterns,
            global::Loud.Technology.LiteLLM.Sdk.CustomDimensionScoringMode? scoringMode)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Weight = weight;
            this.Keywords = keywords;
            this.Patterns = patterns;
            this.ScoringMode = scoringMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDimension" /> class.
        /// </summary>
        public CustomDimension()
        {
        }

    }
}