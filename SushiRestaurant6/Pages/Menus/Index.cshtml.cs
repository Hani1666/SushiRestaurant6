﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SushiRestaurant6.Data;
using SushiRestaurant6.Model;

namespace SushiRestaurant6.Pages.Menus
{
    public class IndexModel : PageModel
    {
        private readonly SushiRestaurant6.Data.AppDbContext _context;

        public IndexModel(SushiRestaurant6.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Menu> Menu { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Menu = await _context.Menu.ToListAsync();
        }
    }
}
