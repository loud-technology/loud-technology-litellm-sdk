
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CalculateSpendSpendCalculatePostResponse
    {
        /// <summary>
        /// The calculated cost<br/>
        /// Example: 0F
        /// </summary>
        /// <example>0F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateSpendSpendCalculatePostResponse" /> class.
        /// </summary>
        /// <param name="cost">
        /// The calculated cost<br/>
        /// Example: 0F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CalculateSpendSpendCalculatePostResponse(
            double? cost)
        {
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateSpendSpendCalculatePostResponse" /> class.
        /// </summary>
        public CalculateSpendSpendCalculatePostResponse()
        {
        }

    }
}