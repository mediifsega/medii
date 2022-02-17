using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bereschi_Gabriel_Depozit.Data;
using Bereschi_Gabriel_Depozit.Models;

namespace Bereschi_Gabriel_Depozit.Pages.Proprietari
{
    public class DeleteModel : PageModel
    {
        private readonly Bereschi_Gabriel_Depozit.Data.Bereschi_Gabriel_DepozitContext _context;

        public DeleteModel(Bereschi_Gabriel_Depozit.Data.Bereschi_Gabriel_DepozitContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Proprietar Proprietar { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Proprietar = await _context.Proprietar.FirstOrDefaultAsync(m => m.ID == id);

            if (Proprietar == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Proprietar = await _context.Proprietar.FindAsync(id);

            if (Proprietar != null)
            {
                _context.Proprietar.Remove(Proprietar);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
