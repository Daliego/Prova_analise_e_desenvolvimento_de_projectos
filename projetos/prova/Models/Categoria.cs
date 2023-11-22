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
        [Key, Required, Display(Name = "Codigo")]
        public int Id;
        [Display(Name = "Nome")]
        public string Nome;
        // [Display(Name = "Produtos"), ForeignKey("Produto")]
        // public int ProdutoId { get; set; }

        public List<Produto>? Produtos { get; set; }
    }
}