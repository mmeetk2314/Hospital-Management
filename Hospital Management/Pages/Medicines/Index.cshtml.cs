using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hospital_Management.Data;
using Hospital_Management.Models;

namespace Hospital_Management.Pages.Medicines
{
    public class IndexModel : PageModel
    {
        private readonly Hospital_Management.Data.Hospital_ManagementContext _context;

        public IndexModel(Hospital_Management.Data.Hospital_ManagementContext context)
        {
            _context = context;
        }

        public IList<Medicine> Medicine { get;set; }

        public async Task OnGetAsync()
        {
            Medicine = await _context.Medicine
                .Include(m => m.Hospital_ID).ToListAsync();
        }
    }
}
