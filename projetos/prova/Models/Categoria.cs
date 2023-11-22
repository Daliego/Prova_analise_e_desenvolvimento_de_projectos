using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Models
{
    public class Categoria
    {
        [Display(Name = "Codigo")]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        // [Display(Name = "Produtos"), ForeignKey("Produto")]
        // public int ProdutoId { get; set; }

        public List<Produto>? Produtos { get; set; }
    }
}