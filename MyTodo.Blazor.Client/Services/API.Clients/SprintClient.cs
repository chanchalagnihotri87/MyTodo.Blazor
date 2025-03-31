using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class SprintClient(HttpClient http)
    {
        public async Task<List<Sprint>> GetManyAsync()
        {
            return (await http.GetFromJsonAsync<SprintsResponse>($"/sprints")).Sprints.ToList();
        }

        public async Task<Sprint> GetAsync(int id)
        {
            return (await http.GetFromJsonAsync<SprintResponse>($"/sprints/detail/{id}")).Sprint;
        }

        public async Task CreateAsync(string text, string startDate, string endDate)
        {
            await http.PostAsJsonAsync($"/sprints", new { text, startDate, endDate });
        }


        public async Task UpdateAsync(int id, string text, string startDate, string endDate)
        {
            await http.PutAsJsonAsync($"/sprints", new { id, text, startDate, endDate });
        }

        public async Task ToggleComplete(int id, bool completed)
        {
            await http.PatchAsJsonAsync($"/sprints/complete/{id}", new { Completed = completed });
        }

        public async Task DeleteAsync(int id)
        {
            await http.DeleteAsync($"/sprints/{id}");
        }

    }
}
