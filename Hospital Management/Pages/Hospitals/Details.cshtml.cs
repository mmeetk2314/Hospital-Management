using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hospital_Management.Data;
using Hospital_Management.Models;

namespace Hospital_Management.Pages.Hospitals
{
    public class DetailsModel : PageModel
    {
        private readonly Hospital_Management.Data.Hospital_ManagementContext _context;

        public DetailsModel(Hospital_Management.Data.Hospital_ManagementContext context)
        {
            _context = context;
        }

        public Hospital Hospital { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hospital = await _context.Hospital.FirstOrDefaultAsync(m => m.HospitalID == id);

            if (Hospital == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
