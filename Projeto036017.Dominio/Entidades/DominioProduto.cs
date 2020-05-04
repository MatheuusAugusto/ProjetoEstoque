using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto036017.Dominio.Entidades
{
    public class DominioProduto
    {
        [Required]
        [Key]
        public int IdProduto { get; set; }

        [Required]
        [Display(Name = "Nome do Produto:")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Quantidade:")]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Preço:")]
        public decimal Preco { get; set; }

        [Required]
        public int IdMarca { get; set; }

    }
}