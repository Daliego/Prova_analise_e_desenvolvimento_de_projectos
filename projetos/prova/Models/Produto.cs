using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace prova.Models
{
    public class Produto
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }
        [Display(Name = "Caminho da Imagem")]
        public string PathImagem { get; set; }
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Categoria"), ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        [ForeignKey("Carrinho")]
        public int CarrinhoId { get; set; }
        public List<Carrinho>? Carrinhos { get; set; }
    }
}