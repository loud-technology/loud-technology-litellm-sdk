
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// A shadow-eval job over one or more targets, each with its own budget and stop state;<br/>
    /// status is derived from stopped_by, the targets' stop and budget state, and ends_at,<br/>
    /// never stored, so no writer anywhere can produce an inconsistent one. Aggregate<br/>
    /// fields are populated by the detail endpoint only and stay None on list responses.
    /// </summary>
    public sealed partial class ShadowEvalJobResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// The targets whose traffic this job evaluates, and only theirs, each with its own budget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobTargetResponse> Targets { get; set; }

        /// <summary>
        /// Every auto-router this job runs as a shadow arm. Multi-router jobs sample one slice of traffic and judge every arm against the same real responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RouterNames { get; set; }

        /// <summary>
        /// Model groups the sampled traffic is narrowed to; empty means every model the targets use<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Default Value: forward
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ShadowEvalJobResponseDirectionJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponseDirection? Direction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_model")]
        public string? BaselineModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JudgeModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow_percentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ShadowPercentage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ends_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndsAt { get; set; }

        /// <summary>
        /// The operator who stopped the job early, recorded by the stop endpoint; 'unknown' backfilled by migration for jobs that displayed stopped when the column arrived; None when the job ended on its own. Its presence is what makes a job read stopped rather than completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopped_by")]
        public string? StoppedBy { get; set; }

        /// <summary>
        /// Verdicts recorded; detail endpoint only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judged_count")]
        public int? JudgedCount { get; set; }

        /// <summary>
        /// Sampled attempts that errored; detail endpoint only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_count")]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// Judge cost so far; detail endpoint only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_spend")]
        public double? JudgeSpend { get; set; }

        /// <summary>
        /// Most recent attempt error; detail endpoint only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public string? LastError { get; set; }

        /// <summary>
        /// Stratified verdicts; detail endpoint only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::Loud.Technology.LiteLLM.Sdk.ShadowEvalResult? Results { get; set; }

        /// <summary>
        /// The first router, kept for callers that predate router_names; derived so the<br/>
        /// two fields can never disagree.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("router_name")]
        public string RouterName { get; set; } = default!;

        /// <summary>
        /// Three recorded facts, no history-guessing: a stop is stopped_by (the migration<br/>
        /// backfills it for every job that displayed stopped when the column arrived, so the<br/>
        /// pre-column population is closed), completion is the window passing or every target<br/>
        /// spending its budget, and anything else is running. The all-targets-stamped fallback<br/>
        /// covers only stops written by pre-column pods during a rolling deploy.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.ShadowEvalJobResponseStatusJsonConverter))]
        public global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowEvalJobResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="targets">
        /// The targets whose traffic this job evaluates, and only theirs, each with its own budget
        /// </param>
        /// <param name="routerNames">
        /// Every auto-router this job runs as a shadow arm. Multi-router jobs sample one slice of traffic and judge every arm against the same real responses
        /// </param>
        /// <param name="judgeModel"></param>
        /// <param name="shadowPercentage"></param>
        /// <param name="createdAt"></param>
        /// <param name="endsAt"></param>
        /// <param name="models">
        /// Model groups the sampled traffic is narrowed to; empty means every model the targets use<br/>
        /// Default Value: []
        /// </param>
        /// <param name="direction">
        /// Default Value: forward
        /// </param>
        /// <param name="baselineModel"></param>
        /// <param name="stoppedBy">
        /// The operator who stopped the job early, recorded by the stop endpoint; 'unknown' backfilled by migration for jobs that displayed stopped when the column arrived; None when the job ended on its own. Its presence is what makes a job read stopped rather than completed
        /// </param>
        /// <param name="judgedCount">
        /// Verdicts recorded; detail endpoint only
        /// </param>
        /// <param name="errorCount">
        /// Sampled attempts that errored; detail endpoint only
        /// </param>
        /// <param name="judgeSpend">
        /// Judge cost so far; detail endpoint only
        /// </param>
        /// <param name="lastError">
        /// Most recent attempt error; detail endpoint only
        /// </param>
        /// <param name="results">
        /// Stratified verdicts; detail endpoint only
        /// </param>
        /// <param name="routerName">
        /// The first router, kept for callers that predate router_names; derived so the<br/>
        /// two fields can never disagree.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Three recorded facts, no history-guessing: a stop is stopped_by (the migration<br/>
        /// backfills it for every job that displayed stopped when the column arrived, so the<br/>
        /// pre-column population is closed), completion is the window passing or every target<br/>
        /// spending its budget, and anything else is running. The all-targets-stamped fallback<br/>
        /// covers only stops written by pre-column pods during a rolling deploy.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShadowEvalJobResponse(
            string jobId,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobTargetResponse> targets,
            global::System.Collections.Generic.IList<string> routerNames,
            string judgeModel,
            double shadowPercentage,
            global::System.DateTime createdAt,
            global::System.DateTime endsAt,
            global::System.Collections.Generic.IList<string>? models,
            global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponseDirection? direction,
            string? baselineModel,
            string? stoppedBy,
            int? judgedCount,
            int? errorCount,
            double? judgeSpend,
            string? lastError,
            global::Loud.Technology.LiteLLM.Sdk.ShadowEvalResult? results,
            string routerName = default!,
            global::Loud.Technology.LiteLLM.Sdk.ShadowEvalJobResponseStatus status = default!)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.RouterNames = routerNames ?? throw new global::System.ArgumentNullException(nameof(routerNames));
            this.Models = models;
            this.Direction = direction;
            this.BaselineModel = baselineModel;
            this.JudgeModel = judgeModel ?? throw new global::System.ArgumentNullException(nameof(judgeModel));
            this.ShadowPercentage = shadowPercentage;
            this.CreatedAt = createdAt;
            this.EndsAt = endsAt;
            this.StoppedBy = stoppedBy;
            this.JudgedCount = judgedCount;
            this.ErrorCount = errorCount;
            this.JudgeSpend = judgeSpend;
            this.LastError = lastError;
            this.Results = results;
            this.RouterName = routerName;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShadowEvalJobResponse" /> class.
        /// </summary>
        public ShadowEvalJobResponse()
        {
        }

    }
}