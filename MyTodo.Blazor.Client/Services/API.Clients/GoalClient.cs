using Microsoft.VisualBasic;
using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class GoalClient(HttpClient http) : IMyTodoHttpClient<Goal>
    {

        public string BaseUrl  => http.BaseAddress.Host;
        public async Task<List<Goal>> GetManyAsync(int problemId)
        {
            return (await http.GetFromJsonAsync<GoalsResponse>($"/goals/{problemId}")).Goals.ToList();
        }

        public async Task<Goal> GetAsync(int id)
        {
            return (await http.GetFromJsonAsync<GoalResponse>($"/goals/detail/{id}")).Goal;
        }

        public async Task CreateAsync(string text, int problemId)
        {
            await http.PostAsJsonAsync($"/goals", new { Goal = new { Text = text, ProblemId = problemId } });
        }

        public async Task UpdateTextAsync(int id, string text)
        {
            await http.PatchAsJsonAsync($"/goals/text/{id}", new { Text = text });
        }

        public async Task UpdatePlanAsync(int id, string plan)
        {
            await http.PatchAsJsonAsync($"/goals/plan/{id}", new { Plan = plan });
        }

        public async Task ToggleComplete(int id, bool completed)
        {
            await http.PatchAsJsonAsync($"/goals/complete/{id}", new { Completed = completed });
        }

        public async Task ToggleTwentyPercent(int id, bool twentyPercent)
        {
            await http.PatchAsJsonAsync($"/goals/twentypercent/{id}", new { TwentyPercent = twentyPercent });
        }

        public async Task DeleteAsync(int id)
        {
            await http.DeleteAsync($"/goals/{id}");
        }

        public async Task MoveAsync(int id, int index, int problemId)
        {
            await http.PatchAsJsonAsync($"/goals/move/{id}", new { ProblemId = problemId, Index = index });
        }
    }
}
