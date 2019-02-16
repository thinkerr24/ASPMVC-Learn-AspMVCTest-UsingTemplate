using System.Web.Mvc;

namespace AspMVCFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "<h1>Hello, World!</h1>";
        }
    }
}