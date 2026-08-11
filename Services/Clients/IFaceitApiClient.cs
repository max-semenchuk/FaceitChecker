using System.Threading.Tasks;
using FaceitChecker.Models.Domain;
using Services.Models.Domain;

namespace FaceitChecker.Clients
{
    public interface IFaceitApiClient
    {
        public Task<Player> RequestPlayerProfile(string name);

        public Task<Stats> RequestPlayerStats(string PlayerId, string Game);
    }
}
