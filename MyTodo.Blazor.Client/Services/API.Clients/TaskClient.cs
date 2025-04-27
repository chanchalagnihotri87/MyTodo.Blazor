using Microsoft.Extensions.Options;
using Microsoft.VisualBasic;
using MyTodo.Blazor.Client.Configurations;
using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class TaskClient(HttpClient http, IOptions<ApiServicePrefix> servicePrefixes) : BaseClient(servicePrefixes.Value.Task), IMyTodoHttpClient<TaskItem>
    {
        public async Task<List<TaskItem>> GetManyAsync(int objectiveId)
        {
            return (await http.GetFromJsonAsync<TasksResponse>(GetUrl($"/tasks/{objectiveId}"))).Tasks.ToList();
        }

        public async Task<TaskItem> GetAsync(int id)
        {
            return (await http.GetFromJsonAsync<TaskResponse>(GetUrl($"/tasks/detail/{id}"))).Task;
        }


        public async Task CreateAsync(string text, int objectiveId)
        {
            await http.PostAsJsonAsync(GetUrl($"/tasks"), new { Task = new { Text = text, ObjectiveId = objectiveId } });
        }

        public async Task UpdateTextAsync(int id, string text)
        {
            await http.PatchAsJsonAsync(GetUrl($"/tasks/text/{id}"), new { Text = text });
        }

        public async Task UpdatePlanAsync(int id, string plan)
        {
            await http.PatchAsJsonAsync(GetUrl($"/tasks/plan/{id}"), new { Plan = plan });
        }

        public async Task ToggleComplete(int id, bool completed)
        {
            await http.PatchAsJsonAsync(GetUrl($"/tasks/complete/{id}"), new { Completed = completed });
        }

        public async Task ToggleTwentyPercent(int id, bool twentyPercent)
        {
            await http.PatchAsJsonAsync(GetUrl($"/tasks/twentypercent/{id}"), new { TwentyPercent = twentyPercent });
        }

        public async Task DeleteAsync(int id)
        {
            await http.DeleteAsync(GetUrl($"/tasks/{id}"));
        }

        public async Task MoveAsync(int id, int index, int objectiveId)
        {
            await http.PatchAsJsonAsync(GetUrl($"/tasks/move/{id}"), new { ObjectiveId = objectiveId, Index = index });
        }
    }
}
