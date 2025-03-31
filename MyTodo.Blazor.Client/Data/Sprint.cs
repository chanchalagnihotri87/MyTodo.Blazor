namespace MyTodo.Blazor.Client.Data
{
    public class Sprint
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool Completed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
