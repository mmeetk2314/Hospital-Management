using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hospital_Management.Data;
using Hospital_Management.Models;

namespace Hospital_Management.Pages.Medicines
{
    public class EditModel : PageModel
    {
        private readonly Hospital_Management.Data.Hospital_ManagementContext _context;

        public EditModel(Hospital_Management.Data.Hospital_ManagementContext context)
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
           ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Medicine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicineExists(Medicine.MedicineName))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MedicineExists(string id)
        {
            return _context.Medicine.Any(e => e.MedicineName == id);
        }
    }
}
