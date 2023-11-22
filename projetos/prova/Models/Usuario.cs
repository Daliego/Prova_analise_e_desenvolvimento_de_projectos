using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Models
{
    public class Usuario
    {
        [Key, Display(Name = "Código")]
        public int Id { get; set; }
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Login { get; set; }
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }

        // [ForeignKey("Carrinho")]

        [ForeignKey("Carrinho")]
        public int CarrinhoId { get; set; }
        public Carrinho Carrinho { get; set; }
    }
}