using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secondProject.Models
{
    public class Catalog
    {
        [Key, Required, Display(Name = "Catalog ID")]
        public int Id { get; set; }
        [Required, Display(Name = "Catalog author")]
        public string AuthorName { get; set; }
        [Required, Display(Name = "Cópias disponíveis")]
        public int NumberOfCopies;
        [Required, Display(Name = "Livros")]
        public List<Books> Books;

        public void UpdateInfo() {
            //Adiciona um livro ao catalogo
        }

        public void SearchInfo() {
            //Procura um livro no catalogo
        }
    }


}