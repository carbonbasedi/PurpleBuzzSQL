using Microsoft.AspNetCore.Mvc;
using Task_PurpleBuzz.Models;
using Task_PurpleBuzz.ViewModels.Home;

namespace Task_PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var works = new List<Work>
            {
                new Work { Id = 1, Title = "Social Media", Desc = "Social Media Desc" ,ImgPath = "/assets/img/recent-work-01.jpg"},
                new Work { Id = 2, Title = "Web Marketing", Desc = "Social Media Desc" ,ImgPath = "./assets/img/recent-work-02.jpg"},
                new Work { Id = 3, Title = "R & D", Desc = "Social Media Desc" ,ImgPath = "/assets/img/recent-work-03.jpg"},
                new Work { Id = 4, Title = "Public Relation", Desc = "Social Media Desc" ,ImgPath = "/assets/img/recent-work-04.jpg"},
                new Work { Id = 5, Title = "Branding", Desc = "Social Media Desc" ,ImgPath = "/assets/img/recent-work-05.jpg"},
                new Work { Id = 6, Title = "Creative Design", Desc = "Social Media Desc" ,ImgPath = "/assets/img/recent-work-06.jpg"}
            };

            var model = new HomeIndexVM
            {
                WorkTitle = "Recent Works",
                Works = works,
            };

            return View(model);
        }
    }
}
