using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SushiRestaurant6.Pages
{
    [Authorize(Roles = "client")]

    public class clientModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
