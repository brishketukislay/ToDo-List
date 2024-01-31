using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Joke_App.Data;
using Joke_App.Models;

namespace Joke_App.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly Joke_App.Data.ApplicationDbContext _context;

        public IndexModel(Joke_App.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Task> Task { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Task = await _context.Task.ToListAsync();
        }
    }
}
