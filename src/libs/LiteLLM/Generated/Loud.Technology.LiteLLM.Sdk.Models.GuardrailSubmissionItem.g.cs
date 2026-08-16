
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailSubmissionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_info")]
        public object? GuardrailInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("litellm_params")]
        public object? LitellmParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewed_at")]
        public global::System.DateTime? ReviewedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_at")]
        public global::System.DateTime? SubmittedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_by_email")]
        public string? SubmittedByEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted_by_user_id")]
        public string? SubmittedByUserId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_guardrail")]
        public bool? TeamGuardrail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailSubmissionItem" /> class.
        /// </summary>
        /// <param name="guardrailId"></param>
        /// <param name="guardrailName"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="guardrailInfo"></param>
        /// <param name="litellmParams"></param>
        /// <param name="reviewedAt"></param>
        /// <param name="submittedAt"></param>
        /// <param name="submittedByEmail"></param>
        /// <param name="submittedByUserId"></param>
        /// <param name="teamGuardrail">
        /// Default Value: false
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailSubmissionItem(
            string guardrailId,
            string guardrailName,
            string status,
            global::System.DateTime? createdAt,
            object? guardrailInfo,
            object? litellmParams,
            global::System.DateTime? reviewedAt,
            global::System.DateTime? submittedAt,
            string? submittedByEmail,
            string? submittedByUserId,
            bool? teamGuardrail,
            string? teamId,
            global::System.DateTime? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.GuardrailId = guardrailId ?? throw new global::System.ArgumentNullException(nameof(guardrailId));
            this.GuardrailInfo = guardrailInfo;
            this.GuardrailName = guardrailName ?? throw new global::System.ArgumentNullException(nameof(guardrailName));
            this.LitellmParams = litellmParams;
            this.ReviewedAt = reviewedAt;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.SubmittedAt = submittedAt;
            this.SubmittedByEmail = submittedByEmail;
            this.SubmittedByUserId = submittedByUserId;
            this.TeamGuardrail = teamGuardrail;
            this.TeamId = teamId;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailSubmissionItem" /> class.
        /// </summary>
        public GuardrailSubmissionItem()
        {
        }

    }
}