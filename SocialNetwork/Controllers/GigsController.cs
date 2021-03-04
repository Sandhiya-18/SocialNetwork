using SocialNetwork.Models;
using SocialNetwork.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace SocialNetwork.Controllers
{
    public class GigsController : Controller

    {

        private readonly ApplicationDbContext _context;
        public GigsController()
        {
            _context = new ApplicationDbContext();

        }
        public ActionResult Create()
        {
            var viewmodel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewmodel);
        }
    }
}