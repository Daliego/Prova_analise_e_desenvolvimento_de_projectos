using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Models
{
    public class Carrinho
    {
        [Key, Required, Display(Name = "Código")]
        public int Id { get; set; }
        // [Display(Name = "Id do Usuario"), ForeignKey("Usuario")]

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }


        // [ForeignKey("Produto")]
        // public int ProdutoId { get; set; }
        public List<Produto>? Produtos { get; set; }
    }
}