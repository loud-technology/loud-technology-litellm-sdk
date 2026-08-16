
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Results for a specific testing criteria
    /// </summary>
    public sealed partial class PerTestingCriteriaResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_score")]
        public double? AverageScore { get; set; }

        /// <summary>
        /// Result counts for a run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.ResultCounts ResultCounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testing_criteria_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TestingCriteriaIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerTestingCriteriaResult" /> class.
        /// </summary>
        /// <param name="resultCounts">
        /// Result counts for a run
        /// </param>
        /// <param name="testingCriteriaIndex"></param>
        /// <param name="averageScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerTestingCriteriaResult(
            global::Loud.Technology.LiteLLM.Sdk.ResultCounts resultCounts,
            int testingCriteriaIndex,
            double? averageScore)
        {
            this.AverageScore = averageScore;
            this.ResultCounts = resultCounts ?? throw new global::System.ArgumentNullException(nameof(resultCounts));
            this.TestingCriteriaIndex = testingCriteriaIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerTestingCriteriaResult" /> class.
        /// </summary>
        public PerTestingCriteriaResult()
        {
        }

    }
}