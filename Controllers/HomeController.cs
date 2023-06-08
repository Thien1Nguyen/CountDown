using Microsoft.AspNetCore.Mvc;
namespace PortfolioII.Controllers; 
public class HomeController : Controller
{
    [HttpGet("")] 
    [HttpGet("index")] 
    public ViewResult Index()
    {
        DateTime spookeyTime = new DateTime(2023, 10, 31, 2, 0, 20);
        ViewBag.CurrentTime = DateTime.Now.ToString(("MM/dd/yyyy h:mm tt"));
        ViewBag.SpookeyTime = spookeyTime.ToString("MM/dd/yyyy h:mm tt");
        ViewBag.CountDownDays = spookeyTime.Subtract(DateTime.Now).Days;
        ViewBag.CountDownHours = spookeyTime.Subtract(DateTime.Now).Hours;
        ViewBag.CountDownMins = spookeyTime.Subtract(DateTime.Now).Minutes;
        return View("Index");
    }

}