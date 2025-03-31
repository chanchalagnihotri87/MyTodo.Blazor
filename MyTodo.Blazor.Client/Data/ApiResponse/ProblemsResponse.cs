namespace MyTodo.Blazor.Client.Data.ApiResponse
{
    public class ProblemsResponse
    {
      public  IList<Problem> Problems { get; set; }
    }

    public class ProblemResponse
    {
        public Problem Problem { get; set; }
    }
}
