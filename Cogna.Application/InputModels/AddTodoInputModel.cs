namespace Cogna.Application.InputModels
{
    public record AddTodoInputModel(
        string Title,
        string Description,
        DateTime? FinishedAt 
        )
    {
    }
}
