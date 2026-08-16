
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum AddTeamCallbackCallbackType2
    {
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        SuccessAndFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddTeamCallbackCallbackType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddTeamCallbackCallbackType2 value)
        {
            return value switch
            {
                AddTeamCallbackCallbackType2.Failure => "failure",
                AddTeamCallbackCallbackType2.Success => "success",
                AddTeamCallbackCallbackType2.SuccessAndFailure => "success_and_failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddTeamCallbackCallbackType2? ToEnum(string value)
        {
            return value switch
            {
                "failure" => AddTeamCallbackCallbackType2.Failure,
                "success" => AddTeamCallbackCallbackType2.Success,
                "success_and_failure" => AddTeamCallbackCallbackType2.SuccessAndFailure,
                _ => null,
            };
        }
    }
}