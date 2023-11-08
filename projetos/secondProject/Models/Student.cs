using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secondProject.Models
{
    public class Student : Member
    {
        [Required, Display(Name = "Student Name")]
        public string Sname;
        [Required, Display(Name = "Student College")]
        public string StudentColl;
   
    public void CheckoutBook() {
        //Faz o checkout de um livro
    }

    public void ReturnBook() {
        //Faz o retorno de um livro
     }
}