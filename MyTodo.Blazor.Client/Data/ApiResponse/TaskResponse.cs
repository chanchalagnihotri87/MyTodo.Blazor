namespace MyTodo.Blazor.Client.Data.ApiResponse
{
    public class TasksResponse
    {
      public  IList<TaskItem> Tasks { get; set; }
    }

    public class TaskResponse
    {
        public TaskItem Task { get; set; }
    }
}
