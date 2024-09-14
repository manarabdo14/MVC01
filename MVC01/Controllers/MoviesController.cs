using Microsoft.AspNetCore.Mvc;

namespace MVC01.Controllers
{
    public class MoviesController : Controller
    {
        public void AddMovie()
        {

        }


        //public ContentResult Index() {
        //   ContentResult actionResult = new ContentResult();
        //    actionResult.Content = "Hello Manar";
        //    return actionResult;
        //}
        public ContentResult Index() {
    
            return  Content("Hello Manar");
        }


        public IActionResult Redirect() { 
            return RedirectToAction(nameof(Index));
        }
        //public IActionResult Redirect() { 
        //    RedirectResult redirectResult = new RedirectResult("https://localhost:44388/Movies");
        //    return redirectResult;
        //}


        //public RedirectResult Redirect() { 
        //    RedirectResult redirectResult = new RedirectResult("https://localhost:44388/Movies");
        //    return redirectResult;
        //}



    }
}
