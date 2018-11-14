using System.Collections.Generic;

namespace SalesForce.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T GetById(int id);
    }
}
