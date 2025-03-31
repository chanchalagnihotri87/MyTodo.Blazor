namespace MyTodo.Blazor.Client.Data.ApiResponse
{
    public class TodosResponse
    {
      public  IList<TodoItem> TodoItems { get; set; }
    }

    public class TodoResponse
    {
        public TodoItem TodoItem { get; set; }
    }
}
