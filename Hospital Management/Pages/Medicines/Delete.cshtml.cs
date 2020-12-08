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
    public class DeleteModel : PageModel
    {
        private readonly Hospital_Management.Data.Hospital_ManagementContext _context;

        public DeleteModel(Hospital_Management.Data.Hospital_ManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Medicine Medicine { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medicine = await _context.Medicine
                .Include(m => m.Hospital_ID).FirstOrDefaultAsync(m => m.MedicineName == id);

            if (Medicine == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Medicine = await _context.Medicine.FindAsync(id);

            if (Medicine != null)
            {
                _context.Medicine.Remove(Medicine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
