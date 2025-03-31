namespace MyTodo.Blazor.Client.Data
{
    public class Problem: IListItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int LifeAreaId { get; set; }
        public bool TwentyPercent { get; set; }
        public bool Completed { get; set; }
        public int Index { get; set; }
        public string Plan { get; set; } = "";
    }
}
