using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using WLVSTools.Logger.Web.Data;
using WLVSTools.Logger.Web.ViewModels.Home;

namespace WLVSTools.Logger.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoggerDbContext _dbContext;
        public HomeController(LoggerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                throw new Exception("Something went wrong.");
            }
            catch (Exception ex)
            {
                await _dbContext.Logs.AddAsync(new Data.Entity.Log
                {
                    Exception = ex.ToString(),
                    ExceptionMessage = ex.Message,
                    ExceptionSource = ex.Source,
                    ExceptionType = ex.GetType().Name,
                    AppName = "WLVSTools.Logger",
                    ExceptionUrl = Request.GetDisplayUrl()
                });

                await _dbContext.SaveChangesAsync();
            }

            return View(new HomeViewModel
            {
                Logs = _dbContext.Logs.ToList()
            });
        }
    }
}
