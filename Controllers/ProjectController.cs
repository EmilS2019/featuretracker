using Microsoft.AspNetCore.Mvc;

namespace featuretracker.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }    
}