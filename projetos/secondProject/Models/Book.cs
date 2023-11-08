using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secondProject.Models
{
    public class Books
    {
        [Key, Display(Name = "Book ID")]
        public int Id { get; set; }
        [Required, Display(Name = "Book Author")]
        public string AuthorName { get; set; }
        [Required, Display(Name = "Cópias disponíveis")]
        public int NumberOfBook { get; set; }
        [Required, Display(Name = "Catalogo")]
        public Catalog Catalog { get; set; }

        public void AddToCatalog() {
            //Adiciona ao catalogo
        }
        public void RemoveFromCatalog() {
            //Remove do catalogo
        }
    }
}