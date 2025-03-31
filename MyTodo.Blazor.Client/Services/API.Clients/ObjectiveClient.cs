using Microsoft.VisualBasic;
using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class ObjectiveClient(HttpClient http) : IMyTodoHttpClient<Objective>
    {
        public async Task<List<Objective>> GetManyAsync(int goalId)
        {
            return (await http.GetFromJsonAsync<ObjectivesResponse>($"/objectives/{goalId}")).Objectives.ToList();
        }

        public async Task<Objective> GetAsync(int id)
        {
            return (await http.GetFromJsonAsync<ObjectiveResponse>($"/objectives/detail/{id}")).Objective;
        }


        public async Task CreateAsync(string text, int goalId)
        {
            await http.PostAsJsonAsync($"/objectives", new { Objective = new { Text = text, GoalId = goalId } });
        }

        public async Task UpdateTextAsync(int id, string text)
        {
            await http.PatchAsJsonAsync($"/objectives/text/{id}", new { Text = text });
        }

        public async Task UpdatePlanAsync(int id, string plan)
        {
            await http.PatchAsJsonAsync($"/objectives/plan/{id}", new { Plan = plan });
        }

        public async Task ToggleComplete(int id, bool completed)
        {
            await http.PatchAsJsonAsync($"/objectives/complete/{id}", new { Completed = completed });
        }

        public async Task ToggleTwentyPercent(int id, bool twentyPercent)
        {
            await http.PatchAsJsonAsync($"/objectives/twentypercent/{id}", new { TwentyPercent = twentyPercent });
        }

        public async Task DeleteAsync(int id)
        {
            await http.DeleteAsync($"/objectives/{id}");
        }

        public async Task MoveAsync(int id, int index, int goalId)
        {
            await http.PatchAsJsonAsync($"/objectives/move/{id}", new { GoalId = goalId, Index = index });
        }
    }
}
