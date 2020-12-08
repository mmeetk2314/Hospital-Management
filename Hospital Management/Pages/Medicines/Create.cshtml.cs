using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hospital_Management.Data;
using Hospital_Management.Models;

namespace Hospital_Management.Pages.Medicines
{
    public class CreateModel : PageModel
    {
        private readonly Hospital_Management.Data.Hospital_ManagementContext _context;

        public CreateModel(Hospital_Management.Data.Hospital_ManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["HospitalID"] = new SelectList(_context.Hospital, "HospitalID", "HospitalID");
            return Page();
        }

        [BindProperty]
        public Medicine Medicine { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Medicine.Add(Medicine);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
