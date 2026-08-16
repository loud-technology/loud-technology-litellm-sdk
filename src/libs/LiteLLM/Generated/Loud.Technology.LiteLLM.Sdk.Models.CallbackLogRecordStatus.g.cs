
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum CallbackLogRecordStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallbackLogRecordStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallbackLogRecordStatus value)
        {
            return value switch
            {
                CallbackLogRecordStatus.Failure => "failure",
                CallbackLogRecordStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallbackLogRecordStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => CallbackLogRecordStatus.Failure,
                "success" => CallbackLogRecordStatus.Success,
                _ => null,
            };
        }
    }
}