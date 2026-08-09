using Microsoft.AspNetCore.Mvc;
using FaceitChecker.Clients;
using System.Threading.Tasks;

namespace FaceitChecker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly IFaceitApiClient _faceitApiClient;

        public PlayersController(IFaceitApiClient faceitApiClient)
        {
            _faceitApiClient = faceitApiClient;
        }

        
        [HttpGet]
        [Route("profile")]
        public async Task<IActionResult>  GetPlayerProfile(string name)
        {
            var response = await _faceitApiClient.RequestPlayerProfile(name);

            if (response == null) 
            {
                return NotFound();
            }
            
            return Ok(response);
        }

        [HttpGet]
        [Route("stats")]
        public async Task<IActionResult> GetPlayerStats(string player_id, string game)
        {
            var response = await _faceitApiClient.RequestPlayerStats(player_id, game);
            
            if (response == null) 
            {
                return NotFound();
            }
            return Ok(response);
        }



    }
}
