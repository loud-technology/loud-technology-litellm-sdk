
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetGlobalSpendReportGlobalSpendReportGetGroupBy2
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Customer,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetGlobalSpendReportGlobalSpendReportGetGroupBy2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetGlobalSpendReportGlobalSpendReportGetGroupBy2 value)
        {
            return value switch
            {
                GetGlobalSpendReportGlobalSpendReportGetGroupBy2.ApiKey => "api_key",
                GetGlobalSpendReportGlobalSpendReportGetGroupBy2.Customer => "customer",
                GetGlobalSpendReportGlobalSpendReportGetGroupBy2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetGlobalSpendReportGlobalSpendReportGetGroupBy2? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => GetGlobalSpendReportGlobalSpendReportGetGroupBy2.ApiKey,
                "customer" => GetGlobalSpendReportGlobalSpendReportGetGroupBy2.Customer,
                "team" => GetGlobalSpendReportGlobalSpendReportGetGroupBy2.Team,
                _ => null,
            };
        }
    }
}