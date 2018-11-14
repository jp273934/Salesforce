using SalesForce.Data.Models;
using SalesForce.Data.Repositories.Interfaces;

namespace SalesForce.Data
{
    public interface IUnitOfWork
    {
        IRepository<Account> _accountRepository {get; }
    }
}
