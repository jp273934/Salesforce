using SalesForce.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SalesForce.Controllers.api
{
    public class AccountsController : ApiController
    {
        private readonly UnitOfWork _unitOfWork;

        public AccountsController()
        {
            _unitOfWork = new UnitOfWork();
        }

        public IHttpActionResult Get()
        {
            var accounts = _unitOfWork._accountRepository.Get();

            return Json(accounts);
        }
    }
}
