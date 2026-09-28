
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateRouterConfigOptionalPreCallChecksVariant1Item
    {
        /// <summary>
        ///
        /// </summary>
        DeploymentAffinity,
        /// <summary>
        ///
        /// </summary>
        EncryptedContentAffinity,
        /// <summary>
        ///
        /// </summary>
        EnforceModelRateLimits,
        /// <summary>
        ///
        /// </summary>
        ForwardClientHeadersByModelGroup,
        /// <summary>
        ///
        /// </summary>
        PromptCaching,
        /// <summary>
        ///
        /// </summary>
        ResponsesApiDeploymentCheck,
        /// <summary>
        ///
        /// </summary>
        RouterBudgetLimiting,
        /// <summary>
        ///
        /// </summary>
        SessionAffinity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRouterConfigOptionalPreCallChecksVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRouterConfigOptionalPreCallChecksVariant1Item value)
        {
            return value switch
            {
                UpdateRouterConfigOptionalPreCallChecksVariant1Item.DeploymentAffinity => "deployment_affinity",
                UpdateRouterConfigOptionalPreCallChecksVariant1Item.EncryptedContentAffinity => "encrypted_content_affinity",
                UpdateRouterConfigOptionalPreCallChecksVariant1Item.EnforceModelRateLimits => "enforce_model_rate_limits",
                UpdateRouterConfigOptionalPreCallChecksVariant1Item.ForwardClientHeadersByModelGroup => "forward_client_headers_by_model_group",
                UpdateRouterConfigOptionalPreCallChecksVariant1Item.PromptCaching => "prompt_caching",
                UpdateRouterConfigOptionalPreCallChecksVariant1Item.ResponsesApiDeploymentCheck => "responses_api_deployment_check",
                UpdateRouterConfigOptionalPreCallChecksVariant1Item.RouterBudgetLimiting => "router_budget_limiting",
                UpdateRouterConfigOptionalPreCallChecksVariant1Item.SessionAffinity => "session_affinity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRouterConfigOptionalPreCallChecksVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "deployment_affinity" => UpdateRouterConfigOptionalPreCallChecksVariant1Item.DeploymentAffinity,
                "encrypted_content_affinity" => UpdateRouterConfigOptionalPreCallChecksVariant1Item.EncryptedContentAffinity,
                "enforce_model_rate_limits" => UpdateRouterConfigOptionalPreCallChecksVariant1Item.EnforceModelRateLimits,
                "forward_client_headers_by_model_group" => UpdateRouterConfigOptionalPreCallChecksVariant1Item.ForwardClientHeadersByModelGroup,
                "prompt_caching" => UpdateRouterConfigOptionalPreCallChecksVariant1Item.PromptCaching,
                "responses_api_deployment_check" => UpdateRouterConfigOptionalPreCallChecksVariant1Item.ResponsesApiDeploymentCheck,
                "router_budget_limiting" => UpdateRouterConfigOptionalPreCallChecksVariant1Item.RouterBudgetLimiting,
                "session_affinity" => UpdateRouterConfigOptionalPreCallChecksVariant1Item.SessionAffinity,
                _ => null,
            };
        }
    }
}