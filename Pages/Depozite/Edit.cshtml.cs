using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bereschi_Gabriel_Depozit.Data;
using Bereschi_Gabriel_Depozit.Models;

namespace Bereschi_Gabriel_Depozit.Pages.Depozite
{
    public class EditModel : PageModel
    {
        private readonly Bereschi_Gabriel_Depozit.Data.Bereschi_Gabriel_DepozitContext _context;

        public EditModel(Bereschi_Gabriel_Depozit.Data.Bereschi_Gabriel_DepozitContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Depozit Depozit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Depozit = await _context.Depozit.FirstOrDefaultAsync(m => m.ID == id);

            if (Depozit == null)
            {
                return NotFound();
            }
            ViewData["IDProprietar"] = new SelectList(_context.Set<Proprietar>(), "ID", "Nume");
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

            _context.Attach(Depozit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepozitExists(Depozit.ID))
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

        private bool DepozitExists(int id)
        {
            return _context.Depozit.Any(e => e.ID == id);
        }
    }
}
