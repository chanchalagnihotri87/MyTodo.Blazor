namespace MyTodo.Blazor.Client.Data.ApiResponse
{
    public class GoalsResponse
    {
      public  IList<Goal> Goals { get; set; }
    }

    public class GoalResponse
    {
        public Goal Goal { get; set; }
    }
}
