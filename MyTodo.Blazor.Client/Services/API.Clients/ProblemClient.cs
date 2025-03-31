using Microsoft.VisualBasic;
using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http.Json;
using System.Text.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class ProblemClient(HttpClient http) : IMyTodoHttpClient<Problem>
    {
        public async Task<List<Problem>> GetManyAsync(int lifeAreaId)
        {
            return (await http.GetFromJsonAsync<ProblemsResponse>($"/problems/{lifeAreaId}")).Problems.ToList();
        }

        public async Task<Problem> GetAsync(int id)
        {
            return (await http.GetFromJsonAsync<ProblemResponse>($"/problems/detail/{id}")).Problem;
        }



        public async Task CreateAsync(string text, int lifeAreaId)
        {
            await http.PostAsJsonAsync($"/problems", new { Problem = new { Text = text, LifeAreaId = lifeAreaId } });
        }

        public async Task UpdateTextAsync(int id, string text)
        {
            await http.PatchAsJsonAsync($"/problems/text/{id}", new { Text = text });
        }

        public async Task UpdatePlanAsync(int id, string plan)
        {
            await http.PatchAsJsonAsync($"/problems/plan/{id}", new { Plan = plan });
        }

        public async Task ToggleComplete(int id, bool completed)
        {
            await http.PatchAsJsonAsync($"/problems/complete/{id}", new { Completed = completed });
        }

        public async Task ToggleTwentyPercent(int id, bool twentyPercent)
        {
            await http.PatchAsJsonAsync($"/problems/twentypercent/{id}", new { TwentyPercent = twentyPercent });
        }

        public async Task DeleteAsync(int id)
        {
            await http.DeleteAsync($"/problems/{id}");
        }

        public async Task MoveAsync(int id, int index, int lifeAreaId)
        {
            await http.PatchAsJsonAsync($"/problems/move/{id}", new { LifeAreaId = lifeAreaId, Index = index });
        }
    }
}
