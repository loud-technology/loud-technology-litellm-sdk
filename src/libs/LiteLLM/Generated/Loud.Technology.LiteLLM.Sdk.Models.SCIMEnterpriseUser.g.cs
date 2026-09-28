
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SCIMEnterpriseUser
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costCenter")]
        public string? CostCenter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("division")]
        public string? Division { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("employeeNumber")]
        public string? EmployeeNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manager")]
        public global::Loud.Technology.LiteLLM.Sdk.SCIMUserManager? Manager { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public string? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMEnterpriseUser" /> class.
        /// </summary>
        /// <param name="costCenter"></param>
        /// <param name="department"></param>
        /// <param name="division"></param>
        /// <param name="employeeNumber"></param>
        /// <param name="manager"></param>
        /// <param name="organization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SCIMEnterpriseUser(
            string? costCenter,
            string? department,
            string? division,
            string? employeeNumber,
            global::Loud.Technology.LiteLLM.Sdk.SCIMUserManager? manager,
            string? organization)
        {
            this.CostCenter = costCenter;
            this.Department = department;
            this.Division = division;
            this.EmployeeNumber = employeeNumber;
            this.Manager = manager;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SCIMEnterpriseUser" /> class.
        /// </summary>
        public SCIMEnterpriseUser()
        {
        }

    }
}