using WebApi.Dto;
using WebApi.Entities;

namespace WebApi.Services.Abstract
{
    public interface IAiService
    {
        Task<PromptResponse> GetPromptResponse(Prompt prompt);
    }
}
