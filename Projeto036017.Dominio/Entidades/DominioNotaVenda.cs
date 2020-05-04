using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto036017.Dominio.Entidades
{
    public class DominioNotaVenda
    {
        [Required]
        [Key]
        public int IdNota { get; set; }

        [Required]
        [Display(Name = "Data:")]
        public DateTime DataNota { get; set; }

        [Required]
        public int IdItem { get; set; }

        [Required]
        public int IdCliente { get; set; }

        [Required]
        public int IdVendedor { get; set; }

    }
}
