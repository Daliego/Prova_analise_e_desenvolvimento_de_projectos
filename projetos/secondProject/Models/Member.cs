using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secondProject.Models
{
    public class Member
    {
        [Key, Required, Display(Name = "Member ID")]
        public int Id { get; set; }
        [Required, Display(Name = "Member Name")]
        public string Name { get; set; }
        [Required, Display(Name = "Member Address")]
        public string Address { get; set; }
        [Required, Display(Name = "Member Mobile Number")]
        public int MobileNumber { get; set; }
    
        public void MRequestForBook() {
            //Faz uma requisição de livro
        }
        public void MReturnBook() {
            //Faz o retorno de um livro
        }
    }


}