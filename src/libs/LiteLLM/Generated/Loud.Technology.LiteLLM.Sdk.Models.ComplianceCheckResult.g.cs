
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Result of a single compliance check.
    /// </summary>
    public sealed partial class ComplianceCheckResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("article")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Article { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceCheckResult" /> class.
        /// </summary>
        /// <param name="article"></param>
        /// <param name="checkName"></param>
        /// <param name="detail"></param>
        /// <param name="passed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComplianceCheckResult(
            string article,
            string checkName,
            string detail,
            bool passed)
        {
            this.Article = article ?? throw new global::System.ArgumentNullException(nameof(article));
            this.CheckName = checkName ?? throw new global::System.ArgumentNullException(nameof(checkName));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.Passed = passed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplianceCheckResult" /> class.
        /// </summary>
        public ComplianceCheckResult()
        {
        }

    }
}