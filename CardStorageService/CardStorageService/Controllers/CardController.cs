using Microsoft.AspNetCore.Mvc;

namespace CardStorageService.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class CardController:ControllerBase
    {
        private readonly ILogger<CardController> _logger;
        public CardController ( ILogger<CardController> logger )
        {
            _logger=logger;
        }
    }
}
