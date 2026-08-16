
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum HealthServicesEndpointHealthServicesGetService2
    {
        /// <summary>
        /// 
        /// </summary>
        Arize,
        /// <summary>
        /// 
        /// </summary>
        Braintrust,
        /// <summary>
        /// 
        /// </summary>
        Datadog,
        /// <summary>
        /// 
        /// </summary>
        DatadogLlmObservability,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Galileo,
        /// <summary>
        /// 
        /// </summary>
        GenericApi,
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        LangfuseOtel,
        /// <summary>
        /// 
        /// </summary>
        Newrelic,
        /// <summary>
        /// 
        /// </summary>
        Openmeter,
        /// <summary>
        /// 
        /// </summary>
        Slack,
        /// <summary>
        /// 
        /// </summary>
        SlackBudgetAlerts,
        /// <summary>
        /// 
        /// </summary>
        Sqs,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HealthServicesEndpointHealthServicesGetService2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HealthServicesEndpointHealthServicesGetService2 value)
        {
            return value switch
            {
                HealthServicesEndpointHealthServicesGetService2.Arize => "arize",
                HealthServicesEndpointHealthServicesGetService2.Braintrust => "braintrust",
                HealthServicesEndpointHealthServicesGetService2.Datadog => "datadog",
                HealthServicesEndpointHealthServicesGetService2.DatadogLlmObservability => "datadog_llm_observability",
                HealthServicesEndpointHealthServicesGetService2.Email => "email",
                HealthServicesEndpointHealthServicesGetService2.Galileo => "galileo",
                HealthServicesEndpointHealthServicesGetService2.GenericApi => "generic_api",
                HealthServicesEndpointHealthServicesGetService2.Langfuse => "langfuse",
                HealthServicesEndpointHealthServicesGetService2.LangfuseOtel => "langfuse_otel",
                HealthServicesEndpointHealthServicesGetService2.Newrelic => "newrelic",
                HealthServicesEndpointHealthServicesGetService2.Openmeter => "openmeter",
                HealthServicesEndpointHealthServicesGetService2.Slack => "slack",
                HealthServicesEndpointHealthServicesGetService2.SlackBudgetAlerts => "slack_budget_alerts",
                HealthServicesEndpointHealthServicesGetService2.Sqs => "sqs",
                HealthServicesEndpointHealthServicesGetService2.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HealthServicesEndpointHealthServicesGetService2? ToEnum(string value)
        {
            return value switch
            {
                "arize" => HealthServicesEndpointHealthServicesGetService2.Arize,
                "braintrust" => HealthServicesEndpointHealthServicesGetService2.Braintrust,
                "datadog" => HealthServicesEndpointHealthServicesGetService2.Datadog,
                "datadog_llm_observability" => HealthServicesEndpointHealthServicesGetService2.DatadogLlmObservability,
                "email" => HealthServicesEndpointHealthServicesGetService2.Email,
                "galileo" => HealthServicesEndpointHealthServicesGetService2.Galileo,
                "generic_api" => HealthServicesEndpointHealthServicesGetService2.GenericApi,
                "langfuse" => HealthServicesEndpointHealthServicesGetService2.Langfuse,
                "langfuse_otel" => HealthServicesEndpointHealthServicesGetService2.LangfuseOtel,
                "newrelic" => HealthServicesEndpointHealthServicesGetService2.Newrelic,
                "openmeter" => HealthServicesEndpointHealthServicesGetService2.Openmeter,
                "slack" => HealthServicesEndpointHealthServicesGetService2.Slack,
                "slack_budget_alerts" => HealthServicesEndpointHealthServicesGetService2.SlackBudgetAlerts,
                "sqs" => HealthServicesEndpointHealthServicesGetService2.Sqs,
                "webhook" => HealthServicesEndpointHealthServicesGetService2.Webhook,
                _ => null,
            };
        }
    }
}