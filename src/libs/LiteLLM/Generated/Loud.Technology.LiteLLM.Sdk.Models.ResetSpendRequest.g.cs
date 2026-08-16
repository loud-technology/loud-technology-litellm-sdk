
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResetSpendRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResetTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetSpendRequest" /> class.
        /// </summary>
        /// <param name="resetTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResetSpendRequest(
            double resetTo)
        {
            this.ResetTo = resetTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResetSpendRequest" /> class.
        /// </summary>
        public ResetSpendRequest()
        {
        }

    }
}