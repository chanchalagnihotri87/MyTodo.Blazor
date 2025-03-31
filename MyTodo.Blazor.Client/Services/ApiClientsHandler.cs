﻿namespace MyTodo.Blazor.Client.Services
{
    public static class ApiClientsHandler
    {
        public static void ConfigureApiClients(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<LifeAreaClient>(client =>
                  client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["LifeArea"]));

            services.AddHttpClient<ProblemClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Problem"]));

            services.AddHttpClient<IMyTodoHttpClient<Problem>, ProblemClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Problem"]));

            services.AddHttpClient<GoalClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Goal"]));

            services.AddHttpClient<IMyTodoHttpClient<Goal>, GoalClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Goal"]));

            services.AddHttpClient<ObjectiveClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Objective"]));

            services.AddHttpClient<IMyTodoHttpClient<Objective>, ObjectiveClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Objective"]));

            services.AddHttpClient<TaskClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Task"]));

            services.AddHttpClient<IMyTodoHttpClient<TaskItem>, TaskClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Task"]));

            services.AddHttpClient<TodoClient>(client =>
                client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Task"]));

            services.AddHttpClient<SprintClient>(client =>
               client.BaseAddress = new Uri(configuration.GetSection("ApiUrl")["Sprint"]));
        }

    }
}
