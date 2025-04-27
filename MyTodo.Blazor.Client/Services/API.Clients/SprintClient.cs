using Microsoft.Extensions.Options;
using MyTodo.Blazor.Client.Configurations;
using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class SprintClient(HttpClient http, IOptions<ApiServicePrefix> servicePrefixes) : BaseClient(servicePrefixes.Value.Sprint)
    {
        public async Task<List<Sprint>> GetManyAsync()
        {
            return (await http.GetFromJsonAsync<SprintsResponse>(GetUrl($"/sprints"))).Sprints.ToList();
        }

        public async Task<Sprint> GetAsync(int id)
        {
            return (await http.GetFromJsonAsync<SprintResponse>(GetUrl($"/sprints/detail/{id}"))).Sprint;
        }

        public async Task CreateAsync(string text, string startDate, string endDate)
        {
            await http.PostAsJsonAsync(GetUrl($"/sprints"), new { text, startDate, endDate });
        }


        public async Task UpdateAsync(int id, string text, string startDate, string endDate)
        {
            await http.PutAsJsonAsync(GetUrl($"/sprints"), new { id, text, startDate, endDate });
        }

        public async Task ToggleComplete(int id, bool completed)
        {
            await http.PatchAsJsonAsync(GetUrl($"/sprints/complete/{id}"), new { Completed = completed });
        }

        public async Task DeleteAsync(int id)
        {
            await http.DeleteAsync(GetUrl($"/sprints/{id}"));
        }



    }
}
