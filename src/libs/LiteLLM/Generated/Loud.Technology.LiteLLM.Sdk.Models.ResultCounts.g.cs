
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Result counts for a run
    /// </summary>
    public sealed partial class ResultCounts
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public int? Error { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public int? Failed { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        public int? Passed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultCounts" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="error">
        /// Default Value: 0
        /// </param>
        /// <param name="failed">
        /// Default Value: 0
        /// </param>
        /// <param name="passed">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResultCounts(
            int total,
            int? error,
            int? failed,
            int? passed)
        {
            this.Error = error;
            this.Failed = failed;
            this.Passed = passed;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResultCounts" /> class.
        /// </summary>
        public ResultCounts()
        {
        }

    }
}