using Microsoft.AspNetCore.Mvc;

namespace webhook_csharp1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger<WebhookController> _logger;

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "webhook")]
        public IActionResult Post([FromBody] WebhookPayload payload)
        {
            _logger.LogInformation($"Datos recibidos del webhook: {payload.Data}");

            return Ok(new
            {
                message = "Webhook recibido exitosamente",
                data = payload
            });
        }

    }
}
