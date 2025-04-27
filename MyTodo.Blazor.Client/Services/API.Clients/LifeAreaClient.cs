using Microsoft.Extensions.Options;
using MyTodo.Blazor.Client.Configurations;
using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class LifeAreaClient(HttpClient http, IOptions<ApiServicePrefix> servicePrefixes):BaseClient(servicePrefixes.Value.LifeArea)
    {
        public async Task<List<LifeArea>> GetLifeAreasAsync()
        {
            try
            {
                var response = await http.GetFromJsonAsync<LifeAreaResponse>(GetUrl("/lifeareas"));

                return response.LifeAreas ?? [];
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public async Task<LifeArea> GetLifeAreaAsync(int id)
        {
            return (await http.GetFromJsonAsync<LifeAreaDetailResponse>(GetUrl($"/lifeareas/detail/{id}"))).LifeArea;
        }

        public async Task UpdatePlanAsync(int id, string plan)
        {
            await http.PatchAsJsonAsync(GetUrl($"/lifeareas/plan/{id}"), new { Plan = plan });
        }

        public async Task UpdateVisionAsync(int id, string vision)
        {
            await http.PatchAsJsonAsync(GetUrl($"/lifeareas/vision/{id}"), new { Vision = vision });
        }
    }
}
