
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum CallTypes
    {
        /// <summary>
        /// 
        /// </summary>
        Arealtime,
        /// <summary>
        /// 
        /// </summary>
        AresponsesWebsocket,
        /// <summary>
        /// 
        /// </summary>
        AAddMessage,
        /// <summary>
        /// 
        /// </summary>
        AanthropicMessages,
        /// <summary>
        /// 
        /// </summary>
        AcancelBatch,
        /// <summary>
        /// 
        /// </summary>
        AcancelFineTuningJob,
        /// <summary>
        /// 
        /// </summary>
        AcodeInterpreterTool,
        /// <summary>
        /// 
        /// </summary>
        Acompletion,
        /// <summary>
        /// 
        /// </summary>
        AcreateAssistants,
        /// <summary>
        /// 
        /// </summary>
        AcreateBatch,
        /// <summary>
        /// 
        /// </summary>
        AcreateContainer,
        /// <summary>
        /// 
        /// </summary>
        AcreateFile,
        /// <summary>
        /// 
        /// </summary>
        AcreateFineTuningJob,
        /// <summary>
        /// 
        /// </summary>
        AcreateSandbox,
        /// <summary>
        /// 
        /// </summary>
        AcreateSkill,
        /// <summary>
        /// 
        /// </summary>
        AcreateThread,
        /// <summary>
        /// 
        /// </summary>
        AcreateVideo,
        /// <summary>
        /// 
        /// </summary>
        AddMessage,
        /// <summary>
        /// 
        /// </summary>
        AdeleteAssistant,
        /// <summary>
        /// 
        /// </summary>
        AdeleteContainer,
        /// <summary>
        /// 
        /// </summary>
        AdeleteSandbox,
        /// <summary>
        /// 
        /// </summary>
        Aembedding,
        /// <summary>
        /// 
        /// </summary>
        AfileContent,
        /// <summary>
        /// 
        /// </summary>
        AfileDelete,
        /// <summary>
        /// 
        /// </summary>
        AfileList,
        /// <summary>
        /// 
        /// </summary>
        AfileRetrieve,
        /// <summary>
        /// 
        /// </summary>
        AgenerateContent,
        /// <summary>
        /// 
        /// </summary>
        AgenerateContentStream,
        /// <summary>
        /// 
        /// </summary>
        AgetAssistants,
        /// <summary>
        /// 
        /// </summary>
        AgetMessages,
        /// <summary>
        /// 
        /// </summary>
        AgetThread,
        /// <summary>
        /// 
        /// </summary>
        AimageEdit,
        /// <summary>
        /// 
        /// </summary>
        AimageGeneration,
        /// <summary>
        /// 
        /// </summary>
        Aingest,
        /// <summary>
        /// 
        /// </summary>
        AlistContainerFiles,
        /// <summary>
        /// 
        /// </summary>
        AlistContainers,
        /// <summary>
        /// 
        /// </summary>
        AlistFineTuningJobs,
        /// <summary>
        /// 
        /// </summary>
        AlistInputItems,
        /// <summary>
        /// 
        /// </summary>
        AllmPassthroughRoute,
        /// <summary>
        /// 
        /// </summary>
        Amoderation,
        /// <summary>
        /// 
        /// </summary>
        AnthropicMessages,
        /// <summary>
        /// 
        /// </summary>
        Aocr,
        /// <summary>
        /// 
        /// </summary>
        Aquery,
        /// <summary>
        /// 
        /// </summary>
        Arerank,
        /// <summary>
        /// 
        /// </summary>
        Aresponses,
        /// <summary>
        /// 
        /// </summary>
        AretrieveBatch,
        /// <summary>
        /// 
        /// </summary>
        AretrieveContainer,
        /// <summary>
        /// 
        /// </summary>
        AretrieveFineTuningJob,
        /// <summary>
        /// 
        /// </summary>
        ArunCode,
        /// <summary>
        /// 
        /// </summary>
        ArunThread,
        /// <summary>
        /// 
        /// </summary>
        ArunThreadStream,
        /// <summary>
        /// 
        /// </summary>
        Asearch,
        /// <summary>
        /// 
        /// </summary>
        AsendMessage,
        /// <summary>
        /// 
        /// </summary>
        Aspeech,
        /// <summary>
        /// 
        /// </summary>
        AtextCompletion,
        /// <summary>
        /// 
        /// </summary>
        Atranscription,
        /// <summary>
        /// 
        /// </summary>
        AuploadContainerFile,
        /// <summary>
        /// 
        /// </summary>
        AvectorStoreCreate,
        /// <summary>
        /// 
        /// </summary>
        AvectorStoreFileContent,
        /// <summary>
        /// 
        /// </summary>
        AvectorStoreFileCreate,
        /// <summary>
        /// 
        /// </summary>
        AvectorStoreFileDelete,
        /// <summary>
        /// 
        /// </summary>
        AvectorStoreFileList,
        /// <summary>
        /// 
        /// </summary>
        AvectorStoreFileRetrieve,
        /// <summary>
        /// 
        /// </summary>
        AvectorStoreFileUpdate,
        /// <summary>
        /// 
        /// </summary>
        AvectorStoreSearch,
        /// <summary>
        /// 
        /// </summary>
        AvideoContent,
        /// <summary>
        /// 
        /// </summary>
        AvideoCreateCharacter,
        /// <summary>
        /// 
        /// </summary>
        AvideoDelete,
        /// <summary>
        /// 
        /// </summary>
        AvideoEdit,
        /// <summary>
        /// 
        /// </summary>
        AvideoExtension,
        /// <summary>
        /// 
        /// </summary>
        AvideoGetCharacter,
        /// <summary>
        /// 
        /// </summary>
        AvideoList,
        /// <summary>
        /// 
        /// </summary>
        AvideoRemix,
        /// <summary>
        /// 
        /// </summary>
        AvideoRetrieve,
        /// <summary>
        /// 
        /// </summary>
        AvideoRetrieveJob,
        /// <summary>
        /// 
        /// </summary>
        CallMcpTool,
        /// <summary>
        /// 
        /// </summary>
        CancelBatch,
        /// <summary>
        /// 
        /// </summary>
        CancelFineTuningJob,
        /// <summary>
        /// 
        /// </summary>
        CodeInterpreterTool,
        /// <summary>
        /// 
        /// </summary>
        Completion,
        /// <summary>
        /// 
        /// </summary>
        CreateAssistants,
        /// <summary>
        /// 
        /// </summary>
        CreateBatch,
        /// <summary>
        /// 
        /// </summary>
        CreateContainer,
        /// <summary>
        /// 
        /// </summary>
        CreateFile,
        /// <summary>
        /// 
        /// </summary>
        CreateFineTuningJob,
        /// <summary>
        /// 
        /// </summary>
        CreateSandbox,
        /// <summary>
        /// 
        /// </summary>
        CreateThread,
        /// <summary>
        /// 
        /// </summary>
        CreateVideo,
        /// <summary>
        /// 
        /// </summary>
        DeleteAssistant,
        /// <summary>
        /// 
        /// </summary>
        DeleteContainer,
        /// <summary>
        /// 
        /// </summary>
        DeleteSandbox,
        /// <summary>
        /// 
        /// </summary>
        Embedding,
        /// <summary>
        /// 
        /// </summary>
        FileContent,
        /// <summary>
        /// 
        /// </summary>
        FileDelete,
        /// <summary>
        /// 
        /// </summary>
        FileList,
        /// <summary>
        /// 
        /// </summary>
        FileRetrieve,
        /// <summary>
        /// 
        /// </summary>
        GenerateContent,
        /// <summary>
        /// 
        /// </summary>
        GenerateContentStream,
        /// <summary>
        /// 
        /// </summary>
        GetAssistants,
        /// <summary>
        /// 
        /// </summary>
        GetMessages,
        /// <summary>
        /// 
        /// </summary>
        GetThread,
        /// <summary>
        /// 
        /// </summary>
        ImageEdit,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        Ingest,
        /// <summary>
        /// 
        /// </summary>
        ListContainerFiles,
        /// <summary>
        /// 
        /// </summary>
        ListContainers,
        /// <summary>
        /// 
        /// </summary>
        ListFineTuningJobs,
        /// <summary>
        /// 
        /// </summary>
        ListMcpTools,
        /// <summary>
        /// 
        /// </summary>
        LlmPassthroughRoute,
        /// <summary>
        /// 
        /// </summary>
        Moderation,
        /// <summary>
        /// 
        /// </summary>
        Ocr,
        /// <summary>
        /// 
        /// </summary>
        PassThroughEndpoint,
        /// <summary>
        /// 
        /// </summary>
        Query,
        /// <summary>
        /// 
        /// </summary>
        Rerank,
        /// <summary>
        /// 
        /// </summary>
        Responses,
        /// <summary>
        /// 
        /// </summary>
        RetrieveBatch,
        /// <summary>
        /// 
        /// </summary>
        RetrieveContainer,
        /// <summary>
        /// 
        /// </summary>
        RetrieveFineTuningJob,
        /// <summary>
        /// 
        /// </summary>
        RunCode,
        /// <summary>
        /// 
        /// </summary>
        RunThread,
        /// <summary>
        /// 
        /// </summary>
        RunThreadStream,
        /// <summary>
        /// 
        /// </summary>
        Search,
        /// <summary>
        /// 
        /// </summary>
        SendMessage,
        /// <summary>
        /// 
        /// </summary>
        Speech,
        /// <summary>
        /// 
        /// </summary>
        TextCompletion,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
        /// <summary>
        /// 
        /// </summary>
        UploadContainerFile,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreCreate,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreFileContent,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreFileCreate,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreFileDelete,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreFileList,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreFileRetrieve,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreFileUpdate,
        /// <summary>
        /// 
        /// </summary>
        VectorStoreSearch,
        /// <summary>
        /// 
        /// </summary>
        VideoContent,
        /// <summary>
        /// 
        /// </summary>
        VideoCreateCharacter,
        /// <summary>
        /// 
        /// </summary>
        VideoDelete,
        /// <summary>
        /// 
        /// </summary>
        VideoEdit,
        /// <summary>
        /// 
        /// </summary>
        VideoExtension,
        /// <summary>
        /// 
        /// </summary>
        VideoGetCharacter,
        /// <summary>
        /// 
        /// </summary>
        VideoList,
        /// <summary>
        /// 
        /// </summary>
        VideoRemix,
        /// <summary>
        /// 
        /// </summary>
        VideoRetrieve,
        /// <summary>
        /// 
        /// </summary>
        VideoRetrieveJob,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallTypesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallTypes value)
        {
            return value switch
            {
                CallTypes.Arealtime => "_arealtime",
                CallTypes.AresponsesWebsocket => "_aresponses_websocket",
                CallTypes.AAddMessage => "a_add_message",
                CallTypes.AanthropicMessages => "aanthropic_messages",
                CallTypes.AcancelBatch => "acancel_batch",
                CallTypes.AcancelFineTuningJob => "acancel_fine_tuning_job",
                CallTypes.AcodeInterpreterTool => "acode_interpreter_tool",
                CallTypes.Acompletion => "acompletion",
                CallTypes.AcreateAssistants => "acreate_assistants",
                CallTypes.AcreateBatch => "acreate_batch",
                CallTypes.AcreateContainer => "acreate_container",
                CallTypes.AcreateFile => "acreate_file",
                CallTypes.AcreateFineTuningJob => "acreate_fine_tuning_job",
                CallTypes.AcreateSandbox => "acreate_sandbox",
                CallTypes.AcreateSkill => "acreate_skill",
                CallTypes.AcreateThread => "acreate_thread",
                CallTypes.AcreateVideo => "acreate_video",
                CallTypes.AddMessage => "add_message",
                CallTypes.AdeleteAssistant => "adelete_assistant",
                CallTypes.AdeleteContainer => "adelete_container",
                CallTypes.AdeleteSandbox => "adelete_sandbox",
                CallTypes.Aembedding => "aembedding",
                CallTypes.AfileContent => "afile_content",
                CallTypes.AfileDelete => "afile_delete",
                CallTypes.AfileList => "afile_list",
                CallTypes.AfileRetrieve => "afile_retrieve",
                CallTypes.AgenerateContent => "agenerate_content",
                CallTypes.AgenerateContentStream => "agenerate_content_stream",
                CallTypes.AgetAssistants => "aget_assistants",
                CallTypes.AgetMessages => "aget_messages",
                CallTypes.AgetThread => "aget_thread",
                CallTypes.AimageEdit => "aimage_edit",
                CallTypes.AimageGeneration => "aimage_generation",
                CallTypes.Aingest => "aingest",
                CallTypes.AlistContainerFiles => "alist_container_files",
                CallTypes.AlistContainers => "alist_containers",
                CallTypes.AlistFineTuningJobs => "alist_fine_tuning_jobs",
                CallTypes.AlistInputItems => "alist_input_items",
                CallTypes.AllmPassthroughRoute => "allm_passthrough_route",
                CallTypes.Amoderation => "amoderation",
                CallTypes.AnthropicMessages => "anthropic_messages",
                CallTypes.Aocr => "aocr",
                CallTypes.Aquery => "aquery",
                CallTypes.Arerank => "arerank",
                CallTypes.Aresponses => "aresponses",
                CallTypes.AretrieveBatch => "aretrieve_batch",
                CallTypes.AretrieveContainer => "aretrieve_container",
                CallTypes.AretrieveFineTuningJob => "aretrieve_fine_tuning_job",
                CallTypes.ArunCode => "arun_code",
                CallTypes.ArunThread => "arun_thread",
                CallTypes.ArunThreadStream => "arun_thread_stream",
                CallTypes.Asearch => "asearch",
                CallTypes.AsendMessage => "asend_message",
                CallTypes.Aspeech => "aspeech",
                CallTypes.AtextCompletion => "atext_completion",
                CallTypes.Atranscription => "atranscription",
                CallTypes.AuploadContainerFile => "aupload_container_file",
                CallTypes.AvectorStoreCreate => "avector_store_create",
                CallTypes.AvectorStoreFileContent => "avector_store_file_content",
                CallTypes.AvectorStoreFileCreate => "avector_store_file_create",
                CallTypes.AvectorStoreFileDelete => "avector_store_file_delete",
                CallTypes.AvectorStoreFileList => "avector_store_file_list",
                CallTypes.AvectorStoreFileRetrieve => "avector_store_file_retrieve",
                CallTypes.AvectorStoreFileUpdate => "avector_store_file_update",
                CallTypes.AvectorStoreSearch => "avector_store_search",
                CallTypes.AvideoContent => "avideo_content",
                CallTypes.AvideoCreateCharacter => "avideo_create_character",
                CallTypes.AvideoDelete => "avideo_delete",
                CallTypes.AvideoEdit => "avideo_edit",
                CallTypes.AvideoExtension => "avideo_extension",
                CallTypes.AvideoGetCharacter => "avideo_get_character",
                CallTypes.AvideoList => "avideo_list",
                CallTypes.AvideoRemix => "avideo_remix",
                CallTypes.AvideoRetrieve => "avideo_retrieve",
                CallTypes.AvideoRetrieveJob => "avideo_retrieve_job",
                CallTypes.CallMcpTool => "call_mcp_tool",
                CallTypes.CancelBatch => "cancel_batch",
                CallTypes.CancelFineTuningJob => "cancel_fine_tuning_job",
                CallTypes.CodeInterpreterTool => "code_interpreter_tool",
                CallTypes.Completion => "completion",
                CallTypes.CreateAssistants => "create_assistants",
                CallTypes.CreateBatch => "create_batch",
                CallTypes.CreateContainer => "create_container",
                CallTypes.CreateFile => "create_file",
                CallTypes.CreateFineTuningJob => "create_fine_tuning_job",
                CallTypes.CreateSandbox => "create_sandbox",
                CallTypes.CreateThread => "create_thread",
                CallTypes.CreateVideo => "create_video",
                CallTypes.DeleteAssistant => "delete_assistant",
                CallTypes.DeleteContainer => "delete_container",
                CallTypes.DeleteSandbox => "delete_sandbox",
                CallTypes.Embedding => "embedding",
                CallTypes.FileContent => "file_content",
                CallTypes.FileDelete => "file_delete",
                CallTypes.FileList => "file_list",
                CallTypes.FileRetrieve => "file_retrieve",
                CallTypes.GenerateContent => "generate_content",
                CallTypes.GenerateContentStream => "generate_content_stream",
                CallTypes.GetAssistants => "get_assistants",
                CallTypes.GetMessages => "get_messages",
                CallTypes.GetThread => "get_thread",
                CallTypes.ImageEdit => "image_edit",
                CallTypes.ImageGeneration => "image_generation",
                CallTypes.Ingest => "ingest",
                CallTypes.ListContainerFiles => "list_container_files",
                CallTypes.ListContainers => "list_containers",
                CallTypes.ListFineTuningJobs => "list_fine_tuning_jobs",
                CallTypes.ListMcpTools => "list_mcp_tools",
                CallTypes.LlmPassthroughRoute => "llm_passthrough_route",
                CallTypes.Moderation => "moderation",
                CallTypes.Ocr => "ocr",
                CallTypes.PassThroughEndpoint => "pass_through_endpoint",
                CallTypes.Query => "query",
                CallTypes.Rerank => "rerank",
                CallTypes.Responses => "responses",
                CallTypes.RetrieveBatch => "retrieve_batch",
                CallTypes.RetrieveContainer => "retrieve_container",
                CallTypes.RetrieveFineTuningJob => "retrieve_fine_tuning_job",
                CallTypes.RunCode => "run_code",
                CallTypes.RunThread => "run_thread",
                CallTypes.RunThreadStream => "run_thread_stream",
                CallTypes.Search => "search",
                CallTypes.SendMessage => "send_message",
                CallTypes.Speech => "speech",
                CallTypes.TextCompletion => "text_completion",
                CallTypes.Transcription => "transcription",
                CallTypes.UploadContainerFile => "upload_container_file",
                CallTypes.VectorStoreCreate => "vector_store_create",
                CallTypes.VectorStoreFileContent => "vector_store_file_content",
                CallTypes.VectorStoreFileCreate => "vector_store_file_create",
                CallTypes.VectorStoreFileDelete => "vector_store_file_delete",
                CallTypes.VectorStoreFileList => "vector_store_file_list",
                CallTypes.VectorStoreFileRetrieve => "vector_store_file_retrieve",
                CallTypes.VectorStoreFileUpdate => "vector_store_file_update",
                CallTypes.VectorStoreSearch => "vector_store_search",
                CallTypes.VideoContent => "video_content",
                CallTypes.VideoCreateCharacter => "video_create_character",
                CallTypes.VideoDelete => "video_delete",
                CallTypes.VideoEdit => "video_edit",
                CallTypes.VideoExtension => "video_extension",
                CallTypes.VideoGetCharacter => "video_get_character",
                CallTypes.VideoList => "video_list",
                CallTypes.VideoRemix => "video_remix",
                CallTypes.VideoRetrieve => "video_retrieve",
                CallTypes.VideoRetrieveJob => "video_retrieve_job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallTypes? ToEnum(string value)
        {
            return value switch
            {
                "_arealtime" => CallTypes.Arealtime,
                "_aresponses_websocket" => CallTypes.AresponsesWebsocket,
                "a_add_message" => CallTypes.AAddMessage,
                "aanthropic_messages" => CallTypes.AanthropicMessages,
                "acancel_batch" => CallTypes.AcancelBatch,
                "acancel_fine_tuning_job" => CallTypes.AcancelFineTuningJob,
                "acode_interpreter_tool" => CallTypes.AcodeInterpreterTool,
                "acompletion" => CallTypes.Acompletion,
                "acreate_assistants" => CallTypes.AcreateAssistants,
                "acreate_batch" => CallTypes.AcreateBatch,
                "acreate_container" => CallTypes.AcreateContainer,
                "acreate_file" => CallTypes.AcreateFile,
                "acreate_fine_tuning_job" => CallTypes.AcreateFineTuningJob,
                "acreate_sandbox" => CallTypes.AcreateSandbox,
                "acreate_skill" => CallTypes.AcreateSkill,
                "acreate_thread" => CallTypes.AcreateThread,
                "acreate_video" => CallTypes.AcreateVideo,
                "add_message" => CallTypes.AddMessage,
                "adelete_assistant" => CallTypes.AdeleteAssistant,
                "adelete_container" => CallTypes.AdeleteContainer,
                "adelete_sandbox" => CallTypes.AdeleteSandbox,
                "aembedding" => CallTypes.Aembedding,
                "afile_content" => CallTypes.AfileContent,
                "afile_delete" => CallTypes.AfileDelete,
                "afile_list" => CallTypes.AfileList,
                "afile_retrieve" => CallTypes.AfileRetrieve,
                "agenerate_content" => CallTypes.AgenerateContent,
                "agenerate_content_stream" => CallTypes.AgenerateContentStream,
                "aget_assistants" => CallTypes.AgetAssistants,
                "aget_messages" => CallTypes.AgetMessages,
                "aget_thread" => CallTypes.AgetThread,
                "aimage_edit" => CallTypes.AimageEdit,
                "aimage_generation" => CallTypes.AimageGeneration,
                "aingest" => CallTypes.Aingest,
                "alist_container_files" => CallTypes.AlistContainerFiles,
                "alist_containers" => CallTypes.AlistContainers,
                "alist_fine_tuning_jobs" => CallTypes.AlistFineTuningJobs,
                "alist_input_items" => CallTypes.AlistInputItems,
                "allm_passthrough_route" => CallTypes.AllmPassthroughRoute,
                "amoderation" => CallTypes.Amoderation,
                "anthropic_messages" => CallTypes.AnthropicMessages,
                "aocr" => CallTypes.Aocr,
                "aquery" => CallTypes.Aquery,
                "arerank" => CallTypes.Arerank,
                "aresponses" => CallTypes.Aresponses,
                "aretrieve_batch" => CallTypes.AretrieveBatch,
                "aretrieve_container" => CallTypes.AretrieveContainer,
                "aretrieve_fine_tuning_job" => CallTypes.AretrieveFineTuningJob,
                "arun_code" => CallTypes.ArunCode,
                "arun_thread" => CallTypes.ArunThread,
                "arun_thread_stream" => CallTypes.ArunThreadStream,
                "asearch" => CallTypes.Asearch,
                "asend_message" => CallTypes.AsendMessage,
                "aspeech" => CallTypes.Aspeech,
                "atext_completion" => CallTypes.AtextCompletion,
                "atranscription" => CallTypes.Atranscription,
                "aupload_container_file" => CallTypes.AuploadContainerFile,
                "avector_store_create" => CallTypes.AvectorStoreCreate,
                "avector_store_file_content" => CallTypes.AvectorStoreFileContent,
                "avector_store_file_create" => CallTypes.AvectorStoreFileCreate,
                "avector_store_file_delete" => CallTypes.AvectorStoreFileDelete,
                "avector_store_file_list" => CallTypes.AvectorStoreFileList,
                "avector_store_file_retrieve" => CallTypes.AvectorStoreFileRetrieve,
                "avector_store_file_update" => CallTypes.AvectorStoreFileUpdate,
                "avector_store_search" => CallTypes.AvectorStoreSearch,
                "avideo_content" => CallTypes.AvideoContent,
                "avideo_create_character" => CallTypes.AvideoCreateCharacter,
                "avideo_delete" => CallTypes.AvideoDelete,
                "avideo_edit" => CallTypes.AvideoEdit,
                "avideo_extension" => CallTypes.AvideoExtension,
                "avideo_get_character" => CallTypes.AvideoGetCharacter,
                "avideo_list" => CallTypes.AvideoList,
                "avideo_remix" => CallTypes.AvideoRemix,
                "avideo_retrieve" => CallTypes.AvideoRetrieve,
                "avideo_retrieve_job" => CallTypes.AvideoRetrieveJob,
                "call_mcp_tool" => CallTypes.CallMcpTool,
                "cancel_batch" => CallTypes.CancelBatch,
                "cancel_fine_tuning_job" => CallTypes.CancelFineTuningJob,
                "code_interpreter_tool" => CallTypes.CodeInterpreterTool,
                "completion" => CallTypes.Completion,
                "create_assistants" => CallTypes.CreateAssistants,
                "create_batch" => CallTypes.CreateBatch,
                "create_container" => CallTypes.CreateContainer,
                "create_file" => CallTypes.CreateFile,
                "create_fine_tuning_job" => CallTypes.CreateFineTuningJob,
                "create_sandbox" => CallTypes.CreateSandbox,
                "create_thread" => CallTypes.CreateThread,
                "create_video" => CallTypes.CreateVideo,
                "delete_assistant" => CallTypes.DeleteAssistant,
                "delete_container" => CallTypes.DeleteContainer,
                "delete_sandbox" => CallTypes.DeleteSandbox,
                "embedding" => CallTypes.Embedding,
                "file_content" => CallTypes.FileContent,
                "file_delete" => CallTypes.FileDelete,
                "file_list" => CallTypes.FileList,
                "file_retrieve" => CallTypes.FileRetrieve,
                "generate_content" => CallTypes.GenerateContent,
                "generate_content_stream" => CallTypes.GenerateContentStream,
                "get_assistants" => CallTypes.GetAssistants,
                "get_messages" => CallTypes.GetMessages,
                "get_thread" => CallTypes.GetThread,
                "image_edit" => CallTypes.ImageEdit,
                "image_generation" => CallTypes.ImageGeneration,
                "ingest" => CallTypes.Ingest,
                "list_container_files" => CallTypes.ListContainerFiles,
                "list_containers" => CallTypes.ListContainers,
                "list_fine_tuning_jobs" => CallTypes.ListFineTuningJobs,
                "list_mcp_tools" => CallTypes.ListMcpTools,
                "llm_passthrough_route" => CallTypes.LlmPassthroughRoute,
                "moderation" => CallTypes.Moderation,
                "ocr" => CallTypes.Ocr,
                "pass_through_endpoint" => CallTypes.PassThroughEndpoint,
                "query" => CallTypes.Query,
                "rerank" => CallTypes.Rerank,
                "responses" => CallTypes.Responses,
                "retrieve_batch" => CallTypes.RetrieveBatch,
                "retrieve_container" => CallTypes.RetrieveContainer,
                "retrieve_fine_tuning_job" => CallTypes.RetrieveFineTuningJob,
                "run_code" => CallTypes.RunCode,
                "run_thread" => CallTypes.RunThread,
                "run_thread_stream" => CallTypes.RunThreadStream,
                "search" => CallTypes.Search,
                "send_message" => CallTypes.SendMessage,
                "speech" => CallTypes.Speech,
                "text_completion" => CallTypes.TextCompletion,
                "transcription" => CallTypes.Transcription,
                "upload_container_file" => CallTypes.UploadContainerFile,
                "vector_store_create" => CallTypes.VectorStoreCreate,
                "vector_store_file_content" => CallTypes.VectorStoreFileContent,
                "vector_store_file_create" => CallTypes.VectorStoreFileCreate,
                "vector_store_file_delete" => CallTypes.VectorStoreFileDelete,
                "vector_store_file_list" => CallTypes.VectorStoreFileList,
                "vector_store_file_retrieve" => CallTypes.VectorStoreFileRetrieve,
                "vector_store_file_update" => CallTypes.VectorStoreFileUpdate,
                "vector_store_search" => CallTypes.VectorStoreSearch,
                "video_content" => CallTypes.VideoContent,
                "video_create_character" => CallTypes.VideoCreateCharacter,
                "video_delete" => CallTypes.VideoDelete,
                "video_edit" => CallTypes.VideoEdit,
                "video_extension" => CallTypes.VideoExtension,
                "video_get_character" => CallTypes.VideoGetCharacter,
                "video_list" => CallTypes.VideoList,
                "video_remix" => CallTypes.VideoRemix,
                "video_retrieve" => CallTypes.VideoRetrieve,
                "video_retrieve_job" => CallTypes.VideoRetrieveJob,
                _ => null,
            };
        }
    }
}