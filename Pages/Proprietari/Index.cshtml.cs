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
    public class IndexModel : PageModel
    {
        private readonly Bereschi_Gabriel_Depozit.Data.Bereschi_Gabriel_DepozitContext _context;

        public IndexModel(Bereschi_Gabriel_Depozit.Data.Bereschi_Gabriel_DepozitContext context)
        {
            _context = context;
        }

        public IList<Proprietar> Proprietar { get;set; }

        public async Task OnGetAsync()
        {
            Proprietar = await _context.Proprietar.ToListAsync();
        }
    }
}
