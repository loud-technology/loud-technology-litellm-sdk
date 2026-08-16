
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Represents a run from the OpenAI Evals API
    /// </summary>
    public sealed partial class Run
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public int? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DataSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public object? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EvalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: eval.run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_model_usage")]
        public object? PerModelUsage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_testing_criteria_results")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PerTestingCriteriaResult>? PerTestingCriteriaResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("report_url")]
        public string? ReportUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_counts")]
        public global::System.Collections.Generic.Dictionary<string, int>? ResultCounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_with_openai")]
        public bool? SharedWithOpenai { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        public int? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.LiteLLM.Sdk.JsonConverters.RunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.LiteLLM.Sdk.RunStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="dataSource"></param>
        /// <param name="evalId"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="completedAt"></param>
        /// <param name="error"></param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="name"></param>
        /// <param name="object">
        /// Default Value: eval.run
        /// </param>
        /// <param name="perModelUsage"></param>
        /// <param name="perTestingCriteriaResults"></param>
        /// <param name="reportUrl"></param>
        /// <param name="resultCounts"></param>
        /// <param name="sharedWithOpenai"></param>
        /// <param name="startedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Run(
            int createdAt,
            object dataSource,
            string evalId,
            string id,
            global::Loud.Technology.LiteLLM.Sdk.RunStatus status,
            int? completedAt,
            object? error,
            object? metadata,
            string? model,
            string? name,
            string? @object,
            object? perModelUsage,
            global::System.Collections.Generic.IList<global::Loud.Technology.LiteLLM.Sdk.PerTestingCriteriaResult>? perTestingCriteriaResults,
            string? reportUrl,
            global::System.Collections.Generic.Dictionary<string, int>? resultCounts,
            bool? sharedWithOpenai,
            int? startedAt)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.DataSource = dataSource ?? throw new global::System.ArgumentNullException(nameof(dataSource));
            this.Error = error;
            this.EvalId = evalId ?? throw new global::System.ArgumentNullException(nameof(evalId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Metadata = metadata;
            this.Model = model;
            this.Name = name;
            this.Object = @object;
            this.PerModelUsage = perModelUsage;
            this.PerTestingCriteriaResults = perTestingCriteriaResults;
            this.ReportUrl = reportUrl;
            this.ResultCounts = resultCounts;
            this.SharedWithOpenai = sharedWithOpenai;
            this.StartedAt = startedAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        public Run()
        {
        }

    }
}