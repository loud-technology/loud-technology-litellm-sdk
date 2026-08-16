
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// List of entity types to exclude from Presidio detection results. Detections of these types will be silently dropped. Useful for suppressing false positives (e.g., US_DRIVER_LICENSE on coding routes).
    /// </summary>
    public sealed partial class LitellmParamsPresidioEntitiesDenyList
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}