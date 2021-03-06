using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AutoEscola.Data;

namespace AutoEscola.Pages.Aluno
{
    public class DetailsModel : PageModel
    {
        private readonly AutoEscola.Data.AutoEscolaContext _context;

        public DetailsModel(AutoEscola.Data.AutoEscolaContext context)
        {
            _context = context;
        }

        public Aluno Aluno { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aluno = await _context.Aluno.FirstOrDefaultAsync(m => m.AlunoID == id);

            if (Aluno == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
