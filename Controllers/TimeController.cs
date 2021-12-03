using Microsoft.AspNetCore.Mvc;
namespace Time.Controllers     //be sure to use your own project's namespace!
{
    public class TimeController : Controller   //remember inheritance??
    {
        
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            
            return View();
        }
    }
}

