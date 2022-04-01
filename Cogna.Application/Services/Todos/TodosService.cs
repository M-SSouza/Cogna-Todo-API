using Cogna.Application.InputModels;
using Cogna.Application.ViewModels;
using Cogna.Core.Interfaces.Repositories;

namespace Cogna.Application.Services.Todos
{
    public class TodosService : ITodosService
    {
        private readonly ITodosRepository _todosRepository;

        public TodosService(ITodosRepository todosRepository)
        {
            _todosRepository = todosRepository;
        }

        public void Add(AddTodoInputModel todo)
        {
            var newtodos = new Core.Entities.Todos(todo.Title, todo.Description, todo.FinishedAt);

            _todosRepository.Add(newtodos);
        }

        public bool Delete(int id)
        {
            var todo = _todosRepository.GetById(id);

            if (todo == null)
                return false;

            _todosRepository.Delete(todo);

            return true;
        }

        public List<TodosViewModel> GetAll()
        {
            return _todosRepository.GetAll().Select(t => new TodosViewModel(t.Title, t.Description, t.CretedAt, t.FinishedAt)).ToList();
        }

        public bool Update(int id, UpdateTodoInputModel todoInput)
        {
            var todo = _todosRepository.GetById(id);

            if (todo == null)
                return false;

            todo.Update(todoInput.Title, todoInput.Description, todoInput.FinishedAt);

            _todosRepository.Update(todo);

            return true;
        }
    }
}
