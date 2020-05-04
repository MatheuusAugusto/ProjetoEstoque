using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto036017.Dominio.Entidades
{
    public class DominioPagamento
    {
        [Required]
        [Key]
        public int IdPagamento { get; set; }

        [Required]
        [Display(Name = "Data Limite:")]
        public DateTime DataLimite { get; set; }

        [Required]
        [Display(Name = "Valor:")]
        public decimal Valor { get; set; }

        [Required]
        [Display(Name = "Pago:")]
        public string Pago { get; set; }

        [Required]
        public int IdNota { get; set; }

    }
}
