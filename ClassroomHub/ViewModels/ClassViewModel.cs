using System;

using System.ComponentModel.DataAnnotations;

namespace ClassroomHub.Web.ViewModels
{
    public class ClassViewModel
    {
        public Guid Id { get; set; }
        [Display(Name="Nome")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Inicio")]
        [Required]
        public DateTime Start { get; set; }
        [Display(Name="Conclusao")]
        [Required]
        public DateTime End { get; set; }
    }
}
