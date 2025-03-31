using Microsoft.VisualBasic;
using MyTodo.Blazor.Client.Data.ApiResponse;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class TodoClient(HttpClient http)
    {
        public async Task<List<TodoItem>> GetManyAsync(int taskId)
        {
            return (await http.GetFromJsonAsync<TodosResponse>($"/todoitems/{taskId}")).TodoItems.ToList();
        }

        public async Task<List<TodoItem>> GetManyOfSprintAsync(int sprintId)
        {
            return (await http.GetFromJsonAsync<TodosResponse>($"/todoitems/sprint/{sprintId}")).TodoItems.ToList();
        }

        public async Task<TodoItem> GetAsync(int id)
        {
            return (await http.GetFromJsonAsync<TodoResponse>($"/todoitems/detail/{id}")).TodoItem;
        }


        public async Task CreateAsync(string text, int taskId)
        {
            await http.PostAsJsonAsync($"/todoitems", new { TodoItem = new { Text = text, taskId = taskId } });
        }

        public async Task UpdateTextAsync(int id, string text)
        {
            await http.PatchAsJsonAsync($"/todoitems/text/{id}", new { Text = text });
        }

        public async Task ToggleComplete(int id, bool completed)
        {
            await http.PatchAsJsonAsync($"/todoitems/complete/{id}", new { Completed = completed });
        }

        public async Task UpdateSprintAsync(int id, int? sprintId)
        {
            await http.PatchAsJsonAsync($"/todoitems/sprint/{id}", new { SprintId = sprintId });
        }

        public async Task UpdateDateAsync(int id, string date)
        {
            await http.PatchAsJsonAsync($"/todoitems/date/{id}", new { date = date });
        }

        public async Task DeleteAsync(int id)
        {
            await http.DeleteAsync($"/todoitems/{id}");
        }

        public async Task MoveAsync(int id, int index, int taskId)
        {
            await http.PatchAsJsonAsync($"/todoitems/move/{id}", new { taskId = taskId, Index = index });
        }
    }
}
