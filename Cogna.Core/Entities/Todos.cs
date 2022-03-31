namespace Cogna.Core.Entities
{
    public class Todos
    {
        public Todos(string? title, string? description, DateTime? finishedAt)
        {
            Title = title;
            Description = description;
            CretedAt = DateTime.Now;
            FinishedAt = finishedAt;
        }

        public int IdTodos { get; private set; }
        public string? Title { get; private set; }
        public string? Description { get; private set; }
        public DateTime CretedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
    }
}
