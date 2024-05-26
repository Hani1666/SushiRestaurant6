using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SushiRestaurant6.Areas.Identity.Data;
using SushiRestaurant6.Model;
using SushiRestaurant6.Data;

namespace SushiRestaurant6.Pages.Categories
{
    public class DisplayModel : PageModel
    {
		private readonly AppDbContext _db;
		public IEnumerable<Category> Categories { get; set; }
		public DisplayModel(AppDbContext db)
		{
			_db = db;
		}

		public void OnGet()
        {
			Categories = _db.Category;
		}
    }
}
