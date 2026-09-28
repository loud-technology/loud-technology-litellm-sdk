#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    public partial interface IFineTuningClient
    {
        /// <summary>
        /// ✨ (Enterprise) Create Fine-Tuning Job<br/>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/fine_tuning/jobs<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/fine-tuning/create<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/fine_tuning/jobs       -H "Content-Type: application/json"       -H "Authorization: Bearer sk-1234"       -d '{<br/>
        ///     "model": "gpt-3.5-turbo",<br/>
        ///     "training_file": "file-abc123",<br/>
        ///     "hyperparameters": {<br/>
        ///       "n_epochs": 4<br/>
        ///     }<br/>
        ///   }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateFineTuningJobV1FineTuningJobsPostAsync(

            global::Loud.Technology.LiteLLM.Sdk.LiteLLMFineTuningJobCreate request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ (Enterprise) Create Fine-Tuning Job<br/>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/fine_tuning/jobs<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/fine-tuning/create<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/fine_tuning/jobs       -H "Content-Type: application/json"       -H "Authorization: Bearer sk-1234"       -d '{<br/>
        ///     "model": "gpt-3.5-turbo",<br/>
        ///     "training_file": "file-abc123",<br/>
        ///     "hyperparameters": {<br/>
        ///       "n_epochs": 4<br/>
        ///     }<br/>
        ///   }'<br/>
        /// ```
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.LiteLLM.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.LiteLLM.Sdk.AutoSDKHttpResponse<string>> CreateFineTuningJobV1FineTuningJobsPostAsResponseAsync(

            global::Loud.Technology.LiteLLM.Sdk.LiteLLMFineTuningJobCreate request,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ (Enterprise) Create Fine-Tuning Job<br/>
        /// Creates a fine-tuning job which begins the process of creating a new model from a given dataset.<br/>
        /// This is the equivalent of POST https://api.openai.com/v1/fine_tuning/jobs<br/>
        /// Supports Identical Params as: https://platform.openai.com/docs/api-reference/fine-tuning/create<br/>
        /// Example Curl:<br/>
        /// ```<br/>
        /// curl http://localhost:4000/v1/fine_tuning/jobs       -H "Content-Type: application/json"       -H "Authorization: Bearer sk-1234"       -d '{<br/>
        ///     "model": "gpt-3.5-turbo",<br/>
        ///     "training_file": "file-abc123",<br/>
        ///     "hyperparameters": {<br/>
        ///       "n_epochs": 4<br/>
        ///     }<br/>
        ///   }'<br/>
        /// ```
        /// </summary>
        /// <param name="model"></param>
        /// <param name="trainingFile"></param>
        /// <param name="hyperparameters"></param>
        /// <param name="suffix"></param>
        /// <param name="validationFile"></param>
        /// <param name="integrations"></param>
        /// <param name="seed"></param>
        /// <param name="customLlmProvider"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateFineTuningJobV1FineTuningJobsPostAsync(
            string model,
            string trainingFile,
            global::Loud.Technology.LiteLLM.Sdk.Hyperparameters? hyperparameters = default,
            string? suffix = default,
            string? validationFile = default,
            global::System.Collections.Generic.IList<string>? integrations = default,
            int? seed = default,
            global::Loud.Technology.LiteLLM.Sdk.LiteLLMFineTuningJobCreateCustomLlmProvider2? customLlmProvider = default,
            global::Loud.Technology.LiteLLM.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}