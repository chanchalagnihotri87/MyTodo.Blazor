namespace MyTodo.Blazor.Client.Data
{
    public class TodoItem : ITwentyPercent, ITextItem
    {
        public int Id { get; set; }
        public string Text { get; set; } = default!;
        public int TaskId { get; set; }
        public bool TwentyPercent { get; set; }
        public bool Completed { get; set; }
        public int Index { get; set; }
        public int? SprintId { get; set; }
        public DateTime? Date { get; set; }
        public TaskItem Task { get; set; } = default!;
    }
}
