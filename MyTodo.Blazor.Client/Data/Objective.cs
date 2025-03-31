namespace MyTodo.Blazor.Client.Data
{
    public class Objective : IListItem
    {
        public int Id { get; set; }
        public string Text { get; set; } = default!;
        public string Plan { get; set; } = default!;
        public int GoalId { get; set; }
        public bool TwentyPercent { get; set; }
        public bool Completed { get; set; }
        public int Index { get; set; }
    }
}
