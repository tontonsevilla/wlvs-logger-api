using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WLVSTools.Logger.Web.Data;
using WLVSTools.Logger.Web.Data.Entity;

namespace WLVSTools.Logger.Web.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private LoggerDbContext _db;

        public LogController(LoggerDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Logs.ToList());
        }

        [HttpPost]
        public IActionResult Post(Log log)
        {
            _db.Logs.Add(log);
            _db.SaveChanges();

            return Ok(log);
        }
    }
}
