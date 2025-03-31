
namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public interface IMyTodoHttpClient<T> where T : class
    {
        Task CreateAsync(string text, int parentId);
        Task DeleteAsync(int id);
        Task<List<T>> GetManyAsync(int parentId);
        Task MoveAsync(int id, int index, int parentId);
        Task ToggleComplete(int id, bool completed);
        Task ToggleTwentyPercent(int id, bool twentyPercent);
        Task UpdateTextAsync(int id, string text);
        Task UpdatePlanAsync(int id, string plan);
    }
}