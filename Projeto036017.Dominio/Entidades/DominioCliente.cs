using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto036017.Dominio.Entidades
{
    public class DominioCliente
    {
        [Required]
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [Display(Name = "Nome do Cliente:")]
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
