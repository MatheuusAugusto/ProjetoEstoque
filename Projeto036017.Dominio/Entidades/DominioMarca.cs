using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Projeto036017.Dominio.Entidades
{
    public class DominioMarca
    {
        [Required]
        [Key]
        public int IdMarca { get; set; }

        [Required]
        [Display(Name = "Nome da Marca:")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição:")]
        public string Descricao { get; set; }

    }
}
