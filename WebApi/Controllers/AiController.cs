using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Entities;
using WebApi.Services.Abstract;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AiController : ControllerBase
    {
        private readonly IAiService _aiService;

        public AiController(IAiService aiService)
        {
            _aiService = aiService;
        }

        [HttpPost]
        [Route("OpenAi")]
        public async Task<IActionResult> GetPromptResponse([FromBody] Prompt prompt)
        {
            var res = await _aiService.GetPromptResponse(prompt);

            return Ok(res);
        }
    }
}
