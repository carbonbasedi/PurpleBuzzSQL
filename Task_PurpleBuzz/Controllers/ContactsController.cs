using Microsoft.AspNetCore.Mvc;
using Task_PurpleBuzz.DAL;
using Task_PurpleBuzz.ViewModels.Contacts;

namespace Task_PurpleBuzz.Controllers
{
    public class ContactsController : Controller
    {
        private readonly AppDbContext _context;

        public ContactsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contactBannerComponent = _context.ContactsBannerComponents.FirstOrDefault();
            var contactSuccessComponent = _context.ContactsSuccessComponents.FirstOrDefault();

            var model = new ContactsIndexVM
            {
                ContactsBannerComponent = contactBannerComponent,
                ContactsSuccessComponent = contactSuccessComponent
            };

            return View(model);
        }
    }
}
