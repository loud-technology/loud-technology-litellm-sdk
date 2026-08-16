#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// ✨ (Enterprise) Retrieve Fine-Tuning Job<br/>
        /// Retrieves a fine-tuning job.<br/>
        /// This is the equivalent of GET https://api.openai.com/v1/fine_tuning/jobs/{fine_tuning_job_id}<br/>
        /// Supported Query Params:<br/>
        /// - `custom_llm_provider`: Name of the LiteLLM provider<br/>
        /// - `fine_tuning_job_id`: The ID of the fine-tuning job to retrieve.
        /// </summary>
        /// <param name="fineTuningJobId"></param>
        /// <param name="customLlmProvider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetAsync(
            string fineTuningJobId,
            global::Loud.Technology.LiteLLM.Sdk.RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ (Enterprise) Retrieve Fine-Tuning Job<br/>
        /// Retrieves a fine-tuning job.<br/>
        /// This is the equivalent of GET https://api.openai.com/v1/fine_tuning/jobs/{fine_tuning_job_id}<br/>
        /// Supported Query Params:<br/>
        /// - `custom_llm_provider`: Name of the LiteLLM provider<br/>
        /// - `fine_tuning_job_id`: The ID of the fine-tuning job to retrieve.
        /// </summary>
        /// <param name="fineTuningJobId"></param>
        /// <param name="customLlmProvider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetAsResponseAsync(
            string fineTuningJobId,
            global::Loud.Technology.LiteLLM.Sdk.RetrieveFineTuningJobV1FineTuningJobsFineTuningJobIdGetCustomLlmProvider2? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}