using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto036017.Dominio.Entidades
{
    public class DominioItem
    {
        [Required]
        [Key]
        public int IdItem { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required]
        [Display(Name = "Quantidade:")]
        public int Quantidade { get; set; }

        [Required]
        public int IdProduto { get; set; }

    }
}
