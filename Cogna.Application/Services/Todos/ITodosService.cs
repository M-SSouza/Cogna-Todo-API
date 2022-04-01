using Cogna.Application.InputModels;
using Cogna.Application.ViewModels;

namespace Cogna.Application.Services.Todos
{
    public interface ITodosService
    {
        List<TodosViewModel> GetAll();
        void Add(AddTodoInputModel todos);
        bool Update(int id, UpdateTodoInputModel todo);
        bool Delete(int id);
    }
}
