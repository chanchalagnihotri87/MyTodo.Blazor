namespace MyTodo.Blazor.Client.Services.Interfaces
{
    public interface ILifeAreaService
    {
        Task<List<LifeArea>> GetLifeAreasAsync();
        Task<LifeArea> GetLifeAreaAsync(int id);
        Task<LifeArea> AddLifeAreaAsync(LifeArea lifeArea);
        Task<LifeArea> UpdateLifeAreaAsync(LifeArea lifeArea);
        Task DeleteLifeAreaAsync(int id);
    }
}
