using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AutoEscola.Pages.Funcionario {
    public class Funcionario {

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Funcao { get; set; }
        [DataType(DataType.Date)]
        public DateTime MyProperty { get; set; }
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
