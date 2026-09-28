
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageUnitsDailyPoint
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, int> Units { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageUnitsDailyPoint" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="units"></param>
        /// <param name="cost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageUnitsDailyPoint(
            string date,
            global::System.Collections.Generic.Dictionary<string, int> units,
            double? cost)
        {
            this.Cost = cost;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Units = units ?? throw new global::System.ArgumentNullException(nameof(units));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageUnitsDailyPoint" /> class.
        /// </summary>
        public UsageUnitsDailyPoint()
        {
        }

    }
}