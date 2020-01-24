using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FS.TesteASPNET.Web.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [DisplayName("Nome da Pessoa:")]
        [MaxLength(50, ErrorMessage = "O nome pode ter no max 50 Caracteres")]
        public string Nome { get; set; }

        [DisplayName("Idade da Pessoa:")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório")]
        [DisplayName("Enderço da Pessoa:")]
        [MaxLength(100, ErrorMessage = "O endereço pode ter no max 100 Caracteres")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [DisplayName("Email da Pessoa:")]
        [MaxLength(40, ErrorMessage = "O email pode ter no max 40 Caracteres")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool Ativo { get; set; }
    }
}