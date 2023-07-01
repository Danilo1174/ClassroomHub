using System;

using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class ClassViewModel
    {
        public Guid Id { get; set; }
        [Display(Name="Nome")]
        [Required(ErrorMessage ="Obrigatorio inserir o nome do curso")]
        public string Name { get; set; }
        [Display(Name = "Inicio")]
        [Required(ErrorMessage ="Obrigatorio selecionar o inicio do curso")]
        public DateTime Start { get; set; }
        [Display(Name="Conclusao")]
        [Required(ErrorMessage =" Obrigatorio selecionar a data do fim do curso")]
        public DateTime End { get; set; }

        [Display(Name = "Curso")]
        [Required(ErrorMessage ="Obrigatorio selecionar o curso")]
        public Guid CourseId { get; set; }
        
    }
}
