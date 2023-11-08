using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace secondProject.Models
{
    public class FacultyMember : Member
    {

        [Required, Display(Name = "Faculty Name")]
        public string Fname { get; set; }
        [Required, Display(Name = "Faculty College")]
        public string FacultyColl { get; set; }

        public void CheckoutBook()
        {
            //Faz o checkout de um livro
        }
    }
}