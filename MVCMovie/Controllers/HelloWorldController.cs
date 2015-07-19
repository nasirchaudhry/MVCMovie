//Lab Part 2: Replaced the contents of the file with the following code

using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        // Lab Part 3: Inserted ActionResult & View

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/
        //Lab Part 2: Replaced the Welcome method
        //Lab Part 3: Replaced the id with the numTimes
        //Lab Part 3: Replaced the string with the ActionResult

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            //Lab Part 3: Changed the Welcome method to add a Message and NumTimes value to the ViewBag
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}