using GixxWings.Models;
using Microsoft.AspNetCore.Mvc;

namespace GixxWings.Controllers
{
    public class CustomerController : Controller
    {
        private readonly GixxWingsContext gw;
        private readonly ISession session;
        public CustomerController(GixxWingsContext _gw, IHttpContextAccessor HttpContextAccessor)
        {
             gw=_gw;
            session = HttpContextAccessor.HttpContext.Session;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Login l)
        {
            gw.Logins.Add(l);
            gw.SaveChanges();
            return RedirectToAction("login");
            
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login l)
        { var result = (from i in gw.Logins
                          where i.UserName == l.UserName && i.Password == l.Password
                          select i).SingleOrDefault();
            HttpContext.Session.SetString("UserName",l.UserName);
            if(result!= null) 
            {
                return RedirectToAction("SearchPage");
               
            }
            else 
            {
                return View();
            }}

        public IActionResult SearchPage(string Departure, string Arrival, DateTime TravelDate)
        {
            ViewBag.city = from i in gw.Cities
                           select i;

            if (Departure!=null)
            { var last = gw.FlightInfos.Where(i => i.Depature == Int32.Parse(Departure) && i.Arrival == Int32.Parse(Arrival)).ToList();
                return View("FlightInfo", last);
            }
            else
            {
                var flight = gw.FlightInfos.ToList();
                return View();
            }
            
        }
        public IActionResult PaymentPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PaymentPage(Payment p)
        {
            gw.Payments.Add(p);
            gw.SaveChanges();
            return RedirectToAction("Login");
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        
    }
}
