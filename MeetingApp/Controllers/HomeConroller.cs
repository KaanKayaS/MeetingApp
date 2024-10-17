using MeetingApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
       public IActionResult Index()
       {
           int saat =DateTime.Now.Hour;
           
           //ViewBag.Selamlama = saat>12?"İyi günler":"Günaydın";
           //ViewBag.Username = "Kaan";

           ViewData["Selamlama"] =  saat>12?"İyi günler":"Günaydın";
          // ViewData["Username"] = "Kaan";

           var meetingInfo = new MeetingInfo()
           {
              Id = 1,
              Location= "Antalya",
              Date= new DateTime(2024,01,20,20,0,0),
              NumberOfPeople = Repository.Users.Where(i=>i.WillAttend==true).Count() 
           };

           return View(meetingInfo);
       }

    }
}