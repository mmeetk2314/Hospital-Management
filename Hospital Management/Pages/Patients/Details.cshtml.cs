using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hospital_Management.Data;
using Hospital_Management.Models;

namespace Hospital_Management.Pages.Patients
{
    public class DetailsModel : PageModel
    {
        private readonly Hospital_Management.Data.Hospital_ManagementContext _context;

        public DetailsModel(Hospital_Management.Data.Hospital_ManagementContext context)
        {
            _context = context;
        }

        public Patient Patient { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Patient = await _context.Patient
                .Include(p => p.Doctor_ID).FirstOrDefaultAsync(m => m.PatientID == id);

            if (Patient == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
