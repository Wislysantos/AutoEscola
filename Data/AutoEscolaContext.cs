using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoEscola.Pages.Aluno;
using AutoEscola.Pages.Funcionario;

namespace AutoEscola.Data
{
    public class AutoEscolaContext : DbContext
    {
        public AutoEscolaContext (DbContextOptions<AutoEscolaContext> options)
            : base(options)
        {
        }

        public DbSet<AutoEscola.Pages.Aluno.Aluno> Aluno { get; set; }

        public DbSet<AutoEscola.Pages.Funcionario.Funcionario> Funcionario { get; set; }
    }
}
