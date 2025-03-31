namespace MyTodo.Blazor.Client.Data
{
    public interface IListItem: ITwentyPercent
    {
        int Id { get; set; }
        string Text { get; set; }
        bool Completed { get; set; }
        int Index { get; set; }
        string Plan { get; set; }
    }
}
