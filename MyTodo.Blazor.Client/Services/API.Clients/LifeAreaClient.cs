using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class LifeAreaClient(HttpClient http)
    {
        public async Task<List<LifeArea>> GetLifeAreasAsync() =>
        (await http.GetFromJsonAsync<LifeAreaResponse>("lifeareas")).LifeAreas ?? [];

        public async Task<LifeArea> GetLifeAreaAsync(int id)
        {
            return (await http.GetFromJsonAsync<LifeAreaDetailResponse>($"lifeareas/detail/{id}")).LifeArea;
        }

        public async Task UpdatePlanAsync(int id, string plan)
        {
            await http.PatchAsJsonAsync($"/lifeareas/plan/{id}", new { Plan = plan });
        }

        public async Task UpdateVisionAsync(int id, string vision)
        {
            await http.PatchAsJsonAsync($"/lifeareas/vision/{id}", new { Vision = vision });
        }
    }
}
