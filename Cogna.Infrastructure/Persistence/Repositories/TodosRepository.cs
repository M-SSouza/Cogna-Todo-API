using Cogna.Core.Entities;
using Cogna.Core.Interfaces.Repositories;

namespace Cogna.Infrastructure.Persistence.Repositories
{
    public class TodosRepository : ITodosRepository
    {
        private readonly CognaDbContext _context;

        public TodosRepository(CognaDbContext context)
        {
            _context = context;
        }
        public void Add(Todos todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public void Delete(Todos todo)
        {
            _context.Todos.Remove(todo);
            _context.SaveChanges();
        }

        public List<Todos> GetAll()
        {
            return _context.Todos.ToList();
        }

        public Todos GetById(int id)
        {
            return _context.Todos.SingleOrDefault(t => t.IdTodos == id);
        }

        public void Update(Todos todo)
        {
            _context.Todos.Update(todo);
            _context.SaveChanges();
        }
    }
}
