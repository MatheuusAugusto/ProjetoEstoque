using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto036017.Dominio.Entidades
{
    public class DominioVendedor
    {
        [Required]
        [Key]
        public int IdVendedor { get; set; }

        [Required]
        [Display(Name = "Nome do Vendedor:")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "CPF:")]
        public string CPF { get; set; }

        [Required]
        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "Telefone:")]
        public string Telefone { get; set; }

    }
}
