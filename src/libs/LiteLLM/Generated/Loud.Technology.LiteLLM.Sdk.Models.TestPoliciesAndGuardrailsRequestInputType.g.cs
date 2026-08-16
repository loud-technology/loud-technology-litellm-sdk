
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Whether inputs are request or response<br/>
    /// Default Value: request
    /// </summary>
    public enum TestPoliciesAndGuardrailsRequestInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Request,
        /// <summary>
        /// 
        /// </summary>
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestPoliciesAndGuardrailsRequestInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestPoliciesAndGuardrailsRequestInputType value)
        {
            return value switch
            {
                TestPoliciesAndGuardrailsRequestInputType.Request => "request",
                TestPoliciesAndGuardrailsRequestInputType.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestPoliciesAndGuardrailsRequestInputType? ToEnum(string value)
        {
            return value switch
            {
                "request" => TestPoliciesAndGuardrailsRequestInputType.Request,
                "response" => TestPoliciesAndGuardrailsRequestInputType.Response,
                _ => null,
            };
        }
    }
}