using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels.ResponseModels;
using OpenAI.GPT3.ObjectModels.SharedModels;
using WebApi.Dto;
using WebApi.Entities;
using WebApi.Services.Abstract;

namespace WebApi.Services.Concrete
{
    public class AiService : IAiService
    {
        readonly IOpenAIService _openAiService;

        public AiService(IOpenAIService openAiService)
        {
            _openAiService = openAiService;
        }

        public async Task<PromptResponse> GetPromptResponse(Prompt prompt)
        {

            string request = prompt.PromptRequest;

        CompletionCreateResponse result = await  _openAiService.Completions.CreateCompletion(new CompletionCreateRequest()
            {
                MaxTokens = 10,
                Prompt = request

            }, Models.TextDavinciV3);
            PromptResponse responseResult = new PromptResponse()
            {
                Response = result.Choices[0].Text
            };

            return responseResult;
        }
    }
}
