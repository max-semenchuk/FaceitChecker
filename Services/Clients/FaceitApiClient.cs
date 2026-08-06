using FaceitChecker.Models;
using FaceitChecker.Models.Domain;
using Microsoft.Extensions.Configuration;
using Services.Models.Domain;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FaceitChecker.Clients;

public class FaceitApiClient : IFaceitApiClient
{
    private readonly HttpClient httpClient = new();

    public FaceitApiClient(IConfiguration configuration)
    {
        httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {configuration["FaceitApiKey"]}");
    }

    public async Task<Player?> RequestPlayerProfile(string Name)
    {
        return await httpClient.GetFromJsonAsync<Player?>($"https://open.faceit.com/data/v4/players?nickname={Name}");
    }

    public async Task<Stats?> RequestPlayerStats(string PlayerId, string Game)
    {
        return await httpClient.GetFromJsonAsync<Stats?>($"https://open.faceit.com/data/v4/players/{PlayerId}/games/{Game}/stats");
    }
}
