using SalesForce.Data.Models;
using SalesForce.Data.Repositories;
using SalesForce.Data.Repositories.Interfaces;

namespace SalesForce.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Account> _accountRepository { get; }

        private readonly SalesforceContext _context;

        public UnitOfWork()
        {
            _context = new SalesforceContext();
            _accountRepository = new Repository<Account>(_context);
        }
    }
}