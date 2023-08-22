using efone.Data;
using Microsoft.AspNetCore.Mvc;

namespace efone.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContacsController : Controller
    {
        private readonly EfoneDbContext DbContext;

        public ContacsController(EfoneDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllContacts()
        {

            return Ok(DbContext.Contacts.ToList());
        }
    }
}
