
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmailEvent
    {
        /// <summary>
        /// 
        /// </summary>
        MaxBudgetAlert,
        /// <summary>
        /// 
        /// </summary>
        NewUserInvitation,
        /// <summary>
        /// 
        /// </summary>
        SoftBudgetCrossed,
        /// <summary>
        /// 
        /// </summary>
        VirtualKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        VirtualKeyRotated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailEvent value)
        {
            return value switch
            {
                EmailEvent.MaxBudgetAlert => "Max Budget Alert",
                EmailEvent.NewUserInvitation => "New User Invitation",
                EmailEvent.SoftBudgetCrossed => "Soft Budget Crossed",
                EmailEvent.VirtualKeyCreated => "Virtual Key Created",
                EmailEvent.VirtualKeyRotated => "Virtual Key Rotated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailEvent? ToEnum(string value)
        {
            return value switch
            {
                "Max Budget Alert" => EmailEvent.MaxBudgetAlert,
                "New User Invitation" => EmailEvent.NewUserInvitation,
                "Soft Budget Crossed" => EmailEvent.SoftBudgetCrossed,
                "Virtual Key Created" => EmailEvent.VirtualKeyCreated,
                "Virtual Key Rotated" => EmailEvent.VirtualKeyRotated,
                _ => null,
            };
        }
    }
}