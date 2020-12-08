using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hospital_Management.Data;
using Hospital_Management.Models;

namespace Hospital_Management.Pages.Doctors
{
    public class IndexModel : PageModel
    {
        private readonly Hospital_Management.Data.Hospital_ManagementContext _context;

        public IndexModel(Hospital_Management.Data.Hospital_ManagementContext context)
        {
            _context = context;
        }

        public IList<Doctor> Doctor { get;set; }

        public async Task OnGetAsync()
        {
            Doctor = await _context.Doctor
                .Include(d => d.Hospital_ID).ToListAsync();
        }
    }
}
