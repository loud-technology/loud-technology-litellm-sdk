
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Optional versioned sigmoid calibration fitted for this judge, capability card, efficient model, and execution setup. Applies sigmoid(slope * logit(clip(p_solve, 1e-6, 1-1e-6)) + intercept) before the threshold policy. Omit to route on the raw forecast.
    /// </summary>
    public sealed partial class CapabilityClassifierConfigCalibration
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}