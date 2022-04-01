namespace Cogna.Application.ViewModels
{
    public class TodosViewModel
    {
        public TodosViewModel(string? title, string? description, DateTime cretedAt, DateTime? finishedAt)
        {
            Title = title;
            Description = description;
            CretedAt = cretedAt;
            FinishedAt = finishedAt;
        }

        public string? Title { get; private set; }
        public string? Description { get; private set; }
        public DateTime CretedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
    }
}
