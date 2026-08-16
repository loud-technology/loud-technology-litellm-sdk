
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Types of validation errors that can occur.
    /// </summary>
    public enum PolicyValidationErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        CircularInheritance,
        /// <summary>
        /// 
        /// </summary>
        InvalidGuardrail,
        /// <summary>
        /// 
        /// </summary>
        InvalidInheritance,
        /// <summary>
        /// 
        /// </summary>
        InvalidKey,
        /// <summary>
        /// 
        /// </summary>
        InvalidModel,
        /// <summary>
        /// 
        /// </summary>
        InvalidScope,
        /// <summary>
        /// 
        /// </summary>
        InvalidSyntax,
        /// <summary>
        /// 
        /// </summary>
        InvalidTeam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PolicyValidationErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PolicyValidationErrorType value)
        {
            return value switch
            {
                PolicyValidationErrorType.CircularInheritance => "circular_inheritance",
                PolicyValidationErrorType.InvalidGuardrail => "invalid_guardrail",
                PolicyValidationErrorType.InvalidInheritance => "invalid_inheritance",
                PolicyValidationErrorType.InvalidKey => "invalid_key",
                PolicyValidationErrorType.InvalidModel => "invalid_model",
                PolicyValidationErrorType.InvalidScope => "invalid_scope",
                PolicyValidationErrorType.InvalidSyntax => "invalid_syntax",
                PolicyValidationErrorType.InvalidTeam => "invalid_team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PolicyValidationErrorType? ToEnum(string value)
        {
            return value switch
            {
                "circular_inheritance" => PolicyValidationErrorType.CircularInheritance,
                "invalid_guardrail" => PolicyValidationErrorType.InvalidGuardrail,
                "invalid_inheritance" => PolicyValidationErrorType.InvalidInheritance,
                "invalid_key" => PolicyValidationErrorType.InvalidKey,
                "invalid_model" => PolicyValidationErrorType.InvalidModel,
                "invalid_scope" => PolicyValidationErrorType.InvalidScope,
                "invalid_syntax" => PolicyValidationErrorType.InvalidSyntax,
                "invalid_team" => PolicyValidationErrorType.InvalidTeam,
                _ => null,
            };
        }
    }
}