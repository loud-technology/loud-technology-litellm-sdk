
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddTeamCallback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallbackName { get; set; }

        /// <summary>
        /// Default Value: success_and_failure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_type")]
        public global::Loud.Technology.LiteLLM.Sdk.AddTeamCallbackCallbackType2? CallbackType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_vars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> CallbackVars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTeamCallback" /> class.
        /// </summary>
        /// <param name="callbackName"></param>
        /// <param name="callbackVars"></param>
        /// <param name="callbackType">
        /// Default Value: success_and_failure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddTeamCallback(
            string callbackName,
            global::System.Collections.Generic.Dictionary<string, string> callbackVars,
            global::Loud.Technology.LiteLLM.Sdk.AddTeamCallbackCallbackType2? callbackType)
        {
            this.CallbackName = callbackName ?? throw new global::System.ArgumentNullException(nameof(callbackName));
            this.CallbackType = callbackType;
            this.CallbackVars = callbackVars ?? throw new global::System.ArgumentNullException(nameof(callbackVars));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddTeamCallback" /> class.
        /// </summary>
        public AddTeamCallback()
        {
        }

    }
}