using Cogna.Core.Entities;

namespace Cogna.Core.Interfaces.Repositories
{
    public interface ITodosRepository
    {
        List<Todos> GetAll();
        void Add(Todos todos);
        void Update(Todos todos);
        Todos GetById(int id);
        void Delete(Todos todo);
    }
}
