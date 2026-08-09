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
        var response = await httpClient.GetAsync($"https://open.faceit.com/data/v4/players?nickname={Name}");
        if (response.IsSuccessStatusCode)
        { return await response.Content.ReadFromJsonAsync<Player>(); }

        return null;
    }

    public async Task<Stats?> RequestPlayerStats(string PlayerId, string Game)
    {
        var response = await httpClient.GetAsync($"https://open.faceit.com/data/v4/players/{PlayerId}/games/{Game}/stats");
        if (response.IsSuccessStatusCode) 
        {
            return await response.Content.ReadFromJsonAsync<Stats>();    
        }
        
        return null;
    }
}
