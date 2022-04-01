namespace Cogna.Application.InputModels
{
    public record UpdateTodoInputModel(
        string Title,
        string Description,
        DateTime? FinishedAt)
    {
    }
}
