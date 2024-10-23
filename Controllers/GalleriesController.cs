using GalleryProject.Data;
using GalleryProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GalleryProject.Controllers
{
    public class GalleriesController : Controller
    {
        public GalleryDbContext _context;
        public IConfiguration _config { get; }

        public GalleriesController
            (
            GalleryDbContext context,
            IConfiguration config
            )
        {
            _context = context;
            _config = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IEnumerable<Gallery> SearchResult()
        {
            var result = _context.Galleries
                .FromSqlRaw<Gallery>("spArtistsAge0To18")
                .ToList();

            return result;
        }
    }
}
