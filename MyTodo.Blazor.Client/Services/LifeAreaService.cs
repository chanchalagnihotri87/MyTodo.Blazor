using MyTodo.Blazor.Client.Services.Interfaces;

namespace MyTodo.Blazor.Client.Services
{
    public class LifeAreaService : ILifeAreaService
    {
        public LifeAreaService()
        {
            
        }
        public Task<LifeArea> AddLifeAreaAsync(LifeArea lifeArea)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLifeAreaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LifeArea> GetLifeAreaAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LifeArea>> GetLifeAreasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LifeArea> UpdateLifeAreaAsync(LifeArea lifeArea)
        {
            throw new NotImplementedException();
        }
    }
}
