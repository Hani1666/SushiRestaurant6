using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SushiRestaurant6.Data;
using SushiRestaurant6.Model;

namespace SushiRestaurant6.Pages.Menu
{
    public class CreateModel : PageModel
    {
        private readonly SushiRestaurant6.Data.AppDbContext _context;

        public CreateModel(SushiRestaurant6.Data.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Menu Menu { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Menu.Add(Menu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
