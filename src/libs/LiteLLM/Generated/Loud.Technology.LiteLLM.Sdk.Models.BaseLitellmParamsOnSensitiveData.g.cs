
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Action to take when sensitive data is detected. 'block' raises an exception (default behavior). 'route' reroutes the request to the model specified in sensitive_data_route_to_model.
    /// </summary>
    public sealed partial class BaseLitellmParamsOnSensitiveData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}