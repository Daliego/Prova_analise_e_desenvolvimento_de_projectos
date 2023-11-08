using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace secondProject.Models
{
    public class Alert
    {
        [Key, Required, Display(Name = "Código")]
        public int Id { get; set; }

        [Required, Display(Name = "Ficha de emissão")]
        public DateTime IssueDate { get; set; }

        [Required, Display(Name = "Nome do livro")]
        public string BookName { get; set; }

        [Required, Display(Name = "Data de devolução")]
        public DateTime ReturnDate;

        [Required, Display(Name = "Bem")]
        public int Fine;

        public void FindCall() {
            //Executa o processo de procuar quem ligou para o elerta
        }

        public void ViewAlert() {
            //Exibe o alerta
        }

        public void SendToLibrarian() {
            //Envia o alerta para o bibliotecário
        }
        
        public void DeleteAlert() {
            //Apaga o alerta
        }
        
    }
}