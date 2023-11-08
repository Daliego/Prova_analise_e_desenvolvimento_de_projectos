using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secondProject.Models
{
    public class Librarian
    {
        [Key, Required, Display(Name = "Librarian ID")]
        public int Id { get; set; }
        [Required, Display(Name = "Librarian Name")]
        public string Name { get; set; }
        [Required, Display(Name = "Librarian Address")]
        public string Address { get; set; }
        [Required, Display(Name = "Librarian Mobile Number")]
        public int MobileNumber { get; set; }

        public void UpdateInfo() {
            //Atualiza as informações do bibliotecário
        }

        public void IssueBook() {
            //Emite um livro
        }

        public void MemberInfo() {
            //Exibe as informações do membro
        }

        public void SearchBook() {
            //Exibe o livro
        }

        public void ReturnBook() {
            //Retorna um livro
        }
    }


}