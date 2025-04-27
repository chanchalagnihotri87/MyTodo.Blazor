namespace MyTodo.Blazor.Client.Services.API.Clients
{
    public class BaseClient(string servicePrefix)
    {
        protected string GetUrl(string url)
        {
            return $"{servicePrefix}{url}";
        }
    }
}
