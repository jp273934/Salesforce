using SalesForce.Data;
using System.Web.Http;

namespace SalesForce.Controllers.api
{
    public class AccountsController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IHttpActionResult Get()
        {
            var accounts = _unitOfWork._accountRepository.Get();

            return Json(accounts);
        }
    }
}
