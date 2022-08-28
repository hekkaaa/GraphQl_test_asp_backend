using GraphQlServer.Repository.Entities;
using GraphQlServer.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQlServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {   
        private readonly ITestService _service;

        public ValuesController(ITestService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Account>> GetAllAccount()
        {
            return _service.GetAllAccount();
        }

        [HttpPost]
        public ActionResult<bool> AddnewAccount(Account input)
        {
           var res = _service.AddAccount(input);
           return res;
        }
    }
}
