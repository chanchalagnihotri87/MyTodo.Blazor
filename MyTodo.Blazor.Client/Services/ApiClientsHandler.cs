using MyTodo.Blazor.Client.Configurations;

namespace MyTodo.Blazor.Client.Services
{
    public static class ApiClientsHandler
    {
        public static void ConfigureApiClients(this IServiceCollection services, IConfiguration configuration)
        {
            var apiUrl = configuration.GetSection("ApiUrl").Get<string>();

            services.AddHttpClient<LifeAreaClient>(client =>
                  client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<ProblemClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<IMyTodoHttpClient<Problem>, ProblemClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<GoalClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<IMyTodoHttpClient<Goal>, GoalClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<ObjectiveClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<IMyTodoHttpClient<Objective>, ObjectiveClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<TaskClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<IMyTodoHttpClient<TaskItem>, TaskClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<TodoClient>(client =>
                client.BaseAddress = new Uri(apiUrl));

            services.AddHttpClient<SprintClient>(client =>
               client.BaseAddress = new Uri(apiUrl));
        }

    }
}
