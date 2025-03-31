namespace MyTodo.Blazor.Client.Data.Dtos
{
    public class BreadCrumbItemDto
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public bool IsLink { get; set; } = true;
    }
}
