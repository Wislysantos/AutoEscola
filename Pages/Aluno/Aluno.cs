using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoEscola.Pages.Aluno {
    public class Aluno {

        public int AlunoID { get; set; }
        public string NomeAluno { get; set; }
        public string Sexo { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataAluno { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public long Cpf { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public long Cep { get; set; }
        public string Estado { get; set; }
        public long Telefone { get; set; }
        public long Celular { get; set; }
    }
}
