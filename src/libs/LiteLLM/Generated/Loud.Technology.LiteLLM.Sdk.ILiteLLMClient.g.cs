
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Proxy Server to call 100+ LLMs in the OpenAI format. [**Customize Swagger Docs**](https://docs.litellm.ai/docs/proxy/enterprise#swagger-docs---custom-routes--branding)<br/>
    /// 👉 [```LiteLLM Admin Panel on /ui```](/ui). Create, Edit Keys with SSO. Having issues? Try [```Fallback Login```](/fallback/login)<br/>
    /// 💸 [```LiteLLM Model Cost Map```](https://models.litellm.ai/).<br/>
    /// 🔎 [```LiteLLM Model Hub```](/ui/model_hub_table). See available models on the proxy. [**Docs**](https://docs.litellm.ai/docs/proxy/ai_hub)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ILiteLLMClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Loud.Technology.LiteLLM.Sdk.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Loud.Technology.LiteLLM.Sdk.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public A2aClient A2a { get; }

        /// <summary>
        /// 
        /// </summary>
        public A2aRegistrationClient A2aRegistration { get; }

        /// <summary>
        /// 
        /// </summary>
        public AccessGroupsClient AccessGroups { get; }

        /// <summary>
        /// 
        /// </summary>
        public AdaptiveRouterClient AdaptiveRouter { get; }

        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicPassThroughClient AnthropicPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicPassThrough2Client AnthropicPassThrough2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnthropicSkillsClient AnthropicSkills { get; }

        /// <summary>
        /// 
        /// </summary>
        public AssemblyAIEuPassThroughClient AssemblyAIEuPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public AssemblyAIPassThroughClient AssemblyAIPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsClient Assistants { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioClient Audio { get; }

        /// <summary>
        /// 
        /// </summary>
        public AuditLoggingClient AuditLogging { get; }

        /// <summary>
        /// 
        /// </summary>
        public AzureAiPassThroughClient AzureAiPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public AzurePassThroughClient AzurePassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public BatchClient Batch { get; }

        /// <summary>
        /// 
        /// </summary>
        public BedrockPassThroughClient BedrockPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaAgentsClient BetaAgents { get; }

        /// <summary>
        /// 
        /// </summary>
        public BetaMcpClient BetaMcp { get; }

        /// <summary>
        /// 
        /// </summary>
        public BudgetManagementClient BudgetManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public BudgetSpendTrackingClient BudgetSpendTracking { get; }

        /// <summary>
        /// 
        /// </summary>
        public CacheSettingsClient CacheSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public CachingClient Caching { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionsClient ChatCompletions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ClaudeCodeMarketplaceClient ClaudeCodeMarketplace { get; }

        /// <summary>
        /// 
        /// </summary>
        public CoherePassThroughClient CoherePassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public CompletionsClient Completions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ComplianceClient Compliance { get; }

        /// <summary>
        /// 
        /// </summary>
        public ContainersClient Containers { get; }

        /// <summary>
        /// 
        /// </summary>
        public CoordinationRedisSettingsClient CoordinationRedisSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public CostTrackingClient CostTracking { get; }

        /// <summary>
        /// 
        /// </summary>
        public CredentialManagementClient CredentialManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public CursorPassThroughClient CursorPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public CustomerManagementClient CustomerManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmailManagementClient EmailManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public EmbeddingsClient Embeddings { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvalsClient Evals { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentalClient Experimental { get; }

        /// <summary>
        /// 
        /// </summary>
        public FallbackManagementClient FallbackManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files { get; }

        /// <summary>
        /// 
        /// </summary>
        public FineTuningClient FineTuning { get; }

        /// <summary>
        /// 
        /// </summary>
        public GeminiAgentsClient GeminiAgents { get; }

        /// <summary>
        /// 
        /// </summary>
        public GoogleAiStudioPassThroughClient GoogleAiStudioPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public GoogleGenaiEndpointsClient GoogleGenaiEndpoints { get; }

        /// <summary>
        /// 
        /// </summary>
        public GuardrailsClient Guardrails { get; }

        /// <summary>
        /// 
        /// </summary>
        public HealthClient Health { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImagesClient Images { get; }

        /// <summary>
        /// 
        /// </summary>
        public InternalUserManagementClient InternalUserManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public JwtMappingsClient JwtMappings { get; }

        /// <summary>
        /// 
        /// </summary>
        public KeyManagementClient KeyManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public LangfusePassthroughClient LangfusePassthrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmUtilsClient LlmUtils { get; }

        /// <summary>
        /// 
        /// </summary>
        public LoggingCallbacksClient LoggingCallbacks { get; }

        /// <summary>
        /// 
        /// </summary>
        public McpRestClient McpRest { get; }

        /// <summary>
        /// 
        /// </summary>
        public MemoryManagementClient MemoryManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public MilvusPassThroughClient MilvusPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public MistralPassThroughClient MistralPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelManagementClient ModelManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModerationsClient Moderations { get; }

        /// <summary>
        /// 
        /// </summary>
        public OcrClient Ocr { get; }

        /// <summary>
        /// 
        /// </summary>
        public OpenAIPassThroughClient OpenAIPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationManagementClient OrganizationManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public PluginsClient Plugins { get; }

        /// <summary>
        /// 
        /// </summary>
        public PoliciesClient Policies { get; }

        /// <summary>
        /// 
        /// </summary>
        public PolicyEngineClient PolicyEngine { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectManagementClient ProjectManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public { get; }

        /// <summary>
        /// 
        /// </summary>
        public RagClient Rag { get; }

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClient Realtime { get; }

        /// <summary>
        /// 
        /// </summary>
        public RerankClient Rerank { get; }

        /// <summary>
        /// 
        /// </summary>
        public ResponsesClient Responses { get; }

        /// <summary>
        /// 
        /// </summary>
        public RouterSettingsClient RouterSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public RustControlPlaneClient RustControlPlane { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScimClient Scim { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// 
        /// </summary>
        public SearchToolsClient SearchTools { get; }

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings { get; }

        /// <summary>
        /// 
        /// </summary>
        public SsoSettingsClient SsoSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public TagManagementClient TagManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public TeamManagementClient TeamManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// 
        /// </summary>
        public UiSettingsClient UiSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public UiThemeSettingsClient UiThemeSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageAiClient UsageAi { get; }

        /// <summary>
        /// 
        /// </summary>
        public VectorStoreManagementClient VectorStoreManagement { get; }

        /// <summary>
        /// 
        /// </summary>
        public VectorStoresClient VectorStores { get; }

        /// <summary>
        /// 
        /// </summary>
        public VertexAiPassThroughClient VertexAiPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos { get; }

        /// <summary>
        /// 
        /// </summary>
        public VllmPassThroughClient VllmPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public WatsonxPassThroughClient WatsonxPassThrough { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebSocketClient WebSocket { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkflowManagementClient WorkflowManagement { get; }

    }
}